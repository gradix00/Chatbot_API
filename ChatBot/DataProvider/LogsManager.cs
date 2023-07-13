using kalla_chatbot.ChatBot.Config;
using kalla_chatbot.ChatBot.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalla_chatbot.ChatBot.DataProvider
{
    public class LogsManager : DataWriter
    {
        private string logFile = CONFIG.DataFolderPath + CONFIG.Logs;

        public void SaveLog(string data, LogType type = LogType.info)
        {
            AppendDataToFile(logFile, $"[{DateTime.Now}] {type.ToString().ToUpper()}: {data}\n");
        }
    }
}
