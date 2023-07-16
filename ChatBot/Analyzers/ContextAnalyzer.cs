using kalla_chatbot.ChatBot.Config;
using kalla_chatbot.ChatBot.DataProvider;
using kalla_chatbot.ChatBot.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalla_chatbot.ChatBot.Analyzers
{
    public class ContextAnalyzer : IAnalyzer
    {
        private string meaingCFile = CONFIG.DataFolderPath + CONFIG.MeaningText;

        public string Analyze(string text)
        {
            string[] phrases = TextProvider.GetWordsFromContext(text);
            IDataReader reader = new DataReader();
            string[] meanings = reader.LoadFileToArray(meaingCFile);
            string result = string.Empty;

            if(meanings.Length > 0 )
            {
                int relatedPhrases = 0;

                foreach(string line in meanings)
                {
                    if(TextProvider.CompareTextsAndGetNumberOfRelWords(text, line) > relatedPhrases)
                    { relatedPhrases++; }
                }
            }
            else
            {
                //save meaning on start
                IDataWriter writer = new DataWriter();
                writer.SaveData(meaingCFile, text);
                result = CONFIG.startQuestion;
            }
            return result;
        }

        public void SaveAnalysis()
        {
            throw new NotImplementedException();
        }
    }
}
