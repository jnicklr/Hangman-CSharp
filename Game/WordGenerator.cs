using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman.Game
{
    public static class WordGenerator
    {
        public static List<char> GetUniqueChars(string word)
        {
            List<char> wordUniqueLetters = new List<char>();

            for (int i = 0; i < word.Length; i++)
            {
                if (!(wordUniqueLetters.Any(letter => letter == word[i])))
                {
                    wordUniqueLetters.Add(Convert.ToChar(word[i]));
                }
            }

            return wordUniqueLetters; 
        }

        public static char[] GenerateBlanks(int wordLength)
        {
            char[] blanks = new char[wordLength];

            for (int i = 0; i < wordLength; i++)
            {
                blanks[i] = '*';
            }

            return blanks;
        }

    }
}
