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

namespace MR_PDF_Tools
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
            SFD.FileName = $"PDF_{DateTime.Now:dd_MM_yyyy_HHhh}.pdf";
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
            var document = new Document(iTextSharp.text.PageSize.A4, 25, 25, 25, 25);
            using (var stream = new FileStream(pdf, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                PdfWriter.GetInstance(document, stream);
                document.Open();
                using (var imageStream = new FileStream(jpgfile, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    var image = iTextSharp.text.Image.GetInstance(imageStream);
                    if (image.Height > iTextSharp.text.PageSize.A4.Height - 25)
                    {
                        image.ScaleToFit(iTextSharp.text.PageSize.A4.Width - 25, iTextSharp.text.PageSize.A4.Height - 25);
                    }
                    else if (image.Width > iTextSharp.text.PageSize.A4.Width - 25)
                    {
                        image.ScaleToFit(iTextSharp.text.PageSize.A4.Width - 25, iTextSharp.text.PageSize.A4.Height - 25);
                    }
                    image.Alignment = iTextSharp.text.Image.ALIGN_MIDDLE;
                    document.Add(image);
                }

                document.Close();
            }
        }

        private void btnAddJPG_Click(object sender, EventArgs e)
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
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (FileList.SelectedItems.Count > 0)
            {
                FileList.Items.RemoveAt(FileList.SelectedItems[0].Index);
            }
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
            FileList.Items.Clear();
            pPreview.Image = null;
            lblsize.Text = "...";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://github.com/maurorilla/MR_Images_To_PDF");
            Process.Start(sInfo);            
        }
    }
}
