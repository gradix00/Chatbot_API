using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalla_chatbot.ChatBot.DataProvider
{
    public interface IDataFileReader
    {
        public string FolderPath { get; set; }

        public string LoadData(string fileName);
        public string[] LoadFileToArray(string fileName);
        public string LoadDataByText(string fileName, string text);
        public int CountPhraseInContext(string phrase, string context);
        public bool SearchTextInContext(string text, string context);
    }
}
