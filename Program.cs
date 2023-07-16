using kalla_chatbot.ChatBot.AnalyzerMood;
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

namespace kalla_chatbot
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Configuration.SetDefaultConfiguration();
            while (true)
            {
                Console.Write("\nEntry: ");
                string? input = Console.ReadLine().ToLower();
                int s = TextProvider.CompareTextsAndGetNumberOfRelWords("siema, co tam slychac ziomek złomek?", "siema, co tam złomek?");
                Console.WriteLine(s);

                LogsManager log = new();
                log.SaveLog($"User write '{input}'");
            }
        }
    }
}