using System;
using System.IO;

namespace NoteReminder.Common
{
    public sealed class ConfigurationManager
    {
        private static readonly Lazy<ConfigurationManager> _instance =
            new Lazy<ConfigurationManager>(() => new ConfigurationManager());

        public string DataStoragePath { get; private set; }
        public string AppTheme { get; set; }

        private ConfigurationManager()
        {
            AppTheme = "Default";
            string folder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "NoteReminder");
            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }
            DataStoragePath = Path.Combine(folder, "notes_data.json");
        }

        public static ConfigurationManager Instance => _instance.Value;
    }
}