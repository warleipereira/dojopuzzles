using System.Collections.Generic;

namespace Solutions
{
    /// <summary>
    /// Write a program that manages all potential anagrams of a string
    /// 
    /// IN PROGRESS...
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
            var anagrams = new List<string>() { input };
            
            this.GetAnagramsRecursively(input, anagrams);            

            return anagrams;
        }

        private void GetAnagramsRecursively(string input, IList<string> anagrams)
        {
            if (anagrams.Count == 0) return;

            var first = anagrams[0];

            var anagram = input;

            for (var i = 0; i < anagram.Length - 1; i++)
            {
                anagram = this.Swap(anagram, i, i + 1);

                if (anagram != first)
                {
                    anagrams.Add(anagram);
                }                
            }
            
            if (anagram != first)
            {
                this.GetAnagramsRecursively(anagram, anagrams);
            }
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
        public int GetFactorial(int input)
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
        /// Checks if all elements of the sequence are distinct
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public bool IsAllDistinct(IList<string> input)
        {            
            for (var i = 0; i < input.Count; i++)
            {
                for (var j = 0; i < input.Count; j++)
                {
                    if (input[i] == input[j]) return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Get the max number of anagrams for a given input string without repeated anagrams
        /// </summary>
        /// <param name="input">input string</param>
        /// <returns>number of anagrams</returns>
        public int GetMaxAnagrams(string input)
        {
            return 0;
        }
    }
}
