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
                if (index == (text.Length - 1) || !char.IsLetter(text[index]))
                {
                    if (index == text.Length - 1 && (text[index] >= 'a' && text[index] <= 'z')
                        && (text[index] >= 'A' && text[index] <= 'Z'))
                        word += text[index];

                    words.Add(word);
                    word = string.Empty;
                    continue;
                }
                else
                {
                    word += text[index];
                }
            }
            return words.ToArray();
        }

        public static string[] RemoveElementFromArray(string element, string[] array)
        {
            List<string> result = new List<string>();
            for(int index = 0; index < array.Length; index++)
            {
                if (element == array[index])
                    continue;
                else
                    result.Add(array[index]);
            }
            return result.ToArray();
        }
    }
}
