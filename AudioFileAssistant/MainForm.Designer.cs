namespace AudioFileAssistant
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label LblTagCopier;
            this.label2 = new System.Windows.Forms.Label();
            this.txtBxToDelete = new System.Windows.Forms.TextBox();
            this.btnProcess = new System.Windows.Forms.Button();
            this.txtBxDirectory = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.chbxRemove = new System.Windows.Forms.CheckBox();
            this.txtBxReplacementStr = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.chkbxShorten = new System.Windows.Forms.CheckBox();
            this.chkbxAddTrackNo = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.LblInfo = new System.Windows.Forms.Label();
            this.BtnCopyTags = new System.Windows.Forms.Button();
            this.TxtbxTargetFolder = new System.Windows.Forms.TextBox();
            this.TxtbxSourceFolder = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            LblTagCopier = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AllowDrop = true;
            label1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(6, 14);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(405, 25);
            label1.TabIndex = 0;
            label1.Text = "Because Bandcamp and their long ass file names...";
            // 
            // LblTagCopier
            // 
            LblTagCopier.AllowDrop = true;
            LblTagCopier.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LblTagCopier.Location = new System.Drawing.Point(6, 13);
            LblTagCopier.Name = "LblTagCopier";
            LblTagCopier.Size = new System.Drawing.Size(405, 25);
            LblTagCopier.TabIndex = 1;
            LblTagCopier.Text = "Copy all the tags!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "String to delete:";
            // 
            // txtBxToDelete
            // 
            this.txtBxToDelete.Enabled = false;
            this.txtBxToDelete.Location = new System.Drawing.Point(9, 151);
            this.txtBxToDelete.Name = "txtBxToDelete";
            this.txtBxToDelete.Size = new System.Drawing.Size(363, 20);
            this.txtBxToDelete.TabIndex = 1;
            this.txtBxToDelete.TextChanged += new System.EventHandler(this.TxtBxToDelete_TextChanged);
            // 
            // btnProcess
            // 
            this.btnProcess.Enabled = false;
            this.btnProcess.Location = new System.Drawing.Point(9, 251);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(75, 23);
            this.btnProcess.TabIndex = 4;
            this.btnProcess.Text = "Hit it!";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.BtnProcess_Click);
            // 
            // txtBxDirectory
            // 
            this.txtBxDirectory.Location = new System.Drawing.Point(9, 67);
            this.txtBxDirectory.Name = "txtBxDirectory";
            this.txtBxDirectory.ReadOnly = true;
            this.txtBxDirectory.Size = new System.Drawing.Size(363, 20);
            this.txtBxDirectory.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "File directory";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(6, 293);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(49, 13);
            this.lblResult.TabIndex = 5;
            this.lblResult.Text = "ERROR:";
            this.lblResult.Visible = false;
            // 
            // chbxRemove
            // 
            this.chbxRemove.AutoSize = true;
            this.chbxRemove.Enabled = false;
            this.chbxRemove.Location = new System.Drawing.Point(9, 191);
            this.chbxRemove.Name = "chbxRemove";
            this.chbxRemove.Size = new System.Drawing.Size(155, 17);
            this.chbxRemove.TabIndex = 2;
            this.chbxRemove.Text = "Replace with another string";
            this.chbxRemove.UseVisualStyleBackColor = true;
            this.chbxRemove.CheckedChanged += new System.EventHandler(this.ChbxRemove_CheckedChanged);
            // 
            // txtBxReplacementStr
            // 
            this.txtBxReplacementStr.Enabled = false;
            this.txtBxReplacementStr.Location = new System.Drawing.Point(9, 214);
            this.txtBxReplacementStr.Name = "txtBxReplacementStr";
            this.txtBxReplacementStr.Size = new System.Drawing.Size(363, 20);
            this.txtBxReplacementStr.TabIndex = 3;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(378, 64);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 6;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // chkbxShorten
            // 
            this.chkbxShorten.AutoSize = true;
            this.chkbxShorten.Location = new System.Drawing.Point(9, 105);
            this.chkbxShorten.Name = "chkbxShorten";
            this.chkbxShorten.Size = new System.Drawing.Size(113, 17);
            this.chkbxShorten.TabIndex = 8;
            this.chkbxShorten.Text = "Shorten file names";
            this.chkbxShorten.UseVisualStyleBackColor = true;
            this.chkbxShorten.CheckedChanged += new System.EventHandler(this.ChkbxShorten_CheckedChanged);
            // 
            // chkbxAddTrackNo
            // 
            this.chkbxAddTrackNo.AutoSize = true;
            this.chkbxAddTrackNo.Location = new System.Drawing.Point(142, 105);
            this.chkbxAddTrackNo.Name = "chkbxAddTrackNo";
            this.chkbxAddTrackNo.Size = new System.Drawing.Size(177, 17);
            this.chkbxAddTrackNo.TabIndex = 9;
            this.chkbxAddTrackNo.Text = "Add track numbers to file names";
            this.chkbxAddTrackNo.UseVisualStyleBackColor = true;
            this.chkbxAddTrackNo.CheckedChanged += new System.EventHandler(this.ChkbxAddTrackNo_CheckedChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 1;
            this.tabControl1.Size = new System.Drawing.Size(501, 345);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chkbxShorten);
            this.tabPage1.Controls.Add(label1);
            this.tabPage1.Controls.Add(this.chkbxAddTrackNo);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtBxToDelete);
            this.tabPage1.Controls.Add(this.btnBrowse);
            this.tabPage1.Controls.Add(this.btnProcess);
            this.tabPage1.Controls.Add(this.txtBxReplacementStr);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.chbxRemove);
            this.tabPage1.Controls.Add(this.txtBxDirectory);
            this.tabPage1.Controls.Add(this.lblResult);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(493, 319);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "File Renamer";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.LblInfo);
            this.tabPage2.Controls.Add(this.BtnCopyTags);
            this.tabPage2.Controls.Add(this.TxtbxTargetFolder);
            this.tabPage2.Controls.Add(this.TxtbxSourceFolder);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(LblTagCopier);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(493, 319);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tag Copier";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // LblInfo
            // 
            this.LblInfo.AutoSize = true;
            this.LblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInfo.ForeColor = System.Drawing.Color.Red;
            this.LblInfo.Location = new System.Drawing.Point(10, 259);
            this.LblInfo.Name = "LblInfo";
            this.LblInfo.Size = new System.Drawing.Size(0, 13);
            this.LblInfo.TabIndex = 7;
            // 
            // BtnCopyTags
            // 
            this.BtnCopyTags.Location = new System.Drawing.Point(13, 212);
            this.BtnCopyTags.Name = "BtnCopyTags";
            this.BtnCopyTags.Size = new System.Drawing.Size(105, 23);
            this.BtnCopyTags.TabIndex = 2;
            this.BtnCopyTags.Text = "Copy tags!";
            this.BtnCopyTags.UseVisualStyleBackColor = true;
            this.BtnCopyTags.Click += new System.EventHandler(this.BtnCopyTags_Click);
            // 
            // TxtbxTargetFolder
            // 
            this.TxtbxTargetFolder.Location = new System.Drawing.Point(13, 131);
            this.TxtbxTargetFolder.Name = "TxtbxTargetFolder";
            this.TxtbxTargetFolder.Size = new System.Drawing.Size(335, 20);
            this.TxtbxTargetFolder.TabIndex = 1;
            // 
            // TxtbxSourceFolder
            // 
            this.TxtbxSourceFolder.Location = new System.Drawing.Point(13, 70);
            this.TxtbxSourceFolder.Name = "TxtbxSourceFolder";
            this.TxtbxSourceFolder.Size = new System.Drawing.Size(335, 20);
            this.TxtbxSourceFolder.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Target Folder";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Source Folder";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(292, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Ensure that both folders have the right audio files!";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 370);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "Audio File Assistant";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBxToDelete;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.TextBox txtBxDirectory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.CheckBox chbxRemove;
        private System.Windows.Forms.TextBox txtBxReplacementStr;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.CheckBox chkbxShorten;
        private System.Windows.Forms.CheckBox chkbxAddTrackNo;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button BtnCopyTags;
        private System.Windows.Forms.TextBox TxtbxTargetFolder;
        private System.Windows.Forms.TextBox TxtbxSourceFolder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblInfo;
        private System.Windows.Forms.Label label6;
    }
}