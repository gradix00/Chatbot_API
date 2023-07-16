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

            //filtering phrases when they are an empty string
            if (words.Count > 0)
            {
                var tmp = new List<string>();
                foreach (var el in words)
                {
                    if (el.Length > 0)
                        tmp.Add(el);
                }
                words = tmp;
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

        public static bool ContainWord(string word, string[] arr)
        {
            foreach(string element in  arr)
            {
                if (element == word)
                    return true;
            }
            return false;
        }

        public static int CompareTextsAndGetNumberOfRelWords(string text1, string text2)
        {
            List<List<string>> list = new()
            {
                new (GetWordsFromContext(text1)),
                new (GetWordsFromContext(text2))
            };
            int result = 0;

            //assigning an array with more elements and getting the id of the array
            string[]? array = null;
            Func<int> idList = () =>
            {
                int id = list[0].Count > list[1].Count ? 0 : 1;
                array = list[id].ToArray();
                return id == 1 ? 0 : 1;
            };
            int id = idList();

            for (int index = 0; index < array.Length; index++)
            {
                if (ContainWord(array[index], list[id].ToArray()))
                    result++;
            }

            return result;
        }
    }
}
