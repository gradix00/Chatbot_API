using kalla_chatbot.ChatBot.Analyzers;
using kalla_chatbot.ChatBot.Config;
using kalla_chatbot.ChatBot.DataProvider;
using kalla_chatbot.ChatBot.Enums;
using kalla_chatbot.ChatBot.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalla_chatbot.ChatBot.AnalyzerMood
{
    public class MoodAnalyzer : IAnalyzer
    {
        private string unknowPhrases = CONFIG.DataFolderPath + CONFIG.UnknownPhrasesFile;
        private string happyMFile = CONFIG.DataFolderPath + CONFIG.HappyMFile;
        private string sadMFile = CONFIG.DataFolderPath + CONFIG.SadMFile;
        private string angryMFile = CONFIG.DataFolderPath + CONFIG.AngryMFile;
        private string excitedMFile = CONFIG.DataFolderPath + CONFIG.ExcitedMFile;
        private string relaxedMFile = CONFIG.DataFolderPath + CONFIG.RelaxedMFile;
        private string confusedMFile = CONFIG.DataFolderPath + CONFIG.ConfusedMFile;
        private string tiredMFile = CONFIG.DataFolderPath + CONFIG.TiredMFile;
        private string boredMFile = CONFIG.DataFolderPath + CONFIG.BoredMFile;    

        public string Analyze(string text)
        {
            Console.WriteLine(TextProvider.GetWordsFromContext(text).Length);
            foreach (var s in TextProvider.GetWordsFromContext(text))
                Console.WriteLine(s);
            IDataFileReader reader = new DataReader();
            reader.FolderPath = CONFIG.DataFolderPath; //load folder ai from program config

            Dictionary<UserMood, int> dict = new Dictionary<UserMood, int>();

            try
            {
                //identification how many slow type 'happy'
                foreach (string word in TextProvider.GetWordsFromContext(text))
                {
                    int points = reader.CountPhraseInContext(word, reader.LoadData(happyMFile));
                    if (!dict.ContainsKey(UserMood.happy))
                        dict?.Add(UserMood.happy, points);
                    else
                        dict[UserMood.happy] += points;
                }

                //identification how many slow type 'sad'
                foreach (string word in TextProvider.GetWordsFromContext(text))
                {
                    int points = reader.CountPhraseInContext(word, reader.LoadData(sadMFile));
                    if (!dict.ContainsKey(UserMood.sad))
                        dict?.Add(UserMood.sad, points);
                    else
                        dict[UserMood.sad] += points;
                }

                //identification how many slow type 'angry'
                foreach (string word in TextProvider.GetWordsFromContext(text))
                {
                    int points = reader.CountPhraseInContext(word, reader.LoadData(angryMFile));
                    if (!dict.ContainsKey(UserMood.angry))
                        dict?.Add(UserMood.angry, points);
                    else
                        dict[UserMood.angry] += points;
                }

                //identification how many slow type 'excited'
                foreach (string word in TextProvider.GetWordsFromContext(text))
                {
                    int points = reader.CountPhraseInContext(word, reader.LoadData(excitedMFile));
                    if (!dict.ContainsKey(UserMood.excited))
                        dict?.Add(UserMood.excited, points);
                    else
                        dict[UserMood.excited] += points;
                }

                //identification how many slow type 'relaxed'
                foreach (string word in TextProvider.GetWordsFromContext(text))
                {
                    int points = reader.CountPhraseInContext(word, reader.LoadData(relaxedMFile));
                    if (!dict.ContainsKey(UserMood.relaxed))
                        dict?.Add(UserMood.relaxed, points);
                    else
                        dict[UserMood.relaxed] += points;
                }

                //identification how many slow type 'confused'
                foreach (string word in TextProvider.GetWordsFromContext(text))
                {
                    int points = reader.CountPhraseInContext(word, reader.LoadData(confusedMFile));
                    if (!dict.ContainsKey(UserMood.confused))
                        dict?.Add(UserMood.confused, points);
                    else
                        dict[UserMood.confused] += points;
                }

                //identification how many slow type 'tired'
                foreach (string word in TextProvider.GetWordsFromContext(text))
                {
                    int points = reader.CountPhraseInContext(word, reader.LoadData(tiredMFile));
                    if (!dict.ContainsKey(UserMood.tired))
                        dict?.Add(UserMood.tired, points);
                    else
                        dict[UserMood.tired] += points;
                }

                //identification how many slow type 'bored'
                foreach (string word in TextProvider.GetWordsFromContext(text))
                {
                    int points = reader.CountPhraseInContext(word, reader.LoadData(boredMFile));
                    if (!dict.ContainsKey(UserMood.bored))
                        dict?.Add(UserMood.bored, points);
                    else
                        dict[UserMood.bored] += points;
                }
            }
            catch(Exception ex)
            { 
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ResetColor();
            }

            UserMood result = new UserMood();
            int currentPoints = 0;
            foreach(var value in dict)
            {
                Console.WriteLine(value);
                if (value.Value > currentPoints)
                {
                    currentPoints = value.Value;
                    result = value.Key;
                }
            }
            return result.ToString();
        }
    }
}
