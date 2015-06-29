using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    /// <summary>
    /// Develop a program to find out what the starting number between 1 and 1 million that 
    /// produces the greatest sequence using the Collatz conjecture.
    ///     
    /// n -> n/2 (odd)
    /// n -> 3n + 1 (even)
    /// </summary>
    public class Collatz
    {
        private int _count = 0;
        private int[] _tree; // vector representing the binary tree


        /// <summary>
        /// Gets origin number that generates the greatest sequence using the Collatz conjecture
        /// </summary>
        public int GetGreatestSequenceOrigin(int number)
        {
            int result = 0;
            int mostSequence = 0;
            int nrMostSequence = 1;

            number++;
            _tree = new int[number];

            //ranges from 1 to the limit
            for (int i = 1; i < number; i++)
            {
                CreatesSheets(i);
            }

            //identifies which branch has more leaves
            for (int i = 1; i < number; i++)
            {
                if (_tree[i] > mostSequence)
                {
                    mostSequence = _tree[i];
                    nrMostSequence = i;
                }
            }
            return mostSequence;
        }


        /// <summary>
        /// Gets origin number that generates the greatest sequence using the Collatz conjecture
        /// </summary>
        /// <returns>origin between 1 and 1.000.000</returns>
        public void CreatesSheets(int number)
        {
            int nrBranch = 1;
            int tmp = 0;
            int ret = 0;
            ulong result = 0;

            ulong tmpCalcNumber = Convert.ToUInt64(number);

            for (int i = 0; result != 1; )
            {
                if (result <= Convert.ToUInt64(number))
                {
                    ret = ReadBranch(Convert.ToInt32(result));
                }

                if (ret > 0)
                {
                    nrBranch = nrBranch + ret;
                    result = 1;
                }
                else
                {
                    if (tmpCalcNumber % 2 == 0)
                    {
                        tmpCalcNumber = tmpCalcNumber / 2;
                    }
                    else
                    {
                        tmpCalcNumber = 3 * tmpCalcNumber + 1;
                    }
                    result = tmpCalcNumber;
                    nrBranch++;
                }
            }
            _tree[number] = nrBranch;
        }


        /// <summary>
        /// method to read all the branches of the tree to identiifcar if there is any for the number of parameter
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public int ReadBranch(int number)
        {
            int ret = 0;
            if (number > 0 && _tree.Length > 0 && (_tree.Length - 1) >= number)
            {
                if (_tree[number] > 0)
                {
                    ret = number;
                    ret = _tree[number] - 1;
                }
            }
            return ret;
        }
    }
}
