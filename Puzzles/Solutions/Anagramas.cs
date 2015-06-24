using System.Collections.Generic;

namespace Solutions
{
    /// <summary>
    /// Escreva um programa que gere todos os anagramas potenciais de uma string.
    /// </summary>
    public class Anagramas
    {
        /// <summary>
        /// Obtem todos os anagramas potenciais da string de entrada
        /// </summary>
        /// <param name="input"></param>
        /// <returns>anagramas</returns>
        public IList<string> GetAnagramas(string input)
        {
            var anagramas = new List<string>();

            //SOLUÇÃO AKI

            return anagramas;
        }

        /// <summary>
        /// Obtem o fatorial do número inteiro de entrada
        /// </summary>
        /// <param name="input">número inteiro</param>
        /// <returns>fatorial</returns>
        public int GetFatorial(int input)
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
        /// Verifica se todos os elementos da coleção são diferentes
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
    }
}
