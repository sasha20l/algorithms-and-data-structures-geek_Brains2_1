using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            //fibonacci2(int.Parse(Console.ReadLine())); // Не рекульсионный метод.


            Console.WriteLine(fibonacci1(int.Parse(Console.ReadLine())));// Рекульсионный метод.
            Console.ReadLine();


        }

        static int fibonacci1(int n)
        {
            if (n == 0) return 0;
            else if (n == 1 || n == 2) return 1;
            return fibonacci1(n - 1) + fibonacci1(n - 2);
        }

        static void fibonacci2(int n)
        {
            int nums = n;
            int[] array = new int[nums];
            for (int i = 0; i < nums; i++)
            {
                if (i == 0 || i == 1)
                {
                    array[i] = i;
                    continue;
                }
                array[i] = array[i - 1] + array[i - 2];
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            Console.ReadLine();

        }

    }
}