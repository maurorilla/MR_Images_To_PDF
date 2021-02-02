using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MR_Images_To_PDF
{
    public partial class MROptions : Form
    {
        public MROptions()
        {
            InitializeComponent();
        }

        private void MROptions_Load(object sender, EventArgs e)
        {
            //TODO: Implententare gestione
            var ListTypees = new string[] {"LETTER", "A0", "A1", "A2", "A3", "A4", "A5", "A6", "A7", "A8", "A9", "A10",
"B0", "B1", "B2", "B3", "B4", "B5", "B6", "B7", "B8", "B9", "B10",
"NOTE", "LEGAL", "HALFLETTER", "TABLOID", "EXECUTIVE", "POSTCARD" }.ToList();
            cType.Items.Clear();
            foreach (var p1 in ListTypees)
            {
                cType.Items.Add(p1);
            }

            cType.SelectedItem = Properties.Settings.Default.LetterFormat;
            Margin_Top.Value = Properties.Settings.Default.MarginTop;
            Margin_Bottom.Value = Properties.Settings.Default.MarginBottom;
            Margin_Left.Value = Properties.Settings.Default.MarginLeft;
            Margin_Right.Value = Properties.Settings.Default.MarginRight;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.LetterFormat = cType.SelectedItem.ToString();
            Properties.Settings.Default.MarginTop = (int)Margin_Top.Value;
            Properties.Settings.Default.MarginBottom = (int)Margin_Bottom.Value;
            Properties.Settings.Default.MarginLeft = (int)Margin_Left.Value;
            Properties.Settings.Default.MarginRight = (int)Margin_Right.Value;
            
            Properties.Settings.Default.Vertical = (ckVertical.Checked);

            Properties.Settings.Default.Save();
            this.Close();
        }

        private void ckVertical_CheckedChanged(object sender, EventArgs e)
        {
         
        }

        private void ckOrizontal_CheckedChanged(object sender, EventArgs e)
        {
         
        }

        private void ckVertical_Click(object sender, EventArgs e)
        {
            ckVertical.Checked = true;
            ckOrizontal.Checked = false;
        }

        private void ckOrizontal_Click(object sender, EventArgs e)
        {
            ckVertical.Checked = false;
            ckOrizontal.Checked = true;
        }
    }
}
