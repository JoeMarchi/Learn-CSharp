using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int x = 3;
            //int y = 4;
            //int z = 5;
            //int result = x *= y += z;
            //Console.WriteLine(result);
            
            //Program p = new Program();
            //Console.WriteLine(p.Hanoi(8)-1);

            //int x = 10;
            //Console.WriteLine(x.GetType());

            //do
            //{
            //    Console.WriteLine(x);
            //    x--;
            //}
            //while (x > 0);

            //var x = 3;
            //Console.WriteLine(x.GetType());

            //var y = new { name = "marchi", age = 26 };
            //Console.WriteLine(y.GetType().FullName);
            //Console.WriteLine(y.GetType());

            //Console.WriteLine("Helloworld");
            //Form form1 = new Form();
            //Form form2 = form1;
            //form1.Text = "test";
            //form2.Text = "test2";
            //form1.ShowDialog();
            //form2.ShowDialog();

            //for(int num=1; num < 10;num++){
            //    Console.WriteLine(num);
            //}

            //int[] array = new int[]{ 1,2,3,4,5};
            //Console.WriteLine(array[1]);

            //Form myForm = default(Form);
            //Console.WriteLine(myForm == null);
            unsafe
            {
                //Student stu;
                //Student* pStu = &stu;
                //pStu->score = 3;
                //Console.WriteLine(pStu->score);
                //Console.WriteLine(stu.score);
                //(*pStu).score = 4;
                //Console.WriteLine((*pStu).score);
                //int x = sizeof(Student);
                //Student stu;
                //stu.score = 2;
                //Console.WriteLine(stu.score);
                //Student.ID = 1;
            }
            //Human h = new Human();
            //Teacher t = h;
            //t.Teach();

            //uint y = 65537;
            //ushort x = (ushort)y;
            //Console.WriteLine(x);

            //char z= char.MaxValue;
            //Console.WriteLine(z);
            //Console.WriteLine(z.GetType());
            //Console.WriteLine(Convert.ToInt32(z));

            //int counter = 0;
            //for (counter = 0; counter < 10; ++counter)
            //{
            //    Console.WriteLine("Helloworld");
            //}
            //Console.WriteLine(counter);

            //int[] intArray = new int[] { 1, 2, 3, 4, 5, 6 };
            //IEnumerator enumerator = intArray.GetEnumerator();
            //while (enumerator.MoveNext())
            //{
            //    Console.WriteLine(enumerator.Current);
            //}


        }
        class Student
        {
            public int Age;
            public int Score;
            public static void Amount()
            {
                Console.WriteLine();
            }
            public static void AverageAge()
            {
                Console.WriteLine();
            }
            public static void AverageScore()
            {
                Console.WriteLine();
            }
        }
        public long Hanoi(int x)
        {
            if (x == 1)
            {
                return 2;
            }
            else
            {
                long result = 2 * Hanoi(x - 1);
                return result;
            }
        }
    }

    //struct Student
    //{
    //    public static int ID;
    //    public long score;
    //    //int No;
    //}
    class Teacher
    {
        public void Teach()
        {
            Console.WriteLine("I am a teacher");
        }
    }
    class Animal : Teacher
    {
        public static void Eat()
        {
            Console.WriteLine("I am a animal");
        }
    }
    class Human : Animal
    {
        public static void Sleep()
        {
            Console.WriteLine("I am a human");
        }
    }
}