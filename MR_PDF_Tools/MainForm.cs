using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MR_Images_To_PDF
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnJpg_Click(object sender, EventArgs e)
        {
            if (FileList.Items.Count == 0)
            {
                MessageBox.Show("Add Images to generate the pdf file.");
                return;
            }
            var SFD = new SaveFileDialog();
            SFD.FileName = $"PDF_{DateTime.Now:dd_MM_yyyy_HHmmss}.pdf";
            SFD.Filter = "File PDF|*.PDF";
            if (SFD.ShowDialog() == DialogResult.OK)
            {
                var myPath = Path.GetTempPath() + "\\MR_PDF_Tools_tmp\\";
                if (!Directory.Exists(myPath)) Directory.CreateDirectory(myPath);
                //Creo una cartella
                myPath = $"{myPath}{DateTime.Now.ToString("yyyyMMddHHmmss")}\\";
                if (!Directory.Exists(myPath)) Directory.CreateDirectory(myPath);

                //Copio i file e li ridimensione
                var i = 1;
                var MyList = new List<string>();
                foreach (ListViewItem l1 in FileList.Items)
                {
                    var CurrentFile = l1.Text;
                    var NewFile = myPath + "Pag_" + i + Path.GetExtension(CurrentFile);
                    File.Copy(CurrentFile, NewFile);
                    var NewFilePDF = NewFile + ".pdf";
                    ConvertJPG2PDF(NewFile, NewFilePDF);
                    File.Delete(NewFile);
                    i++;
                    MyList.Add(NewFilePDF);
                }

                MergeFiles(SFD.FileName, MyList.ToArray());
                if (ckFolder.Checked) Process.Start(Path.GetDirectoryName(SFD.FileName));
            }
        }
        public static string GetAppPath()
        {
            return System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
        }


        public static void MergeFiles(string destinationFile, string[] sourceFiles)
        {

            try
            {
                int f = 0;
                // we create a reader for a certain document
                PdfReader reader = new PdfReader(sourceFiles[f]);
                // we retrieve the total number of pages
                int n = reader.NumberOfPages;
                //Console.WriteLine("There are " + n + " pages in the original file.");
                // step 1: creation of a document-object
                Document document = new Document(reader.GetPageSizeWithRotation(1));
                // step 2: we create a writer that listens to the document
                PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(destinationFile, FileMode.Create));
                // step 3: we open the document
                document.Open();
                PdfContentByte cb = writer.DirectContent;
                PdfImportedPage page;
                int rotation;
                // step 4: we add content
                while (f < sourceFiles.Length)
                {
                    int i = 0;
                    while (i < n)
                    {
                        i++;
                        document.SetPageSize(reader.GetPageSizeWithRotation(i));
                        document.NewPage();
                        page = writer.GetImportedPage(reader, i);
                        rotation = reader.GetPageRotation(i);
                        if (rotation == 90 || rotation == 270)
                        {
                            cb.AddTemplate(page, 0, -1f, 1f, 0, 0, reader.GetPageSizeWithRotation(i).Height);
                        }
                        else
                        {
                            cb.AddTemplate(page, 1f, 0, 0, 1f, 0, 0);
                        }
                        //Console.WriteLine("Processed page " + i);
                    }
                    f++;
                    if (f < sourceFiles.Length)
                    {
                        reader = new PdfReader(sourceFiles[f]);
                        // we retrieve the total number of pages
                        n = reader.NumberOfPages;
                        //Console.WriteLine("There are " + n + " pages in the original file.");
                    }
                }
                // step 5: we close the document
                document.Close();
            }
            catch (Exception e)
            {
                string strOb = e.Message;
            }
        }


        void ConvertJPG2PDF(string jpgfile, string pdf)
        {

            var PageS = iTextSharp.text.PageSize.A4;
            switch (Properties.Settings.Default.LetterFormat)
            {
                case "LETTER": PageS = iTextSharp.text.PageSize.LETTER; break;
                case "A0": PageS = iTextSharp.text.PageSize.A0; break;
                case "A1": PageS = iTextSharp.text.PageSize.A1; break;
                case "A2": PageS = iTextSharp.text.PageSize.A2; break;
                case "A3": PageS = iTextSharp.text.PageSize.A3; break;
                case "A4": PageS = iTextSharp.text.PageSize.A4; break;
                case "A5": PageS = iTextSharp.text.PageSize.A5; break;
                case "A6": PageS = iTextSharp.text.PageSize.A6; break;
                case "A7": PageS = iTextSharp.text.PageSize.A7; break;
                case "A8": PageS = iTextSharp.text.PageSize.A8; break;
                case "A9": PageS = iTextSharp.text.PageSize.A9; break;
                case "A10": PageS = iTextSharp.text.PageSize.A10; break;
                case "B0": PageS = iTextSharp.text.PageSize.B0; break;
                case "B1": PageS = iTextSharp.text.PageSize.B1; break;
                case "B2": PageS = iTextSharp.text.PageSize.B2; break;
                case "B3": PageS = iTextSharp.text.PageSize.B3; break;
                case "B4": PageS = iTextSharp.text.PageSize.B4; break;
                case "B5": PageS = iTextSharp.text.PageSize.B5; break;
                case "B6": PageS = iTextSharp.text.PageSize.B6; break;
                case "B7": PageS = iTextSharp.text.PageSize.B7; break;
                case "B8": PageS = iTextSharp.text.PageSize.B8; break;
                case "B9": PageS = iTextSharp.text.PageSize.B9; break;
                case "B10": PageS = iTextSharp.text.PageSize.B10; break;
                case "NOTE": PageS = iTextSharp.text.PageSize.NOTE; break;
                case "LEGAL": PageS = iTextSharp.text.PageSize.LEGAL; break;
                case "HALFLETTER": PageS = iTextSharp.text.PageSize.HALFLETTER; break;
                case "TABLOID": PageS = iTextSharp.text.PageSize.TABLOID; break;
                case "EXECUTIVE": PageS = iTextSharp.text.PageSize.EXECUTIVE; break;
                case "POSTCARD": PageS = iTextSharp.text.PageSize.POSTCARD; break;
                default:
                    break;
            }

            var Mt = Properties.Settings.Default.MarginTop;
            var Mb = Properties.Settings.Default.MarginBottom;
            var Ml = Properties.Settings.Default.MarginLeft;
            var Mr = Properties.Settings.Default.MarginRight;


            if (Properties.Settings.Default.Vertical == false) PageS = PageS.Rotate();

            var document = new Document(PageS, Properties.Settings.Default.MarginLeft, Properties.Settings.Default.MarginRight,
                                                           Properties.Settings.Default.MarginTop, Properties.Settings.Default.MarginBottom);
            document.AddAuthor("MR Images to PDF - Developed by Mauro Rilla - https://misterm.itch.io/mr-images-to-pdf");
            using (var stream = new FileStream(pdf, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                PdfWriter.GetInstance(document, stream);
                document.Open();
                using (var imageStream = new FileStream(jpgfile, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    var image = iTextSharp.text.Image.GetInstance(imageStream);
                    if (image.Height > (PageS.Height - (Mt + Mb)))
                    {
                        image.ScaleToFit(PageS.Width - (Ml + Mr), PageS.Height - (Mt + Mb));
                    }
                    else if (image.Width > PageS.Width - (Ml + Mr))
                    {
                        image.ScaleToFit(PageS.Width - (Ml + Mr), PageS.Height - (Mt + Mb));
                    }
                    image.Alignment = iTextSharp.text.Image.ALIGN_MIDDLE;
                    document.Add(image);
                }

                document.Close();
            }
        }

        private void btnAddJPG_Click(object sender, EventArgs e)
        {

        }

        void AddImages()
        {
            var OfD = new OpenFileDialog();
            OfD.Filter = "Images (*.JPG)|*.JPEG;*.JPG;*.PNG";
            OfD.Multiselect = true;
            OfD.Title = "MR PDF File - Select Images";
            if (OfD.ShowDialog(this) == DialogResult.OK)
            {
                foreach (var f1 in OfD.FileNames)
                {
                    FileList.Items.Add(f1);
                }
            }
        }

        private void btnMoveUp_Click(object sender, EventArgs e)
        {
            //FileList
            if (FileList.SelectedItems.Count > 0)
            {
                if (FileList.SelectedItems[0].Index > 0)
                {
                    var i = FileList.SelectedItems[0].Index;
                    var FF = FileList.Items[i - 1].Text;
                    var F2 = FileList.Items[i].Text;

                    FileList.Items[i - 1].Text = F2;
                    FileList.Items[i].Text = FF;

                    FileList.SelectedItems.Clear();
                    FileList.Items[i - 1].Focused = true;
                    FileList.Items[i - 1].Selected = true;
                }
            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            //FileList
            if (FileList.SelectedItems.Count > 0)
            {
                var i = FileList.SelectedItems[0].Index;
                if (i < FileList.Items.Count - 1)
                {

                    var FF = FileList.Items[i + 1].Text;
                    var F2 = FileList.Items[i].Text;

                    FileList.Items[i + 1].Text = F2;
                    FileList.Items[i].Text = FF;


                    FileList.SelectedItems.Clear();
                    FileList.Items[i + 1].Focused = true;
                    FileList.Items[i + 1].Selected = true;
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

        }


        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void FileList_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (FileList.SelectedItems.Count > 0)
            {
                var FileName = FileList.Items[FileList.SelectedItems[0].Index].Text;
                pPreview.Image = System.Drawing.Image.FromFile(FileName);
                lblsize.Text = pPreview.Image.Width + " x " + pPreview.Image.Height;
            }
            else
            {
                pPreview.Image = null;
                lblsize.Text = "...";
            }
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            AddImages();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (FileList.SelectedItems.Count > 0)
            {
                FileList.Items.RemoveAt(FileList.SelectedItems[0].Index);
            }
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            NewDoc();
        }
        void NewDoc()
        {
            FileList.Items.Clear();
            pPreview.Image = null;
            lblsize.Text = "...";
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewDoc();
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            var f1 = new MRAboutBox();
            f1.ShowDialog();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            var f1 = new MROptions();
            f1.ShowDialog();
        }
    }
}
