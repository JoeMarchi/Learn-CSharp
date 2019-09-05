using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using ClassLibrary1.MyNamespace;
using Data_structure_and_algorithm.demo1;

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

            //try
            //{
            //    Student2 stu1 = new Student2();
            //    stu1.Age = 20;
            //    Console.WriteLine(stu1.CanWork);
            //    Student2 stu2 = new Student2();
            //    stu2.Age = 10;

            //    //Console.WriteLine(stu1.Age+stu2.Age);
            //    if (stu2.Age >0&& stu2.Age <100)
            //    {
            //        Console.WriteLine(stu1.Age);
            //        int x = 100;
            //        stu1.Age = 15;
            //    }
            //    Console.WriteLine(stu1.Age);
            //    //Console.WriteLine(x);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //17 chapter indexer example
            //try
            //{
            //    Indexer index1 = new Indexer();
            //    var scoreMath = index1["Math"];

            //}catch(Exception ex)
            //{
            //    Console.WriteLine(ex);
            //}

            //18 chapter out argument
            //try
            //{
            //    bool b = Staff.StaffFactory("19", "Joe", out Staff st1);
            //    if (b == true)
            //    {
            //        Console.WriteLine("Name={0},Age={1}", st1.Name, st1.Age);
            //    }
            //    else
            //    {
            //        Console.WriteLine(b);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //18 chapter value&ref argument
            //Employee em1 = new Employee();
            //Student stu1 = new Student();
            //stu1.Age = 20;
            //Console.WriteLine("{0}-{1}",stu1.GetHashCode(),stu1.Age);
            //em1.NewEmpolyee(ref stu1);
            //Console.WriteLine("{0}-{1}",stu1.GetHashCode(),stu1.Age);

            //18 chapter params argument
            //Employee em2 = new Employee();
            //int x =em2.ShowAge("12","24", "Tim");
            //Console.WriteLine(x);

            //19 chapter delegate template method
            //ProductFactory productFactory = new ProductFactory();
            //WrapFactory wrapFactory = new WrapFactory();
            ////Func<Product> fun1 = new Func<Product>(productFactory.PizzaFactory);
            ////Func<Product> fun2 = new Func<Product>(productFactory.ToyCarFactory);
            //Box box1 = wrapFactory.WarpFactory(productFactory.PizzaFactory);
            //Box box2 = wrapFactory.WarpFactory(productFactory.ToyCarFactory);
            //Console.WriteLine(box1.Product.Name);
            //Console.WriteLine(box2.Product.Name);

            //19 chapter delegate bad quality code
            //Operation op1 = new Operation();
            //Operation op2 = new Operation();
            //Operation op3 = new Operation();
            //op3.innerOperation = op2;
            //op2.innerOperation = op1;
            //op3.Operate(new object(), null, null);
            //Myform myform = new Myform();
            //myform.ShowDialog();

            //22 chapter custom event problem
            //Methor x = new Methor(Delegatetset.Test);
            //x.Invoke(1, 2);

            //22 chapter custom event problem(customer)
            //Customer customer = new Customer();
            //Waiter waiter = new Waiter();
            //customer.Order += waiter.Action;
            //customer.Action();
            //customer.PayTheBill();
            //Console.ReadLine();

            //24 chapter Class declare,Accessibility levels
            //Class1 class1 = new Class1();
            //Console.WriteLine(class1.Add(1,2)); 

            //25 Parent class,Child class and Base class,Derived class
            //Vehicle c1 = new Car("James");
            //Console.WriteLine(c1.Owner);
            //c1.Run();
            //Console.WriteLine(c1.Owner);

            //int a = 12;
            ////Console.WriteLine(a.GetType().IsValueType);
            //Mathod1 mathod = new Mathod1((new ModifierTest()).Main_Mod);
            //mathod.Invoke();
            //Console.WriteLine(mathod.GetType().IsClass);
            ////object b = a;
            ////object b = new object();
            //string b = "0";
            //Console.WriteLine(b);
            //Console.WriteLine(b.GetType().IsClass);
            //Console.WriteLine(b.GetType().IsValueType);

            //30 chapter Generic delegate,Lambda expression,LINQ
            //var deleMod_ex = new DeleMod_ex();
            //deleMod_ex.Result();
            //Method_Parameter.CreateOrigin();
            //26 chapter override and polymorphism
            Animal T1=new Teacher();

            T1.Run();
            //27 abstract class and open-close principle
            //VehicleAbstract car = new Race();
            //car.Run();
            //28 interface,dependency inversion,unit test
            //Driver Linda = new Women(new Race());
            //Linda.Drive();
            //29 instence segregation,reflection,attribute,dependency injection
            //Driver mark = new Men(new MediumTank(),123) { Age = 1 };
            //Driver driver = mark;
            //driver.Age = 2;
            //Console.WriteLine(mark.Age);

            //Mark.Drive();
            //30 generic,partial class,enum,struct
            //Action<int,int> action = DeleMod_ex.Action_exp;
            Men joe = new Men(new LightTank(),123);
            Console.WriteLine(joe.Age);
            decimal test = 1.1m;

            //ex001 generic delegate,lambda expression,linq
            Test<double, int> test1 = new Test<double, int>(Test);
            Console.WriteLine(test1.Invoke(1, 2));
        }
        static double Test(double a,int b)
        {
            double x;
            x = a + b;
            return x;
        }
    }
    delegate T1 Test<T1, T2>(T1 a, T2 b);
    interface IWeapon
    {
        void Fire();
    }
    interface IVehicle
    {
        void Run();
        void Stop();
    }
    interface ITank : IVehicle, IWeapon
    {

    }
    class LightTank : ITank
    {
        public void Fire()
        {
            Console.WriteLine("Boom!");
        }

        public void Run()
        {
            Console.WriteLine("LightTank is running");
        }

        public void Stop()
        {
            Console.WriteLine("Stop!");
        }
    }
    class MediumTank : ITank
    {
        public void Fire()
        {
            Console.WriteLine("Boom!!");
        }

        public void Run()
        {
            Console.WriteLine("MediumTank is running");
        }

        public void Stop()
        {
            Console.WriteLine("Stop!!");
        }
    }
    class HeavyTank : ITank
    {
        public void Fire()
        {
            Console.WriteLine("Boom!!!");
        }

        public void Run()
        {
            Console.WriteLine("HeavyTank is running");
        }

        public void Stop()
        {
            Console.WriteLine("Stop!!!");
        }
    }

    abstract class VehicleAbstract:IVehicle
    {
        public abstract void Run();

        public void Stop()
        {
            Console.WriteLine("Stop");
        }
    }

    abstract class Driver
    {
        internal abstract int Age { get; set; }
        internal abstract void Drive();
    }

    class Women:Driver
    {
        private IVehicle _vehicle;
        public Women(IVehicle vehicle)
        {
            _vehicle = vehicle;
        }

        internal override int Age { get; set; }

        internal override void Drive()
        {
            _vehicle.Run();
            _vehicle.Stop();
        }
    }
    class Men:Driver
    {
        private int _ctorTest { get; set; }
        internal override int Age { get; set; }
        private IVehicle _vehicle;
        public Men(IVehicle vehicle,int ctorTest)
        {
            _vehicle = vehicle;
            _ctorTest = ctorTest;
            Age = _ctorTest;
        }
        internal override void Drive()
        {
            _vehicle.Run();
            _vehicle.Stop();
        }
    }

    class Truck:VehicleAbstract
    {
        public override void Run()
        {
            Console.WriteLine("Truck is running");
        }

    }
    class Race:VehicleAbstract
    {
        public override void Run()
        {
            Console.WriteLine("Race is running");
        }

    }
    class DeleMod_ex
    {
        public void Result()
        {
            //Action action_ex = new Action(Action_ex);
            //action_ex.Invoke();
            //var action_exp = new Action<int,int>(Action_exp);
            //action_exp.Invoke(5, 2);
            //Func<int> func_ex = new Func<int>(Func_ex);
            //Console.WriteLine(func_ex.Invoke());
            //var func_exp = new Func<int, int, int>(Func_exp);
            //Console.WriteLine(func_exp.Invoke(10, 10));
            var method_Act = new Method_Act<int>(Action_exp);
            method_Act.Invoke(1, 3);
            var method_Fun = new Method_Fun<int, double>(Func_exp);
            Console.WriteLine(method_Fun.Invoke(1, 0.005));
            Func<int,int,int> func = (a, b) => a + b;
            func(1, 2);
            Console.WriteLine(func(1, 2));
        }
        static void Action_ex()
        {
            Console.WriteLine("Action_ex");
        }
        public static void Action_exp(int x,int y)
        {
            Console.WriteLine(x*y);
        }
        static int Func_ex()
        {
            int x = 1;
            int y = 2;
            return x + y;
        }
        static double Func_exp(int x,double y)
        {
            return x + y;
        }
        
    }

    delegate void Method_Act<T>(T a,T b);
    delegate A Method_Fun<T,A>(T a, A b);
    //struct Student
    //{
    //    public static int ID;
    //    public long score;
    //    //int No;
    //}
    class Method_Parameter
    {
        public static void CreateOrigin()
        {
            Student stu = new Student() { Age = 27};
            CopyOrigin(stu);
            Console.WriteLine(CopyOrigin(stu).Age);
        }
        static Student CopyOrigin(Student stu)
        {
            stu = new Student() { Age = 18};
            Console.WriteLine(stu.Age);
            return stu;
        }
    }



    public delegate void Methor(int x, double y);
    class Delegatetset
    {
        private Methor methor;


        public static void Test(int f, double g)
        {
            Console.WriteLine("(0),(1)", f, g);
        }
    }

    public class Vehicle
    {
        //protected int test;
        internal int test=2;
        protected internal int _test1 { get; set; }
        //internal static int test;
        internal virtual void Run()
        {
            Console.WriteLine("I am running");
        }
        public Vehicle(string owner)
        {
            this.Owner = owner;
            
        }
        public string Owner { get; set; }
        internal void Test2()
        {
            this.test = 1;
        }
        //static void Test()
        //{
        //    test = 1;
        //}
    }
    public class Car:Vehicle
    {
        public Car(string owner):base("George")
        {
            //this.Owner = owner;
        }
        internal override void Run()
        {
            Console.WriteLine("Car is running");
        }
        public void Test()
        {
            //Vehicle vehicle = new Vehicle("Mark");
            //vehicle.test = 10;
            this.test = 10;
            //Vehicle.Test2();
        }
        private void Test2()
        {
            test = 10;
        }
    }
    class ModifierTest
    {
        public void Main_Mod()
        {
            //Vehicle vehicle = new Vehicle();
            //Console.WriteLine(vehicle.test);
            //vehicle.test1 = 11;
            //Vehicle.test = 11;
            //Vehicle.Test();
            
            
        }
    }

    delegate void OrderEventHandler (Customer customer, OrderEventArgs e);
    class Customer
    {
        public double Bill { get; set; }
        public void PayTheBill()
        {
            
            Console.WriteLine("You'll pay ${0}", this.Bill);
        }
        //private OrderEventHandler _orderEventHandler;
        public event OrderEventHandler Order;
        //{
        //    add
        //    {
        //        this._orderEventHandler += value;
        //        //Console.WriteLine("I am only one");
        //    }
        //    remove
        //    {
        //        this._orderEventHandler -= value;
        //    }
        //}
        public void Action()
        {
            OrderEventArgs e = new OrderEventArgs();
            e.DishName = "Sushi";
            e.Size = "large";
            this.Order.Invoke(this, e);
            //this._orderEventHandler.Invoke(this, e);
            OrderEventArgs e2 = new OrderEventArgs();
            e2.DishName = "Tofu";
            e2.Size = "small";
            //this._orderEventHandler.Invoke(this, e2);
        }
    }
    public class OrderEventArgs:EventArgs
    {
        public string DishName;
        public string Size;
    }
    class Waiter
    {
        public void Action(Customer customer,OrderEventArgs e)
        {
            Console.WriteLine("I'll serve you dish-{0}",e.DishName);
            double price = 10;
            switch (e.Size)
            {
                case "large":
                    price*=1.5;
                    break;
                case "small":
                    price*=0.5;
                    break;
                default:
                    break;
            }
            customer.Bill += price;
            Console.ReadLine();
        }
        
    }

    class Myform : Form
    {
        private TextBox TextBox;
        private Button Button;
        public Myform()
        {
            this.TextBox = new TextBox();
            this.Button = new Button();
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.Button);
            Button.Click += Button_Clicked;
            //this.Click += Form_Clicked;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            TextBox.Text =DateTime.Now.ToString();
        }

        private void Form_Clicked(object sender, EventArgs e)
        {
            this.Text = DateTime.Now.ToString();
        }
    }
    class Operation
    {
        public Action DefaultSuccessCallback { get; set; }
        public Action DefaultFailureCallback { get; set; }
        public Operation innerOperation { get; set; }

        public object Operate(object input, Action successCallback, Action failureCallback)
        {
            if (successCallback == null)
            {
                successCallback = this.DefaultSuccessCallback;
            }
            if (failureCallback == null)
            {
                failureCallback = this.DefaultFailureCallback;
            }
            object result = null;
            try
            {
                result = this.innerOperation.Operate(input, successCallback, failureCallback);
            }
            catch
            {
                failureCallback();
            }
            successCallback();
            return result;
        }
    }
    class Product
    {
        public string Name { get; set; }
    }
    class Box
    {
        public Product Product { get; set; }
    }
    class WrapFactory
    {
        public Box WarpFactory(Func<Product> getProduct)
        {
            Box box = new Box();
            Product product = getProduct();
            box.Product = product;
            return box;
        }
    }
    class ProductFactory
    {
        public Product PizzaFactory()
        {
            Product pizza = new Product();
            pizza.Name = "Pizza";
            return pizza;
        }
        public Product ToyCarFactory()
        {
            Product toycar = new Product();
            toycar.Name = "Toycar";
            return toycar;
        }
    }

    class Employee
    {
        public int ShowAge(string m, params string[] name)
        {
            Staff st1 = new Staff();
            st1.Age = int.Parse(name[0]);
            st1.Name = name[1];
            foreach (var item in name)
            {
                Console.WriteLine(item);
            }
            return st1.Age;
        }
        public void NewEmpolyee(ref Student stu1)
        {
            stu1 = new Student();
            stu1.Age = 19;
            Console.WriteLine("{0}-{1}", stu1.GetHashCode(), stu1.Age);

        }
    }
    class Staff
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public static bool StaffFactory(string age, string name, out Staff st1)
        {
            try
            {

                int a = int.Parse(age);
                st1 = null;
                if (string.IsNullOrEmpty(name))
                {
                    return false;
                }
                if (a < 20 || a > 80)
                {
                    return false;
                }
                st1 = new Staff() { Age = a, Name = name };
                return true;
            }
            catch (Exception)
            {
                throw new Exception("error");
            }
        }
    }
    class Indexer
    {
        private Dictionary<string, int> scoreDictionnary = new Dictionary<string, int>();

        public int? this[string subject]
        {
            get
            {
                if (this.scoreDictionnary.ContainsKey(subject))
                {
                    return scoreDictionnary[subject];
                }
                else
                {
                    return null;
                }

            }
            set
            {
                if (value.HasValue == false)
                {
                    throw new Exception("Score can't be null");
                }
                if (this.scoreDictionnary.ContainsKey(subject))
                {
                    scoreDictionnary[subject] = value.Value;
                }
                else
                {
                    scoreDictionnary.Add(subject, value.Value);
                }
            }
        }

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
                    this.CalculateCanWork();
                }
                else
                {
                    Exception ex1 = new Exception("Age argument is not true");
                    throw ex1;
                }
            }
        }
        private bool canWork;

        public bool CanWork
        {
            get { return canWork; }

        }
        private void CalculateCanWork()
        {
            if (this.age >= 18)
            {
                this.canWork = true;
            }
            else
            {
                this.canWork = false;
            }
        }

        //public bool CanWork {
        //    get
        //    {
        //        if (this.age >= 18)
        //        {
        //            return true;
        //        }
        //        else
        //        {
        //            return false;
        //        }
        //    }
        //}
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
    class Teacher:Human
    {
        public Teacher()
        {

        }

        public void Teach()
        {
            Console.WriteLine("I am a teacher");
        }
        public override void Run()
        {
            Console.WriteLine("Teacher is running");
        }
    }
    class Animal
    {
        public Animal()
        {

        }
        public void Eat()
        {
            Console.WriteLine("I am a animal");
        }
        public virtual void Run()
        {
            Console.WriteLine("Animal is running");
        }
    }
    class Human : Animal
    {
        public Human()
        {

        }
        public static void Sleep()
        {
            Console.WriteLine("I am a human");
        }
        public override void Run()
        {
            Console.WriteLine("Human is running");
        }
    }
    interface IPowerSupply:IEnumerable
    {
        void GetPower();
    }
    class DeskFan : IPowerSupply
    {
        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void GetPower()
        {
            throw new NotImplementedException();
        }
        
    }
    
}


