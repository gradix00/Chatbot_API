using kalla_chatbot.ChatBot.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalla_chatbot.ChatBot.Analyzers
{
    public interface IAnalyzer
    {
        public string Analyze(string text);
        public void SaveAnalysis();
    }
}
