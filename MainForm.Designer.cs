namespace FileRenamer
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtFilePaths = new System.Windows.Forms.TextBox();
            this.btnBrowseFiles = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNewName = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtErrorMessages = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "File Paths";
            // 
            // txtFilePaths
            // 
            this.txtFilePaths.Location = new System.Drawing.Point(16, 30);
            this.txtFilePaths.Name = "txtFilePaths";
            this.txtFilePaths.Size = new System.Drawing.Size(275, 20);
            this.txtFilePaths.TabIndex = 1;
            this.txtFilePaths.TextChanged += new System.EventHandler(this.txtFilePaths_TextChanged);
            // 
            // btnBrowseFiles
            // 
            this.btnBrowseFiles.Location = new System.Drawing.Point(297, 28);
            this.btnBrowseFiles.Name = "btnBrowseFiles";
            this.btnBrowseFiles.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseFiles.TabIndex = 2;
            this.btnBrowseFiles.Text = "Browse";
            this.btnBrowseFiles.UseVisualStyleBackColor = true;
            this.btnBrowseFiles.Click += new System.EventHandler(this.btnBrowseFiles_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "New Name";
            // 
            // txtNewName
            // 
            this.txtNewName.Enabled = false;
            this.txtNewName.Location = new System.Drawing.Point(16, 84);
            this.txtNewName.Name = "txtNewName";
            this.txtNewName.Size = new System.Drawing.Size(275, 20);
            this.txtNewName.TabIndex = 4;
            this.txtNewName.TextChanged += new System.EventHandler(this.txtNewName_TextChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(297, 82);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtErrorMessages
            // 
            this.txtErrorMessages.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtErrorMessages.Enabled = false;
            this.txtErrorMessages.Location = new System.Drawing.Point(16, 111);
            this.txtErrorMessages.Multiline = true;
            this.txtErrorMessages.Name = "txtErrorMessages";
            this.txtErrorMessages.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtErrorMessages.Size = new System.Drawing.Size(356, 138);
            this.txtErrorMessages.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.txtErrorMessages);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtNewName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBrowseFiles);
            this.Controls.Add(this.txtFilePaths);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "File Renamer for Windows";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFilePaths;
        private System.Windows.Forms.Button btnBrowseFiles;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNewName;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtErrorMessages;
    }
}

