using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ProjectPractice
{
    public static class GlobalCongif
    {
        public static Config? Config;

        public static string Ip => Config.ip;
        public static string Port => Config.port;

        static GlobalCongif()
        {
            using (StreamReader r = new StreamReader("config.json"))
            {
                string json = r.ReadToEnd();
                var cfg = JsonSerializer.Deserialize<Config>(json);
                if (cfg == null)
                    throw new Exception("Miss config file");
                Config = cfg;
            }
        }
    }

    public class Config
    {
        public string ip { get; set; }
        public string port { get; set; }

        public Config()
        {
            
        }
    }
}
