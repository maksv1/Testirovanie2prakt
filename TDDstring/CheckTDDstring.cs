using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDstring
{
    public class CheckTDDstring
    {
        public string FindShortestWord(string text)
        {
            string[] words = text.Split(' ');
            string shortest = words[0];
            foreach (string word in words)
            {
                if (word.Length < shortest.Length)
                {
                    shortest = word;
                }
            }
            return shortest;
        }

        public int CountWords(string input)
        {
            return input.Split(' ').Length;
        }

        public int CountCharacters(string input)
        {
            return input.Length;
        }

        public char FindNinthCharacter(string input)
        {
            return input[8];
        }

        public int CountDigits(string input)
        {
            int count = 0;
            foreach (char c in input)
            {
                if (char.IsDigit(c))
                {
                    count++;
                }
            }
            return count;
        }

        public int FindLongestDigitSequence(string input)
        {
            int maxLength = 0;
            int currentLength = 0;
            foreach (char c in input)
            {
                if (char.IsDigit(c))
                {
                    currentLength++;
                    if (currentLength > maxLength)
                    {
                        maxLength = currentLength;
                    }
                }
                else
                {
                    currentLength = 0;
                }
            }
            return maxLength;
        }

        public int CountAm(string input)
        {
            int count = 0;
            int index = 0;
            while ((index = input.IndexOf("ам", index)) != -1)
            {
                count++;
                index += 2; // Длина "ам"
            }
            return count;
        }
    }
}
