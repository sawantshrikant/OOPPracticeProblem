using System;
using System.Linq;

namespace OOPPracticeProblem
{
    public class WordString
    {
        public string ReverseWords(string input)
        {
            string[] words = input.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                char[] wordChars = words[i].ToCharArray();
                Array.Reverse(wordChars);
                words[i] = new string(wordChars);
            }

            return string.Join(" ", words);
        }
    }
}
