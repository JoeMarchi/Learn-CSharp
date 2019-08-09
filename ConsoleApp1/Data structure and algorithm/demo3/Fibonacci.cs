using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_structure_and_algorithm.demo3
{
    class Fibonacci
    { 
        public static int FibonacciTarget(int i)
        {
            if (i == 1 || i == 2)
            {
                return 1;
            }
            else
            {
                return FibonacciTarget(i - 1) + FibonacciTarget(i - 2);
            }
        }
        public static void Calculation(int i,int j)
        {
            if (i < 10000)
            {
                if (j < 2)
                {
                    Console.Write($"{i},");
                }
                Console.Write($"{j},");
                int k;
                k = i + j;
                i = j;
                j = k;
                Calculation(i, j);
            }
        }
    }
}
