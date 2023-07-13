using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalla_chatbot.ChatBot.DataProvider
{
    public interface IDataWriter
    {
        public string FolderPath { get; set; }

        public void SaveData(string fileName, string data);
        public void AppendDataToFile(string fileName, string data);
    }
}
