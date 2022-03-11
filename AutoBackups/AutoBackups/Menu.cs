using System.Diagnostics;

namespace AutoBackups
{
    public partial class Menu : Form
    {
        private string defaultSourceDirectory = @"C:\Users\aalex\Downloads\AutoBackups\Source\";
        private static string defaultBackupDirectory = @"C:\Users\aalex\Downloads\AutoBackups\Backups\";
        private const string appName = "AutoBackups";
        private const string defaultBackupsDirectory = @"C:\Users\aalex\Downloads\AutoBackups\Backups\";

        public Menu()
        {
            InitializeComponent();

            WindowCustomization();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            tbSourceDirectory.Text = defaultSourceDirectory;
            tbSourceDirectory.Enabled = false;

            tbBackupDirectory.Text = defaultBackupDirectory;
            tbBackupDirectory.Enabled = false;

            cbCopySubdirectories.Checked = true;
        }

        private void WindowCustomization()
        {
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.BackColor = SystemColors.Control;
        }

        private void btCreateBackup_Click(object sender, EventArgs e)
        {
            CreateBackup();
        }

        private void CreateBackup()
        {
            if(!ValidateFields())
            {
                MessageBox.Show(Messages.FILL_FIELDS, appName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string backupDirectory = GetUpdatedBackupDirectory(tbBackupDirectory.Text);
            bool result = DirectoryCopy(tbSourceDirectory.Text.Trim(), backupDirectory, cbCopySubdirectories.Checked);

            if(result)
            {
                MessageBox.Show(Messages.BACKUP_SUCCESS, appName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(Messages.BACKUP_FAILED, appName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private bool DirectoryCopy(string sourceDirectory, string backupDirectory, bool copySubdirectories)
        {
            bool allOk = false;

            try
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(sourceDirectory);

                if(!directoryInfo.Exists)
                {
                    MessageBox.Show(Messages.DIRECTORY_DOES_NOT_EXIST, appName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                DirectoryInfo[] directories = directoryInfo.GetDirectories();

                Directory.CreateDirectory(backupDirectory);

                FileInfo[] files = directoryInfo.GetFiles();

                foreach (FileInfo file in files)
                {
                    string tempPath = Path.Combine(backupDirectory, file.Name);
                    file.CopyTo(tempPath, true);
                }

                if(copySubdirectories)
                {
                    foreach (DirectoryInfo subdirectory in directories)
                    {
                        string tempPath = Path.Combine(backupDirectory, subdirectory.Name);

                        //
                        DirectoryCopy(subdirectory.FullName, tempPath, copySubdirectories);
                    }
                }

                allOk = true;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {

            }
            return allOk;
        }

        private static string GetUpdatedBackupDirectory(string backupDirectory) =>
            backupDirectory.Trim() + "Backup" + DateTime.Now.ToString("MM/dd/yyyy HH:mm")
            .Replace("/", "").Replace(":", "").Replace(" ", "");

        private bool ValidateFields() =>
            tbSourceDirectory.Text.Trim().Length > 0 && tbBackupDirectory.Text.Trim().Length > 0;

        private void btOpenBackupFolder_Click(object sender, EventArgs e)
        {
            if(!Directory.Exists(defaultBackupsDirectory))
            {
                MessageBox.Show(Messages.DIRECTORY_DOES_NOT_EXIST, appName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Process.Start("explorer.exe", defaultBackupsDirectory);
        }

        private void btOpenSourceFolder_Click(object sender, EventArgs e)
        {

            if (!Directory.Exists(defaultSourceDirectory))
            {
                MessageBox.Show(Messages.DIRECTORY_DOES_NOT_EXIST, appName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Process.Start("explorer.exe", defaultSourceDirectory);
        }
    }
}