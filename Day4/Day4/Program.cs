namespace Day4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            //  Properties
            e1.salary = 4000;
            int x = e1.salary;
            Console.WriteLine(x);

            e1.Feed = 1414;
            int f = e1.Feed;
            Console.WriteLine(f);



            Employee.Swap<int>(ref x,ref f );

            Console.WriteLine($"Feed is {f} , Salary is {x}");

            MyList<int> myList = new MyList<int>();
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
            myList.print();

            IMovable m1 = new Car();
            m1.Move();
            IMovable m2 = new Human();
            m2.Move();
            //!m2.move();
            Car c1 = new Car();
            //! c1.Move();


            ITestable T1 = new Car();
            T1.Foo();
            IReplacable R1 = new Car();
            R1.Foo();
            Car car = new Car();
            car.Foo();


            int[] arr = { 6, 5, 1, 8, 4, 7, 3, 2, 0 };
            Array.Sort(arr);
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------");
            
            Employee[] emps =new Employee[3];
            emps[0] = new Employee(10);
            emps[1] = new Employee(5);
            emps[2] = new Employee(1);
            Array.Sort(emps);
            for (int i = 0; i < emps.Length; i++)
            {
                Console.WriteLine(emps[i].Id);
            }
        }
    }
}
