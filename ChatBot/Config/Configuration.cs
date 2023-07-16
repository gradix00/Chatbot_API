using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalla_chatbot.ChatBot.Config
{
    public static class Configuration
    {
        public static UserConfig UserConfig { get; set; }

        public static void SetDefaultConfiguration()
        {
            if (!Directory.Exists(CONFIG.DataFolderPath))
            {
                Directory.CreateDirectory(CONFIG.DataFolderPath);
            }

            if (!File.Exists(CONFIG.DataFolderPath + CONFIG.UserData))
            {
                UserConfig conf = new UserConfig()
                {
                    FirstName = "Adrian",
                    LastName = "Puchalski",
                    Age = 20,
                    Email = "adiomigames@gmail.com",
                    Country = "Poland"
                };

                string json = JsonConvert.SerializeObject(conf, Formatting.Indented);
                File.WriteAllText(CONFIG.DataFolderPath + CONFIG.UserData, json);
            }

            if (!File.Exists(CONFIG.DataFolderPath + CONFIG.Logs))
            {
                File.WriteAllText(CONFIG.DataFolderPath + CONFIG.Logs, null);
            }

            if (!File.Exists(CONFIG.DataFolderPath + CONFIG.MeaningText))
            {
                File.WriteAllText(CONFIG.DataFolderPath + CONFIG.MeaningText, null);
            }

            if (!File.Exists(CONFIG.DataFolderPath + CONFIG.PhraseDefinitions))
            {
                File.WriteAllText(CONFIG.DataFolderPath + CONFIG.PhraseDefinitions, null);
            }

            if (!File.Exists(CONFIG.DataFolderPath + CONFIG.UnknownPhrasesFile))
            {
                File.WriteAllText(CONFIG.DataFolderPath + CONFIG.UnknownPhrasesFile, null);
            }

            if (!File.Exists(CONFIG.DataFolderPath + CONFIG.HappyMFile))
            {
                File.WriteAllText(CONFIG.DataFolderPath + CONFIG.HappyMFile, null);
            }

            if (!File.Exists(CONFIG.DataFolderPath + CONFIG.SadMFile))
            {
                File.WriteAllText(CONFIG.DataFolderPath + CONFIG.SadMFile, null);
            }

            if (!File.Exists(CONFIG.DataFolderPath + CONFIG.AngryMFile))
            {
                File.WriteAllText(CONFIG.DataFolderPath + CONFIG.AngryMFile, null);
            }

            if (!File.Exists(CONFIG.DataFolderPath + CONFIG.ExcitedMFile))
            {
                File.WriteAllText(CONFIG.DataFolderPath + CONFIG.ExcitedMFile, null);
            }

            if (!File.Exists(CONFIG.DataFolderPath + CONFIG.RelaxedMFile))
            {
                File.WriteAllText(CONFIG.DataFolderPath + CONFIG.RelaxedMFile, null);
            }

            if (!File.Exists(CONFIG.DataFolderPath + CONFIG.ConfusedMFile))
            {
                File.WriteAllText(CONFIG.DataFolderPath + CONFIG.ConfusedMFile, null);
            }

            if (!File.Exists(CONFIG.DataFolderPath + CONFIG.TiredMFile))
            {
                File.WriteAllText(CONFIG.DataFolderPath + CONFIG.TiredMFile, null);
            }

            if (!File.Exists(CONFIG.DataFolderPath + CONFIG.BoredMFile))
            {
                File.WriteAllText(CONFIG.DataFolderPath + CONFIG.BoredMFile, null);
            }
        }
    }
}
