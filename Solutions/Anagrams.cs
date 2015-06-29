using System.Collections.Generic;

namespace Solutions
{
    /// <summary>
    /// Write a program that manages all potential anagrams of a string
    /// </summary>
    public class Anagrams
    {
        /// <summary>        
        /// Gets all anagrams for a given input string
        /// </summary>
        /// <param name="input">input string</param>
        /// <returns>anagrams</returns>
        public IList<string> GetAnagrams(string input)
        {
            var anagram = input;

            var anagrams = new List<string>();

            for (var i = 0; i < anagram.Length; i++)
            {
                var index = anagram.Length - 1;

                var original = anagram;

                while (index - 1 > 0)
                {
                    anagrams.Add(anagram);

                    anagram = this.Swap(anagram, index, index - 1);

                    if (index - 1 == 1 && anagram != original)
                    {
                        index = anagram.Length - 1;
                    }
                    else
                    {
                        index--;
                    }
                }

                anagram = anagram.Substring(1) + anagram[0];
            }

            return anagrams;
        }

        /// <summary>
        /// Swap two char at given string input
        /// </summary>
        /// <param name="input">string input</param>
        /// <param name="pos1">position 1</param>
        /// <param name="pos2">position 2</param>
        /// <returns>swapped string</returns>
        private string Swap(string input, int pos1, int pos2)
        {
            var val1 = input[pos1];
            var val2 = input[pos2];

            var array = input.ToCharArray();

            array[pos1] = val2;
            array[pos2] = val1;

            var swapped = string.Empty;

            for (var i = 0; i < array.Length; i++)
            {
                swapped += array[i];
            }

            return swapped;
        }

        /// <summary>        
        /// Gets the factorial value for a given integer value
        /// </summary>
        /// <param name="input">número inteiro</param>
        /// <returns>fatorial</returns>
        private int GetFactorial(int input)
        {
            var x = 1;

            while (input > 0)
            {
                x = x * input;

                input = input - 1;
            }

            return x;
        }

        /// <summary>
        /// Get the max number of anagrams for a given input string without repeated anagrams
        /// </summary>
        /// <param name="input">input string</param>
        /// <returns>number of anagrams</returns>
        public int GetMaxAnagrams(string input)
        {
            return this.GetFactorial(input.Length);
        }
    }
}
