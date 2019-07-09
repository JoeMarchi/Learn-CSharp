using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_structure_and_algorithm.demo1;

namespace Data_structure_and_algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            //004 Array destination add 
            int[] arr = new int[3];
            arr[0] = 99;
            arr[1] = 98;
            arr[2] = 97;
            int dst = 8;
            int[] newarr = new int[4];
            for (int i = 0; i < arr.Length; i++)
            {
                newarr[i] = arr[i];
            }
            newarr[arr.Length] = dst;
            arr = newarr;
            foreach (int j in arr)
            {
                Console.WriteLine(j);
            }
            //005 Array destination delete
            int dst1 = 1;
            int[] newarr1 = new int[3];
            for (int i = 0; i < newarr1.Length; i++)
            {
                if (i < dst1)
                {
                    newarr1[i] = arr[i];
                }
                else
                {
                    newarr1[i] = arr[i + 1];
                }

            }
            arr = newarr1;
            foreach (int j in arr)
            {
                Console.WriteLine(j);
            }
            //006 Array of objact-oriented
            MyArray myArray = new MyArray();
            myArray.Add(1);
            myArray.Add(2);
            myArray.Add(3);
            myArray.Add(48);
            myArray.Add(58);
            myArray.Insert(2, 8);
            myArray.Show();

        }
    }
}
