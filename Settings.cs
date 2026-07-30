using System;
using System.IO;

namespace RDPLauncher
{
    public class Settings
    {
        private readonly string fileName;

        public int LastProfile { get; set; } = 0;

        public Settings()
        {
            fileName = Path.Combine(Application.StartupPath, "settings.ini");
        }

        public void Load()
        {
            if (!File.Exists(fileName))
                return;

            foreach (var line in File.ReadAllLines(fileName))
            {
                if (line.StartsWith("LastProfile="))
                {
                    int.TryParse(line.Substring(12), out int index);
                    LastProfile = index;
                }
            }
        }

        public void Save()
        {
            File.WriteAllText(fileName,
$@"[General]
LastProfile={LastProfile}");
        }
    }
}