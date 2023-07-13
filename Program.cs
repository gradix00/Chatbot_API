using kalla_chatbot.ChatBot.AnalyzerMood;
using kalla_chatbot.ChatBot.Analyzers;
using kalla_chatbot.ChatBot.Config;
using kalla_chatbot.ChatBot.DataProvider;
using kalla_chatbot.ChatBot.Enums;
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
                string? input = Console.ReadLine();

                IAnalyzer analyzer = new MoodAnalyzer();
                string res = analyzer.Analyze(input);

                Console.Write("\nKalla: ");
                if(res == UserMood.unknown.ToString())
                    Console.WriteLine("Nie rozumiem kontekstu, jestem jeszcze rozwijaną sztuczną inteligencją\nRejestruje wszystko co piszesz do plików, wiec nie martw sie");
                analyzer.SaveAnalysis();
                LogsManager log = new();
                log.SaveLog($"User write '{input}'");
            }
        }
    }
}