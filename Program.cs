using kalla_chatbot.ChatBot.AnalyzerMood;
using kalla_chatbot.ChatBot.Analyzers;
using kalla_chatbot.ChatBot.Config;
using kalla_chatbot.ChatBot.DataProvider;
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
                Console.Write("Entry: ");
                string input = Console.ReadLine();

                IAnalyzer analyzer = new MoodAnalyzer();  
                Console.WriteLine(analyzer.Analyze(input));
            }
        }
    }
}