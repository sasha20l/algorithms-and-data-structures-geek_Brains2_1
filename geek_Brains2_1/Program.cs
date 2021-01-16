using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geek_Brains2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            PrimeOrNotPrimeNumber();
            Console.ReadLine();
        }

        static void PrimeOrNotPrimeNumber()
        {
            int nunber = int.Parse(Console.ReadLine());

            int d = 0;
            int i = 2;

            while (i < nunber)
            {
                if (nunber % i == 0) d++;
                i++;
            }

            if (d == 0)
            {
                Console.WriteLine("Простое");
            }
            else
            {
                Console.WriteLine("Не простое");
            }

        }
    }
}
