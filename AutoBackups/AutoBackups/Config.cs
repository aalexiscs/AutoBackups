namespace AutoBackups
{
    public class Config
    {
        public Config()
        {
            SourceDirectory = string.Empty;
            BackupDirectory = string.Empty;
        }

        public string SourceDirectory { get; set; }
        public string BackupDirectory { get; set; }
    }
}