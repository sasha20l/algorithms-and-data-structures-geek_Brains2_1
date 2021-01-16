using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifficultyCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static int StrangeSum(int[] inputArray)
        {
            int sum = 0; // O(1)
            for (int i = 0; i < inputArray.Length; i++)// i * j * k
            {
                for (int j = 0; j < inputArray.Length; j++) // j * k
                {
                    for (int k = 0; k < inputArray.Length; k++) //k
                    {
                        int y = 0; // O(1)

                        if (j != 0)
                        {
                            y = k / j;
                        }

                        sum += inputArray[i] + i + k + j + y;
                    }
                }
            }

            return sum; // O(1)
        }
    }
}
