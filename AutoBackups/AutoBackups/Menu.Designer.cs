namespace AutoBackups
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbSourceDirectory = new System.Windows.Forms.Label();
            this.tbSourceDirectory = new System.Windows.Forms.TextBox();
            this.lbBackupDirectory = new System.Windows.Forms.Label();
            this.tbBackupDirectory = new System.Windows.Forms.TextBox();
            this.btCreateBackup = new System.Windows.Forms.Button();
            this.btOpenBackupFolder = new System.Windows.Forms.Button();
            this.btOpenSourceFolder = new System.Windows.Forms.Button();
            this.cbCopySubdirectories = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lbSourceDirectory
            // 
            this.lbSourceDirectory.AutoSize = true;
            this.lbSourceDirectory.Location = new System.Drawing.Point(30, 33);
            this.lbSourceDirectory.Name = "lbSourceDirectory";
            this.lbSourceDirectory.Size = new System.Drawing.Size(193, 32);
            this.lbSourceDirectory.TabIndex = 0;
            this.lbSourceDirectory.Text = "Source directory:";
            // 
            // tbSourceDirectory
            // 
            this.tbSourceDirectory.Location = new System.Drawing.Point(30, 83);
            this.tbSourceDirectory.Name = "tbSourceDirectory";
            this.tbSourceDirectory.Size = new System.Drawing.Size(683, 39);
            this.tbSourceDirectory.TabIndex = 1;
            // 
            // lbBackupDirectory
            // 
            this.lbBackupDirectory.AutoSize = true;
            this.lbBackupDirectory.Location = new System.Drawing.Point(30, 163);
            this.lbBackupDirectory.Name = "lbBackupDirectory";
            this.lbBackupDirectory.Size = new System.Drawing.Size(197, 32);
            this.lbBackupDirectory.TabIndex = 2;
            this.lbBackupDirectory.Text = "Backup directory:";
            // 
            // tbBackupDirectory
            // 
            this.tbBackupDirectory.Location = new System.Drawing.Point(30, 217);
            this.tbBackupDirectory.Name = "tbBackupDirectory";
            this.tbBackupDirectory.Size = new System.Drawing.Size(683, 39);
            this.tbBackupDirectory.TabIndex = 3;
            // 
            // btCreateBackup
            // 
            this.btCreateBackup.Location = new System.Drawing.Point(507, 299);
            this.btCreateBackup.Name = "btCreateBackup";
            this.btCreateBackup.Size = new System.Drawing.Size(206, 66);
            this.btCreateBackup.TabIndex = 4;
            this.btCreateBackup.Text = "Create Backup";
            this.btCreateBackup.UseVisualStyleBackColor = true;
            this.btCreateBackup.Click += new System.EventHandler(this.btCreateBackup_Click);
            // 
            // btOpenBackupFolder
            // 
            this.btOpenBackupFolder.Location = new System.Drawing.Point(731, 210);
            this.btOpenBackupFolder.Name = "btOpenBackupFolder";
            this.btOpenBackupFolder.Size = new System.Drawing.Size(85, 53);
            this.btOpenBackupFolder.TabIndex = 5;
            this.btOpenBackupFolder.Text = "Open";
            this.btOpenBackupFolder.UseVisualStyleBackColor = true;
            this.btOpenBackupFolder.Click += new System.EventHandler(this.btOpenBackupFolder_Click);
            // 
            // btOpenSourceFolder
            // 
            this.btOpenSourceFolder.Location = new System.Drawing.Point(731, 76);
            this.btOpenSourceFolder.Name = "btOpenSourceFolder";
            this.btOpenSourceFolder.Size = new System.Drawing.Size(85, 53);
            this.btOpenSourceFolder.TabIndex = 6;
            this.btOpenSourceFolder.Text = "Open";
            this.btOpenSourceFolder.UseVisualStyleBackColor = true;
            this.btOpenSourceFolder.Click += new System.EventHandler(this.btOpenSourceFolder_Click);
            // 
            // cbCopySubdirectories
            // 
            this.cbCopySubdirectories.AutoSize = true;
            this.cbCopySubdirectories.Location = new System.Drawing.Point(30, 299);
            this.cbCopySubdirectories.Name = "cbCopySubdirectories";
            this.cbCopySubdirectories.Size = new System.Drawing.Size(257, 36);
            this.cbCopySubdirectories.TabIndex = 7;
            this.cbCopySubdirectories.Text = "Copy subdirectories";
            this.cbCopySubdirectories.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 386);
            this.Controls.Add(this.cbCopySubdirectories);
            this.Controls.Add(this.btOpenSourceFolder);
            this.Controls.Add(this.btOpenBackupFolder);
            this.Controls.Add(this.btCreateBackup);
            this.Controls.Add(this.tbBackupDirectory);
            this.Controls.Add(this.lbBackupDirectory);
            this.Controls.Add(this.tbSourceDirectory);
            this.Controls.Add(this.lbSourceDirectory);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbSourceDirectory;
        private TextBox tbSourceDirectory;
        private Label lbBackupDirectory;
        private TextBox tbBackupDirectory;
        private Button btCreateBackup;
        private Button btOpenBackupFolder;
        private Button btOpenSourceFolder;
        private CheckBox cbCopySubdirectories;
    }
}