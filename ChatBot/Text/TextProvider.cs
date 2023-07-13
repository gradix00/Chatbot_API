using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalla_chatbot.ChatBot.Text
{
    public static class TextProvider
    {
        public static string[] GetWordsFromContext(string text)
        {
            List<string> words = new List<string>();
            string word = string.Empty;

            for (int index = 0; index < text.Length; index++)
            {
                if (text[index] == ' ' || 
                    text[index] == ',' || 
                    text[index] == '.' || 
                    text[index] == ';' || 
                    text[index] == ':' || 
                    text[index] == '!' || 
                    text[index] == '?' || 
                    index == (text.Length - 1))
                {
                    words.Add(word);
                    word = string.Empty;
                    continue;
                }
                else
                    word += text[index];             
            }
            return words.ToArray();
        }
    }
}
