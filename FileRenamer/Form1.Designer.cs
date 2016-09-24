namespace MyProjects
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
            System.Windows.Forms.Label label1;
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
            label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AllowDrop = true;
            label1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(12, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(405, 25);
            label1.TabIndex = 0;
            label1.Text = "Because Bandcamp and their long-ass file names...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "String to delete:";
            // 
            // txtBxToDelete
            // 
            this.txtBxToDelete.Enabled = false;
            this.txtBxToDelete.Location = new System.Drawing.Point(15, 148);
            this.txtBxToDelete.Name = "txtBxToDelete";
            this.txtBxToDelete.Size = new System.Drawing.Size(363, 20);
            this.txtBxToDelete.TabIndex = 1;
            this.txtBxToDelete.TextChanged += new System.EventHandler(this.txtBxToDelete_TextChanged);
            // 
            // btnProcess
            // 
            this.btnProcess.Enabled = false;
            this.btnProcess.Location = new System.Drawing.Point(15, 248);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(75, 23);
            this.btnProcess.TabIndex = 4;
            this.btnProcess.Text = "Hit it!";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // txtBxDirectory
            // 
            this.txtBxDirectory.Location = new System.Drawing.Point(15, 64);
            this.txtBxDirectory.Name = "txtBxDirectory";
            this.txtBxDirectory.ReadOnly = true;
            this.txtBxDirectory.Size = new System.Drawing.Size(363, 20);
            this.txtBxDirectory.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "File directory";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(12, 290);
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
            this.chbxRemove.Location = new System.Drawing.Point(15, 188);
            this.chbxRemove.Name = "chbxRemove";
            this.chbxRemove.Size = new System.Drawing.Size(155, 17);
            this.chbxRemove.TabIndex = 2;
            this.chbxRemove.Text = "Replace with another string";
            this.chbxRemove.UseVisualStyleBackColor = true;
            this.chbxRemove.CheckedChanged += new System.EventHandler(this.chbxRemove_CheckedChanged);
            // 
            // txtBxReplacementStr
            // 
            this.txtBxReplacementStr.Enabled = false;
            this.txtBxReplacementStr.Location = new System.Drawing.Point(15, 211);
            this.txtBxReplacementStr.Name = "txtBxReplacementStr";
            this.txtBxReplacementStr.Size = new System.Drawing.Size(363, 20);
            this.txtBxReplacementStr.TabIndex = 3;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(384, 61);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 6;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // chkbxShorten
            // 
            this.chkbxShorten.AutoSize = true;
            this.chkbxShorten.Location = new System.Drawing.Point(15, 102);
            this.chkbxShorten.Name = "chkbxShorten";
            this.chkbxShorten.Size = new System.Drawing.Size(113, 17);
            this.chkbxShorten.TabIndex = 8;
            this.chkbxShorten.Text = "Shorten file names";
            this.chkbxShorten.UseVisualStyleBackColor = true;
            this.chkbxShorten.CheckedChanged += new System.EventHandler(this.chkbxShorten_CheckedChanged);
            // 
            // chkbxAddTrackNo
            // 
            this.chkbxAddTrackNo.AutoSize = true;
            this.chkbxAddTrackNo.Location = new System.Drawing.Point(148, 102);
            this.chkbxAddTrackNo.Name = "chkbxAddTrackNo";
            this.chkbxAddTrackNo.Size = new System.Drawing.Size(177, 17);
            this.chkbxAddTrackNo.TabIndex = 9;
            this.chkbxAddTrackNo.Text = "Add track numbers to file names";
            this.chkbxAddTrackNo.UseVisualStyleBackColor = true;
            this.chkbxAddTrackNo.CheckedChanged += new System.EventHandler(this.chkbxAddTrackNo_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 324);
            this.Controls.Add(this.chkbxAddTrackNo);
            this.Controls.Add(this.chkbxShorten);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtBxReplacementStr);
            this.Controls.Add(this.chbxRemove);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtBxDirectory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.txtBxToDelete);
            this.Controls.Add(this.label2);
            this.Controls.Add(label1);
            this.Name = "Form1";
            this.Text = "Music File Renamer";
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}