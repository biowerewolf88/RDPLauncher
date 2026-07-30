using System;
using System.IO;

namespace RDPLauncher
{
    public class IniReader
    {
        public static AppConfig Load(string fileName)
        {
            var config = new AppConfig();

            if (!File.Exists(fileName))
                throw new FileNotFoundException(fileName);

            string section = "";

            foreach (var line in File.ReadAllLines(fileName))
            {
                var s = line.Trim();

                if (string.IsNullOrWhiteSpace(s))
                    continue;

                if (s.StartsWith(";"))
                    continue;

                if (s.StartsWith("[") && s.EndsWith("]"))
                {
                    section = s[1..^1];
                    continue;
                }

                var parts = s.Split('=', 2);

                if (parts.Length != 2)
                    continue;

                var key = parts[0].Trim();
                var value = parts[1].Trim();

                switch (section)
                {
                    case "Servers":

                        switch (key)
                        {
                            case "MainIP":
                                config.Servers.MainIP = value;
                                break;

                            case "MainPort":
                                config.Servers.MainPort = int.Parse(value);
                                break;

                            case "BackupIP":
                                config.Servers.BackupIP = value;
                                break;

                            case "BackupPort":
                                config.Servers.BackupPort = int.Parse(value);
                                break;
                        }

                        break;
                    case "Options":

                        switch (key)
                        {
                            case "CloseAfterLaunch":
                                config.Options.CloseAfterLaunch = value.ToLower() == "true";
                                break;
                        }

                        break;

                    case "Profiles":

                        var rdp = value.Split('|');

                        config.Profiles.Add(new ProfileConfig
                        {
                            Name = key,
                            MainRdp = rdp[0],
                            BackupRdp = rdp[1]
                        });

                        break;
                }
            }

            return config;
        }
    }
}