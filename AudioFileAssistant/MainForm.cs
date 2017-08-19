using System;
using System.Windows.Forms;
using AudioFileAssistant.Models;
using AudioFileAssistant.Helpers;

namespace AudioFileAssistant
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void BtnProcess_Click(object sender, EventArgs e)
        {
            lblResult.Visible = false;
            var result = new RenameResult();

            if (!string.IsNullOrEmpty(txtBxDirectory.Text))
            {
                // Modify the file names by removing or replacing the string entered
                if (chkbxShorten.Checked)
                {
                    result = FileHelper.RemoveStringsWithinFileNames(txtBxDirectory.Text, txtBxToDelete.Text, txtBxReplacementStr.Text);

                    if (!result.Success)
                    {
                        lblResult.Visible = true;
                        lblResult.Text = result.Message;
                        return;
                    }
                }

                // Add track numbers to file names
                if (chkbxAddTrackNo.Checked)
                {
                    result = FileHelper.AddTrackNumsToFileNames(txtBxDirectory.Text);

                    if (!result.Success)
                    {
                        lblResult.Visible = true;
                        lblResult.Text = result.Message;

                        return;
                    }
                }
                if (result.Success)
                {
                    MessageBox.Show("Files were successfully renamed!");
                }     
            }
            else
            {
                lblResult.Visible = true;
                lblResult.Text = "Please select directory";
            }
        }

        private void ChbxRemove_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxRemove.Checked)
                txtBxReplacementStr.Enabled = true;
            else
            {
                txtBxReplacementStr.Text = "";
                txtBxReplacementStr.Enabled = false;
            }
        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtBxDirectory.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void ChkbxShorten_CheckedChanged(object sender, EventArgs e)
        {
            chbxRemove.Enabled = chkbxShorten.Checked;

            if ((!chkbxShorten.Checked) || ((chbxRemove.Enabled) && (chbxRemove.Checked)))
            {
                txtBxReplacementStr.Enabled = chkbxShorten.Checked;
            }
        }

        private void BtnCopyTags_Click(object sender, EventArgs e)
        {
            var sourcePath = TxtbxSourceFolder.Text;
            var targetPath = TxtbxTargetFolder.Text;

            if (!DirectoryHelper.IsValidDirectory(sourcePath) || !DirectoryHelper.IsValidDirectory(targetPath))
            {
                LblInfo.Text = "You need to enter a valid path for both folders";
                return;
            }

            var filteredSourceFilePaths = DirectoryHelper.GetAudioFilePaths(sourcePath);
            var filteredTargetFilePaths = DirectoryHelper.GetAudioFilePaths(targetPath);

            if (filteredSourceFilePaths.Count != filteredTargetFilePaths.Count)
            {
                LblInfo.Text = "Both folders must have the same amount of audio files";
                return;
            }

            try
            {
                DirectoryHelper.CopyAudioTags(filteredSourceFilePaths, filteredTargetFilePaths);
                MessageBox.Show("Finished copying tags!", "Info");
                LblInfo.Text = string.Empty;
            }
            catch (Exception ex)
            {
                LblInfo.Text = $"Oh dear, something went wrong: {ex.Message}";
                return;
            }
        }
    }
}
