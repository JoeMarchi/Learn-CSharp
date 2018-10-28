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

            //List<Student> stuList = new List<Student>();
            //for (int i = 0; i < 100; i++)
            //{
            //    Student stu = new Student();
            //    stu.Age += 40;
            //    stu.Score = i;
            //    stuList.Add(stu);
            //}
            //    int totalAge=0;
            //    int totalScore=0;
            //    foreach (var stu in stuList)
            //    {
            //        totalAge += stu.Age;
            //        totalScore += stu.Score;
            //    }
            //    Student.AverageAge = totalAge / Student.Amount;
            //    Student.AverageScore = totalScore / Student.Amount;
            //    Student.ReportAmount();
            //    Student.ReportAverageAge();
            //    Student.ReportAverageScore();

            //public long Hanoi(int x)
            //{
            //    if (x == 1)
            //    {
            //        return 2;
            //    }
            //    else
            //    {
            //        long result = 2 * Hanoi(x - 1);
            //        return result;
            //    }
            //}

        //    try
        //    {
        //        Student2 stu1 = new Student2();
        //        stu1.Age = 20;
        //        Student2 stu2 = new Student2();
        //        stu2.Age = 10;
        //        //Console.WriteLine(stu1.Age+stu2.Age);
        //        if (stu2.Age > 5)
        //        {
        //            Console.WriteLine(stu1.Age);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        }

        //struct Student
        //{
        //    public static int ID;
        //    public long score;
        //    //int No;
        //}



    }
    class Student2
    {
        private int age;
        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value > 0 && value < 100)
                {
                    this.age = value;
                }
                else
                {
                    Exception ex1 = new Exception("Age argument is not true");
                    throw ex1;
                }
            }
        }
    }
    class Student
    {
        public int Age;
        public int Score;
        public static int Amount;
        public static int AverageAge;
        public static int AverageScore;
        public Student()
        {
            Age++;
            //this.Amount++;
            Amount++;
            //Student.Amount++;
        }
        public static void ReportAmount()
        {

            Console.WriteLine(Amount);
        }
        public static void ReportAverageAge()
        {
            Console.WriteLine(AverageAge);
        }
        public static void ReportAverageScore()
        {
            Console.WriteLine(AverageScore);
        }
    }
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


