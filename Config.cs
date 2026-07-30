using System.Collections.Generic;

namespace RDPLauncher
{
    public class ServerConfig
    {
        public string MainIP { get; set; } = "";
        public int MainPort { get; set; }

        public string BackupIP { get; set; } = "";
        public int BackupPort { get; set; }
    }

    public class ProfileConfig
    {
        public string Name { get; set; } = "";
        public string MainRdp { get; set; } = "";
        public string BackupRdp { get; set; } = "";
    }

    public class OptionsConfig
    {
        public bool CloseAfterLaunch { get; set; }
    }

    public class AppConfig
    {
        public ServerConfig Servers { get; set; } = new();
        public List<ProfileConfig> Profiles { get; set; } = new();

        public OptionsConfig Options { get; set; } = new();
    }
}