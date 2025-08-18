using System.Collections;

namespace Charpday4
{
    #region class
    //Reference Type
    class Person
    {
        //Member Variable [Fields , Attributes]
        //Member Function - Behaviors [Methods , Constructor , Getter , Setter , Destructor]
        //Properties [Dynamic Property , Standared Property]

        public string Name;
        public int Age;
        public Gender type;
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
            Console.WriteLine(" construres with paer ----------------class---------------");
        }
        public Person() //Default Constructor
        {
            Name = default; //null
            Age = default; //0
            Console.WriteLine("Defuilt construres ----------------class---------------");
        }
        ~Person() //Destructor
        {
            //Clean up resources if needed
            Console.WriteLine("Destructor called for Person");
        }
        override public string ToString()
        {
            return $"Name: {Name}, Age: {Age}";
        }
    }
    #endregion

    #region Struct
    //Value Type
    struct Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
            Console.WriteLine(" construres with pers ----------------Struct---------------");
        }
        public Point()
        {
            X = default;
            Y = default;

            //x = 0;
            //y = 0;
            Console.WriteLine("Defuilt construres ----------------Struct---------------");
        }
    }
    #endregion

    #region Enums
    [Flags]
    enum Color
    {
        Red,
        Green = 3,
        Blue,
        Yellow = 80,

        Black,
    }
    class Car
    {
        public string Model;
        public int Year;
        public Color Color; //Optional Property
        public Car(string model, int year, Color color)
        {
            Model = model;
            Year = year;
            Color = color;
            Console.WriteLine($"model is : {model}\t year is : {year} \t Coloer is {color}");
        }

    }
    #endregion

    #region Getter . Setter - Standered Property - Dynamic Property
    class Employee
    {
        private int Age;
        public string Name;

        //Dynamic Property
        public int Address { get; set; }

        //Standered Property
        public int age
        {
            get
            {
                return Age;
            }
            set
            {
                if (value < 30 || value > 60)
                {
                    throw new ArgumentOutOfRangeException("Age must be between 30 and 60.");
                }
                Age = value;
            }
        }

        //Getter / Setter Methods
        public int GetAge()
        {
            return Age;
        }
        public void SetAge(int age)
        {
            if (age >= 30 && age <= 60)
            {
                throw new ArgumentOutOfRangeException("Age must be between 30 and 60.");
            }
            Age = age;
        }

    }
    #endregion

    #region Enum
    // ENUM => List of const var 
    enum Gender
   {
       Male=0,
       Female=1, 
       // vlaue is defult is intger , [int  , float , double , long , short]  
   }
   [Flags]
   enum Weather
   {
       Normal,
       Sunny,
       Rainy=9,
       windy,
       normal,
   }
   [Flags]
   enum Weather2
   {
       Normal = 1,
       Sunny = 2,
       Rainy = 4,
       windy = 8,
       normal = 16,
   }
    #endregion
    class employee2 : EmployeeTest
    {
        public employee2()
        {
            Console.WriteLine(Id);
            Console.WriteLine(Salary);
            Console.WriteLine(Name);
            Console.WriteLine(Experience);
            Console.WriteLine(Name);
            Console.WriteLine(Bonus);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Nullable Type
            //int x = 10;
            ////int y1 = null;
            ////Nullable< int> y2 = null;
            //int? y3 = null;

            //x = (int)y3; //UnSafe Casting 

            //if (y3 != null)
            //{
            //    x = (int)y3; //Safe Casting
            //}

            //if (y3.HasValue)
            //{
            //    x = y3.Value; //Safe Casting using HasValue
            //}

            //if (y3 != null)
            //{
            //    x = y3.Value; //Safe Casting using HasValue
            //}

            #endregion

            #region Null coalesing operator
            //string fname = "ahmed";
            //string lname = "ali";

            //string fullname = "ahmed ali";

            //string name = fname ?? lname ?? fullname; 
            //Console.WriteLine(name);
            #endregion

            #region Null Propagation Operator

            //int[] arr = null;
            ////if (arr != null && arr.Length > 0)
            //if (arr != null & arr.Length > 0)
            //{
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        Console.WriteLine(arr[i]);
            //    }
            //}

            //int[] arr = null;

            //for (int i = 0; i < arr?.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}
            #endregion

            #region Value Type vs Reference Type
            ////Value Type

            //Point p1 = new Point(); //Valid
            //Point p2 = new Point(10, 60);//Valid 

            ////Reference Type
            //Person p3 = new Person();//Valid
            //Person p4 = new Person("fady", 454);//Valid

            #endregion

            #region Value Type In Memory , Reference Type In Memory
            //int x;
            //Console.WriteLine(x); //Invalid

            //Point p1;
            ////Console.WriteLine(p1.X); //Invalid
            //p1 = new Point(); //Valid
            //Console.WriteLine(p1.X); //Valid 0



            //Person p2;
            ////Console.WriteLine(p2.Name);//Invalid 
            //p2 = new Person();
            //Console.WriteLine(p2.Name);
            #endregion


            #region Garbage Collector & Destructor [Finalizer]
            //Person person = new Person("Ahmed", 30);
            //person = null;
            ////.Net Framework 
            //GC.Collect(); //Force garbage collection to call the destructor

            ////.Net Core
            //for (int i = 0; i < 80000; i++)
            //{
            //    new Person();
            //    Console.WriteLine("Object Number " + i);
            //}
            #endregion

            #region ToString()
            //Person p = new Person("Ahmed", 30);
            //Console.WriteLine(p.ToString());
            #endregion

            #region Enums
            //Car c1 = new Car("Toyota", 2020, Color.Red);
            //Car c2 = new Car("Honda", 2021, Color.Red);
            //Car c3 = new Car("Ford", 2022, Color.Green);
            //Car car = new Car("BMW", 2023, Color.Blue);
            #endregion

            #region Getter . Setter - Standered Property - Dynamic Property

            //Employee e = new Employee();
            ////e.Age = 30; // error 
            //e.Name = "Ahmed";
            //Console.WriteLine(e.Name);

            ////Console.WriteLine(e.Age);
            ////Console.WriteLine(e.Name);

            //e.SetAge(30);
            //Console.WriteLine(e.GetAge());

            //e.age = 30; //Using Property
            //Console.WriteLine(e.age); //Using Property 
            #endregion

            #region array accept any data type
            //object[] arr = { "dsds", 5454, 55.2f, true, new Point(10, 20) };

            //ArrayList arrayList = new ArrayList();
            //arrayList.Add("dsds");
            //arrayList.Add(5454);
            //arrayList.Add(55.2f);
            //arrayList.Add(true);
            //arrayList.Add(new Point(10, 20));
            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Enum
            Gender g = Gender.Female;
            Gender h = Gender.Male;
            Person p = new Person();
            p.type = Gender.Male;
            if (p.type == 0)
            {
                Console.WriteLine("0000000");
            }
            else
            {
                Console.WriteLine("1111111");
            }
            Weather w = (Weather)0;
            Weather w2 = Weather.Sunny;
            Weather w3 = (Weather)100;

            Console.WriteLine("*************");
            Console.WriteLine(w);
            Console.WriteLine(w2);
            Console.WriteLine((int)w);
            Console.WriteLine((int)w2);

            Console.WriteLine(w3);
            Console.WriteLine((int)w3);
            Console.WriteLine("*************");


            Weather todayWeather = Weather.Sunny | Weather.Rainy | Weather.normal;
            Console.WriteLine(todayWeather);
            Console.WriteLine((int)todayWeather);
            Weather2 todayWeather2 = Weather2.Sunny | Weather2.Rainy | Weather2.normal;
            Console.WriteLine(todayWeather2);
            Console.WriteLine((int)todayWeather2);

            if ((todayWeather2 & Weather2.Rainy) == Weather2.Rainy)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
            #endregion
        }
    }
}
