using System.Windows.Forms;
using System;

namespace _00_Vidu
{
    partial class Form1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnDirectoryExists = new System.Windows.Forms.Button();
            this.btnDirectoryGetFiles = new System.Windows.Forms.Button();
            this.btnDirectoryInfoExists = new System.Windows.Forms.Button();
            this.btnSplit = new System.Windows.Forms.Button();
            this.btnGhiFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 24;
            this.listBox1.Items.AddRange(new object[] {
            "Công Nghệ Thông Tin",
            "Tài Chính Kế Toán",
            "Kỹ Thuật Điện Tử",
            "Công nghệ ô tô"});
            this.listBox1.Location = new System.Drawing.Point(12, 20);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(526, 316);
            this.listBox1.TabIndex = 0;
            // 
            // btnDirectoryExists
            // 
            this.btnDirectoryExists.Location = new System.Drawing.Point(564, 12);
            this.btnDirectoryExists.Name = "btnDirectoryExists";
            this.btnDirectoryExists.Size = new System.Drawing.Size(204, 60);
            this.btnDirectoryExists.TabIndex = 1;
            this.btnDirectoryExists.Text = "Directory Exists";
            this.btnDirectoryExists.Click += new System.EventHandler(this.btnDirectoryExists_Click);
            // 
            // btnDirectoryGetFiles
            // 
            this.btnDirectoryGetFiles.Location = new System.Drawing.Point(564, 78);
            this.btnDirectoryGetFiles.Name = "btnDirectoryGetFiles";
            this.btnDirectoryGetFiles.Size = new System.Drawing.Size(204, 60);
            this.btnDirectoryGetFiles.TabIndex = 2;
            this.btnDirectoryGetFiles.Text = "Directory GetFiles";
            this.btnDirectoryGetFiles.Click += new System.EventHandler(this.btnDirectoryGetFiles_Click);
            // 
            // btnDirectoryInfoExists
            // 
            this.btnDirectoryInfoExists.Location = new System.Drawing.Point(564, 144);
            this.btnDirectoryInfoExists.Name = "btnDirectoryInfoExists";
            this.btnDirectoryInfoExists.Size = new System.Drawing.Size(204, 60);
            this.btnDirectoryInfoExists.TabIndex = 3;
            this.btnDirectoryInfoExists.Text = "DirectoryInfo Exists";
            // 
            // btnSplit
            // 
            this.btnSplit.Location = new System.Drawing.Point(564, 210);
            this.btnSplit.Name = "btnSplit";
            this.btnSplit.Size = new System.Drawing.Size(204, 60);
            this.btnSplit.TabIndex = 4;
            this.btnSplit.Text = "Split";
            // 
            // btnGhiFile
            // 
            this.btnGhiFile.Location = new System.Drawing.Point(564, 276);
            this.btnGhiFile.Name = "btnGhiFile";
            this.btnGhiFile.Size = new System.Drawing.Size(204, 60);
            this.btnGhiFile.TabIndex = 5;
            this.btnGhiFile.Text = "Ghi File";
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(787, 354);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnDirectoryExists);
            this.Controls.Add(this.btnDirectoryGetFiles);
            this.Controls.Add(this.btnDirectoryInfoExists);
            this.Controls.Add(this.btnSplit);
            this.Controls.Add(this.btnGhiFile);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test Directory & Info";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private ListBox listBox1;
        private Button btnDirectoryExists, btnDirectoryGetFiles, btnDirectoryInfoExists, btnSplit, btnGhiFile;
    }
}

