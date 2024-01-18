using Newtonsoft.Json;
using SHGui;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SHRework.ToolClient {
    public class ConfigManager {
        public ConfigManager() {
            ConfigPath = Path.Combine(Directory.GetCurrentDirectory(), "config.json");
        }

        public Config Config = null;
        public string ConfigPath { get; set; }

        public bool LoadConfig() {
            try {
                string text = File.ReadAllText(ConfigPath);
                Config = JsonConvert.DeserializeObject<Config>(text);
                return true;
            } catch { Config = new Config(); SaveConfig(); throw; return false; }
        }
        public bool SaveConfig() {
            try {
                string text = JsonConvert.SerializeObject(Config);
                File.WriteAllText(ConfigPath, text);
                return true;
            } catch { throw; return false; }
        }
    }

    public class Config {
        public Dictionary<string, Credentials> Profiles { get; set; }

    }
}
