using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace FileRenamer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnBrowseFiles_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.InitialDirectory = "c:\\";
                dialog.Multiselect = true;
                dialog.Title = "Files to rename";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string[] fileNames = dialog.FileNames;
                    if (fileNames.Count() > 0)
                    {
                        for (int i = 0; i < fileNames.Count(); i++)
                        {
                            if (i == 0 && txtFilePaths.Text.Length > 0)
                            {
                                txtFilePaths.Text += ",";
                            }
                            txtFilePaths.Text += fileNames[i];
                            if (i != fileNames.Count() - 1)
                            {
                                txtFilePaths.Text += ",";
                            }
                        }
                        txtNewName.Enabled = true;
                    }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ToggleLockFieldsAndButtons(true);
            if (txtFilePaths.Text.Length > 0)
            {
                if (txtFilePaths.Text.Contains(","))
                {
                    string[] filePaths = txtFilePaths.Text.Split(',');
                    Dictionary<string, List<string>> pathDictionary = new Dictionary<string, List<string>>();
                    foreach (string path in filePaths)
                    {
                        string directory = Path.GetDirectoryName(path) + "\\";
                        if (pathDictionary.ContainsKey(directory))
                        {
                            List<string> fileNames = pathDictionary[directory];
                            string fileName = Path.GetFileName(path);
                            fileNames.Add(fileName);
                        }
                        else
                        {
                            List<string> fileNames = new List<string>();
                            string fileName = Path.GetFileName(path);
                            fileNames.Add(fileName);
                            pathDictionary.Add(directory, fileNames);
                        }
                    }
                    bool canContinue = true;
                    foreach (KeyValuePair<string, List<string>> pair in pathDictionary)
                    {
                        if (pair.Value.Count() > 1)
                        {
                            DialogResult result = MessageBox.Show("There are multiple files in a selected directory.  Continue renaming them with a number appended to the end?\r\n(ex. filename-1.txt)", "Multiple files in directory", MessageBoxButtons.YesNo);
                            if (result == DialogResult.No || result == DialogResult.Cancel)
                            {
                                canContinue = false;
                            }
                        }
                    }
                    if (canContinue)
                    {
                        foreach (KeyValuePair<string, List<string>> pair in pathDictionary)
                        {
                            string newFileName = txtNewName.Text;
                            if (pair.Value.Count() > 1)
                            {
                                for (int i = 0; i < pair.Value.Count(); i++)
                                {
                                    newFileName = txtNewName.Text + "-" + (i + 1);
                                    try
                                    {
                                        File.Move(pair.Key + pair.Value[i], pair.Key + newFileName + Path.GetExtension(pair.Value[i]));
                                    }
                                    catch (Exception ex)
                                    {
                                        txtErrorMessages.AppendText($"Error renaming file at {pair.Key + pair.Value[0]}");
                                        txtErrorMessages.AppendText(Environment.NewLine);
                                        txtErrorMessages.AppendText(ex.Message.ToString());
                                        txtErrorMessages.AppendText(Environment.NewLine);
                                        txtErrorMessages.AppendText("-----------------------");
                                    }
                                }
                            }
                            else
                            {
                                try
                                {
                                    File.Move(pair.Key + pair.Value[0], pair.Key + newFileName + Path.GetExtension(pair.Value[0]));
                                }
                                catch (Exception ex)
                                {
                                    txtErrorMessages.AppendText($"Error renaming file at {pair.Key + pair.Value[0]}");
                                    txtErrorMessages.AppendText(Environment.NewLine);
                                    txtErrorMessages.AppendText(ex.Message.ToString());
                                    txtErrorMessages.AppendText(Environment.NewLine);
                                    txtErrorMessages.AppendText("-----------------------");
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("File rename aborted.");
                    }
                }
            }
            txtFilePaths.Enabled = true;
            txtFilePaths.Text = "";
            btnBrowseFiles.Enabled = true;
            txtNewName.Text = "";
            txtErrorMessages.AppendText("### File renaming completed! ###");
        }

        private void ToggleLockFieldsAndButtons(bool isLock)
        {
            btnBrowseFiles.Enabled = !isLock;
            btnUpdate.Enabled = !isLock;
            txtFilePaths.Enabled = !isLock;
            txtNewName.Enabled = !isLock;
        }

        private void txtFilePaths_TextChanged(object sender, EventArgs e)
        {
            if (this.Text.Length > 0)
            {
                txtNewName.Enabled = true;
            }
            else
            {
                txtNewName.Enabled = false;
            }
        }

        private void txtNewName_TextChanged(object sender, EventArgs e)
        {
            if (this.Text.Length > 0)
            {
                btnUpdate.Enabled = true;
            }
            else
            {
                btnUpdate.Enabled = false;
            }
        }
    }
}
