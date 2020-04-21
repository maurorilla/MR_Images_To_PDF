﻿namespace MR_PDF_Tools
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnJpgToPDF = new System.Windows.Forms.Button();
            this.btnAddJPG = new System.Windows.Forms.Button();
            this.btnMoveUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.pPreview = new System.Windows.Forms.PictureBox();
            this.FileList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRemoveAll = new System.Windows.Forms.Button();
            this.lblsize = new System.Windows.Forms.Label();
            this.ckFolder = new System.Windows.Forms.CheckBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // btnJpgToPDF
            // 
            this.btnJpgToPDF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnJpgToPDF.Image = global::MR_Images_To_PDF.Properties.Resources.PDF_Save_24_x24;
            this.btnJpgToPDF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnJpgToPDF.Location = new System.Drawing.Point(967, 549);
            this.btnJpgToPDF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnJpgToPDF.Name = "btnJpgToPDF";
            this.btnJpgToPDF.Size = new System.Drawing.Size(119, 48);
            this.btnJpgToPDF.TabIndex = 0;
            this.btnJpgToPDF.Text = "Create PDF";
            this.btnJpgToPDF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnJpgToPDF.UseVisualStyleBackColor = true;
            this.btnJpgToPDF.Click += new System.EventHandler(this.btnJpg_Click);
            // 
            // btnAddJPG
            // 
            this.btnAddJPG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddJPG.Location = new System.Drawing.Point(11, 549);
            this.btnAddJPG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddJPG.Name = "btnAddJPG";
            this.btnAddJPG.Size = new System.Drawing.Size(149, 48);
            this.btnAddJPG.TabIndex = 3;
            this.btnAddJPG.Text = "Add Images ...";
            this.btnAddJPG.UseVisualStyleBackColor = true;
            this.btnAddJPG.Click += new System.EventHandler(this.btnAddJPG_Click);
            // 
            // btnMoveUp
            // 
            this.btnMoveUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMoveUp.Location = new System.Drawing.Point(613, 12);
            this.btnMoveUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMoveUp.Name = "btnMoveUp";
            this.btnMoveUp.Size = new System.Drawing.Size(57, 48);
            this.btnMoveUp.TabIndex = 5;
            this.btnMoveUp.Text = "Move Up";
            this.btnMoveUp.UseVisualStyleBackColor = true;
            this.btnMoveUp.Click += new System.EventHandler(this.btnMoveUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDown.Location = new System.Drawing.Point(613, 487);
            this.btnDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(57, 48);
            this.btnDown.TabIndex = 6;
            this.btnDown.Text = "Mode Down";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemove.Location = new System.Drawing.Point(187, 549);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(132, 48);
            this.btnRemove.TabIndex = 7;
            this.btnRemove.Text = "Remove From List";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // pPreview
            // 
            this.pPreview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pPreview.BackColor = System.Drawing.Color.White;
            this.pPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pPreview.Location = new System.Drawing.Point(677, 12);
            this.pPreview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pPreview.Name = "pPreview";
            this.pPreview.Size = new System.Drawing.Size(407, 524);
            this.pPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pPreview.TabIndex = 8;
            this.pPreview.TabStop = false;
            // 
            // FileList
            // 
            this.FileList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FileList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.FileList.FullRowSelect = true;
            this.FileList.GridLines = true;
            this.FileList.HideSelection = false;
            this.FileList.Location = new System.Drawing.Point(11, 9);
            this.FileList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FileList.MultiSelect = false;
            this.FileList.Name = "FileList";
            this.FileList.Size = new System.Drawing.Size(597, 527);
            this.FileList.TabIndex = 12;
            this.FileList.UseCompatibleStateImageBehavior = false;
            this.FileList.View = System.Windows.Forms.View.Details;
            this.FileList.SelectedIndexChanged += new System.EventHandler(this.FileList_SelectedIndexChanged_1);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "FileName";
            this.columnHeader1.Width = 538;
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemoveAll.Location = new System.Drawing.Point(459, 549);
            this.btnRemoveAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Size = new System.Drawing.Size(149, 48);
            this.btnRemoveAll.TabIndex = 13;
            this.btnRemoveAll.Text = "Remove All";
            this.btnRemoveAll.UseVisualStyleBackColor = true;
            this.btnRemoveAll.Click += new System.EventHandler(this.btnRemoveAll_Click);
            // 
            // lblsize
            // 
            this.lblsize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblsize.AutoSize = true;
            this.lblsize.Location = new System.Drawing.Point(677, 543);
            this.lblsize.Name = "lblsize";
            this.lblsize.Size = new System.Drawing.Size(20, 17);
            this.lblsize.TabIndex = 14;
            this.lblsize.Text = "...";
            // 
            // ckFolder
            // 
            this.ckFolder.AutoSize = true;
            this.ckFolder.Checked = true;
            this.ckFolder.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckFolder.Location = new System.Drawing.Point(680, 576);
            this.ckFolder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ckFolder.Name = "ckFolder";
            this.ckFolder.Size = new System.Drawing.Size(178, 21);
            this.ckFolder.TabIndex = 15;
            this.ckFolder.Text = "Open Folder after Save";
            this.ckFolder.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(330, 565);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(98, 17);
            this.linkLabel1.TabIndex = 16;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "AGPL License";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 612);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.ckFolder);
            this.Controls.Add(this.lblsize);
            this.Controls.Add(this.btnRemoveAll);
            this.Controls.Add(this.FileList);
            this.Controls.Add(this.pPreview);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnMoveUp);
            this.Controls.Add(this.btnAddJPG);
            this.Controls.Add(this.btnJpgToPDF);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1114, 649);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MR Images To PDF 1.1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnJpgToPDF;
        private System.Windows.Forms.Button btnAddJPG;
        private System.Windows.Forms.Button btnMoveUp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.PictureBox pPreview;
        private System.Windows.Forms.ListView FileList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button btnRemoveAll;
        private System.Windows.Forms.Label lblsize;
        private System.Windows.Forms.CheckBox ckFolder;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}