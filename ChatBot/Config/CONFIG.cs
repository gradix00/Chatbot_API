using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalla_chatbot.ChatBot.Config
{
    public static class CONFIG
    {
        public static string DataFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\kalla_chatbot\\";
        public const string UserData = "user_data.json";
        public const string Logs = "logs.txt";
        public const string PhraseDefinitions = "phrase_definitions.txt";
        public const string UnknownPhrasesFile = "unknow_phrases.txt";
        public const string HappyMFile = "words_happy.txt";
        public const string SadMFile = "words_sad.txt";
        public const string AngryMFile = "words_angry.txt";
        public const string ExcitedMFile = "words_excited.txt";
        public const string RelaxedMFile = "words_relaxed.txt";
        public const string ConfusedMFile = "words_confused.txt";
        public const string TiredMFile = "words_tired.txt";
        public const string BoredMFile = "words_bored.txt";
        public const string User_ADMIN = "Adrian";
    }
}
