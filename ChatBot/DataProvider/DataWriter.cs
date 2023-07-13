using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalla_chatbot.ChatBot.DataProvider
{
    public class DataWriter : IDataWriter
    {
        public string FolderPath { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void AppendDataToFile(string fileName, string data) => File.AppendAllText(fileName, data);

        public void SaveData(string fileName, string data) => File.WriteAllText(fileName, data, Encoding.UTF8);
    }
}
