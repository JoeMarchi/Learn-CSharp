using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_structure_and_algorithm.demo1;
using Data_structure_and_algorithm.demo2;


namespace Data_structure_and_algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            //004 Array destination add 
            //int[] arr = new int[3];
            //arr[0] = 99;
            //arr[1] = 98;
            //arr[2] = 97;
            //int dst = 8;
            //int[] newarr = new int[4];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    newarr[i] = arr[i];
            //}
            //newarr[arr.Length] = dst;
            //arr = newarr;
            //foreach (int j in arr)
            //{
            //    //Console.WriteLine(j);
            //}
            ////005 Array destination delete
            //int dst1 = 1;
            //int[] newarr1 = new int[3];
            //for (int i = 0; i < newarr1.Length; i++)
            //{
            //    if (i < dst1)
            //    {
            //        newarr1[i] = arr[i];
            //    }
            //    else
            //    {
            //        newarr1[i] = arr[i + 1];
            //    }

            //}
            //arr = newarr1;
            //foreach (int j in arr)
            //{
            //    //Console.WriteLine(j);
            //}
            ////006 Array of objact-oriented
            //MyArray myArray = new MyArray();
            //try
            //{
            //    myArray.Add(1);
            //    myArray.Add(2);
            //    myArray.Add(3);
            //    myArray.Add(4);
            //    myArray.Add(5);
            //    myArray.Show();
            //    myArray.Insert(-1, 0);
            //    myArray.Get(-1);
            //}
            //catch (IndexOutOfRangeException e)
            //{
            //    //throw;
            //    //throw e;
            //    Console.WriteLine("ERROR");
            //}
            //finally
            //{
            //    myArray.BinarySearch(4);
            //}

            //myArray.Show();
            //MyArray myArray2 = new MyArray();
            //009 Stack of objact-oriented
            //MyStack myStack = new MyStack();
            //myStack.Push(1);
            //myStack.Push(2);
            //myStack.Push(3);
            //myStack.Push(4);
            //Console.WriteLine(myStack.Pop());
            //Console.WriteLine(myStack.Pop());
            //Console.WriteLine(myStack.Pop());
            //Console.WriteLine(myStack.Pop());
            ////myStack.Peek();
            ////myStack.Show();
            //Console.WriteLine(myStack.IsEmpty());

            //010 Queue of objact-oriented
            MyQueue myQueue = new MyQueue();
            myQueue.Put(1);
            myQueue.Put(2);
            myQueue.Put(3);
            myQueue.Put(4);
            myQueue.Put(5);
            myQueue.Pull();
            myQueue.Pull();
            myQueue.Pull();
            myQueue.Show();
        }
    }
}
