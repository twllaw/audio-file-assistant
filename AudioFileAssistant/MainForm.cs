using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProjects
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
            RenameResult res = new RenameResult();

            // Directory has been selected
            if (!string.IsNullOrEmpty(txtBxDirectory.Text))
            {
                // Modify the file names by removing or replacing the string entered
                if (chkbxShorten.Checked)
                {
                    if (!string.IsNullOrEmpty(txtBxToDelete.Text))
                        res = RemoveStringsWithinFileNames();
                    else
                    {
                        lblResult.Visible = true;
                        lblResult.Text = "Please enter the string you want to remove from file names.";
                    }

                    if (!res.Success)
                    {
                        lblResult.Visible = true;
                        lblResult.Text = res.Message;
                        return;
                    }
                }

                // Add track numbers to file names
                if (chkbxAddTrackNo.Checked)
                {
                    res = AddTrackNumsToFileNames();

                    if (!res.Success)
                    {
                        lblResult.Visible = true;
                        lblResult.Text = res.Message;
                        return;
                    }
                }
                if (res.Success)
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

        private RenameResult RemoveStringsWithinFileNames()
        {
            RenameResult renameResult = 
                FileOperations.RemoveStringsWithinFileNames(txtBxDirectory.Text, txtBxToDelete.Text, txtBxReplacementStr.Text);

            return renameResult;
        }

        private RenameResult AddTrackNumsToFileNames()
        {
            RenameResult renameResult =
                FileOperations.AddTrackNumsToFileNames(txtBxDirectory.Text);

            return renameResult;
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
                this.txtBxDirectory.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void ChkbxShorten_CheckedChanged(object sender, EventArgs e)
        {
            HideOrShowHitButton();
            txtBxToDelete.Enabled = chkbxShorten.Checked;
            chbxRemove.Enabled = chkbxShorten.Checked;

            if ((!chkbxShorten.Checked) || ((chbxRemove.Enabled) && (chbxRemove.Checked)))
            {
                txtBxReplacementStr.Enabled = chkbxShorten.Checked;
            }
        }

        private void ChkbxAddTrackNo_CheckedChanged(object sender, EventArgs e)
        {
            HideOrShowHitButton();
        }

        private void TxtBxToDelete_TextChanged(object sender, EventArgs e)
        {
            HideOrShowHitButton();
        }

        private void HideOrShowHitButton()
        {
            btnProcess.Enabled = false;
            if (((chkbxShorten.Checked) && (txtBxToDelete.Text != "")) ||
                (chkbxAddTrackNo.Checked))
            {
                btnProcess.Enabled = true;
            }
        }
    }
}
