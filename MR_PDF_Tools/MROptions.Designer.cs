
namespace MR_Images_To_PDF
{
    partial class MROptions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MROptions));
            this.cType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Margin_Top = new System.Windows.Forms.NumericUpDown();
            this.Margin_Right = new System.Windows.Forms.NumericUpDown();
            this.Margin_Left = new System.Windows.Forms.NumericUpDown();
            this.Margin_Bottom = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ckVertical = new System.Windows.Forms.CheckBox();
            this.ckOrizontal = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.Margin_Top)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Margin_Right)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Margin_Left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Margin_Bottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cType
            // 
            this.cType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cType.FormattingEnabled = true;
            this.cType.Location = new System.Drawing.Point(98, 12);
            this.cType.Name = "cType";
            this.cType.Size = new System.Drawing.Size(224, 21);
            this.cType.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Page Size:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Margins:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(269, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 41);
            this.button1.TabIndex = 31;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Margin_Top
            // 
            this.Margin_Top.Location = new System.Drawing.Point(169, 84);
            this.Margin_Top.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.Margin_Top.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Margin_Top.Name = "Margin_Top";
            this.Margin_Top.Size = new System.Drawing.Size(47, 20);
            this.Margin_Top.TabIndex = 33;
            this.Margin_Top.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Margin_Right
            // 
            this.Margin_Right.Location = new System.Drawing.Point(262, 204);
            this.Margin_Right.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.Margin_Right.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Margin_Right.Name = "Margin_Right";
            this.Margin_Right.Size = new System.Drawing.Size(47, 20);
            this.Margin_Right.TabIndex = 34;
            this.Margin_Right.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Margin_Left
            // 
            this.Margin_Left.Location = new System.Drawing.Point(76, 204);
            this.Margin_Left.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.Margin_Left.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Margin_Left.Name = "Margin_Left";
            this.Margin_Left.Size = new System.Drawing.Size(47, 20);
            this.Margin_Left.TabIndex = 35;
            this.Margin_Left.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Margin_Bottom
            // 
            this.Margin_Bottom.Location = new System.Drawing.Point(169, 341);
            this.Margin_Bottom.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.Margin_Bottom.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Margin_Bottom.Name = "Margin_Bottom";
            this.Margin_Bottom.Size = new System.Drawing.Size(47, 20);
            this.Margin_Bottom.TabIndex = 36;
            this.Margin_Bottom.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MR_Images_To_PDF.Properties.Resources.Page;
            this.pictureBox1.Location = new System.Drawing.Point(91, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 260);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 388);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 41);
            this.button2.TabIndex = 37;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Orientation :";
            // 
            // ckVertical
            // 
            this.ckVertical.AutoSize = true;
            this.ckVertical.Checked = true;
            this.ckVertical.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckVertical.Location = new System.Drawing.Point(99, 48);
            this.ckVertical.Name = "ckVertical";
            this.ckVertical.Size = new System.Drawing.Size(61, 17);
            this.ckVertical.TabIndex = 39;
            this.ckVertical.Text = "Vertical";
            this.ckVertical.UseVisualStyleBackColor = true;
            this.ckVertical.CheckedChanged += new System.EventHandler(this.ckVertical_CheckedChanged);
            this.ckVertical.Click += new System.EventHandler(this.ckVertical_Click);
            // 
            // ckOrizontal
            // 
            this.ckOrizontal.AutoSize = true;
            this.ckOrizontal.Location = new System.Drawing.Point(169, 48);
            this.ckOrizontal.Name = "ckOrizontal";
            this.ckOrizontal.Size = new System.Drawing.Size(67, 17);
            this.ckOrizontal.TabIndex = 40;
            this.ckOrizontal.Text = "Orizontal";
            this.ckOrizontal.UseVisualStyleBackColor = true;
            this.ckOrizontal.CheckedChanged += new System.EventHandler(this.ckOrizontal_CheckedChanged);
            this.ckOrizontal.Click += new System.EventHandler(this.ckOrizontal_Click);
            // 
            // MROptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 441);
            this.Controls.Add(this.ckOrizontal);
            this.Controls.Add(this.ckVertical);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Margin_Bottom);
            this.Controls.Add(this.Margin_Left);
            this.Controls.Add(this.Margin_Right);
            this.Controls.Add(this.Margin_Top);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MROptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Options";
            this.Load += new System.EventHandler(this.MROptions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Margin_Top)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Margin_Right)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Margin_Left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Margin_Bottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown Margin_Top;
        private System.Windows.Forms.NumericUpDown Margin_Right;
        private System.Windows.Forms.NumericUpDown Margin_Left;
        private System.Windows.Forms.NumericUpDown Margin_Bottom;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox ckVertical;
        private System.Windows.Forms.CheckBox ckOrizontal;
    }
}