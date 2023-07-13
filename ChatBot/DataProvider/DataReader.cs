using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace kalla_chatbot.ChatBot.DataProvider
{
    public class DataReader : IDataFileReader
    {
        private string _folderPath = string.Empty;
        public string FolderPath { get => _folderPath; set => _folderPath = value; }

        public string LoadDataByText(string fileName, string text)
        {
            throw new NotImplementedException();
        }

        public string[] LoadFileToArray(string fileName)
        {
            return File.ReadAllLines(fileName, Encoding.UTF8);
        }

        public int CountPhraseInContext(string phrase, string context)
        {
            int result = 0;
            for (int x = 0; x < context.Length; x++)
            {
                string line = string.Empty;
                for (int i = x; i < context.Length; i++)
                {
                    line += context[i];
                    if (line == phrase)
                        result++;
                }
            }
            return result;
        }

        public bool SearchTextInContext(string text, string context)
        {
            for(int x = 0; x < context.Length; x++)
            {
                string line = string.Empty;
                for(int i = x; i < context.Length; i++)
                {
                    line += context[i];

                    if (line == text)
                        return true;
                }
            }
            return false;
        }

        public string LoadData(string fileName)
        {
            return File.ReadAllText(fileName, Encoding.UTF8);
        }
    }
}
