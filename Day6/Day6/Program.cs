namespace Day6
{
    internal class Program
    {
        static bool IsPositive(int item)
        {
            return item > 0;
        }

        static bool IsEven(int item)
        {
            return item % 2 == 0;
        }
        static void FilterPositive(List<int> list)
        {
            foreach (var item in list)
            {
                if (IsPositive(item) )
                {
                    Console.WriteLine($"item : {item}");
                }
            }
        }
        static void Filter(List<int> list, ICheckable checkable)
        {
            foreach (var item in list)
            {
                if (checkable.Check(item))
                {
                    Console.WriteLine($"item : {item}");
                }
            }
        }

        delegate bool MyDelegate(int item);

        static void FilterDelegate(List<int> list, MyDelegate del)
        {
            foreach (var item in list)
            {
                if (del(item))
                {
                    Console.WriteLine($"item : {item}");
                }
            }
        }

        // Using Predicate delegate
        static void FilterDelegatePredicate(List<int> list, Predicate<int> del)
        {
            foreach (var item in list)
            {
                if (del(item))
                {
                    Console.WriteLine($"item : {item}");
                }
            }
        }


        static void Main(string[] args)
        {
            #region delegates
            /*  List<int> list = new List<int>()
                {
                    1, -2, 3, 4, -5, 6, 7, 8, 9,
                };
                //PositiveCheckable checkable = new PositiveCheckable();
                //Filter(list, checkable);
                //or
                Filter(list, new PositiveCheckable());

                Console.WriteLine("==========Using delegate:=============");
                MyDelegate del1=new MyDelegate(IsPositive);
                foreach (var item in list)
                {
                    if (del1.Invoke(item))
                    {
                        Console.WriteLine($"item : {item}");
                    }
                }
                Console.WriteLine("==========Using delegate method: EVEN=============");
                MyDelegate del2 = IsEven;
                FilterDelegate(list, del2);

                Helper h1=new Helper { ID = 1 };
                Helper h2 = new Helper { ID = 2 };

                MyDelegate del3 = h1.IsNagative; // ID is 1
                MyDelegate del4 = h2.IsNagative; // ID is 2
                MyDelegate del5 = Helper.IsOdd; // ID is NULL
                Console.WriteLine("==========Using delegate By class h1 =============");
                FilterDelegate(list, del3);
                Console.WriteLine("==========Using delegate By class h2 =============");
                FilterDelegate(list, del4);
                Console.WriteLine("==========Using delegate By static method =============");
                FilterDelegate(list, del5);

                Console.WriteLine("==========Using delegate By anonymous method =============");
                FilterDelegate(list, delegate(int item)
                {
                    return item < 0; // Using anonymous method
                });

                Console.WriteLine("==========Using delegate By lambda =============");
                FilterDelegate(list, item => item < 0); // Using lambda expression
                Console.WriteLine("=======================");
                FilterDelegate(list, item => item > 0); // Using lambda expression
                Console.WriteLine("==========Using delegate By lambda with even =============");
                FilterDelegate(list, item => item % 2 == 0); // Using lambda expression for even numbers

                Console.WriteLine("==========Using Predicate delegate =============");
                FilterDelegatePredicate(list, item => item < 0); // Using Predicate delegate for negative numbers

                Func<double> del6 = () =>
                {
                    int x = 5, y = 10;
                    double result = (x+y) / 2.0; // Example calculation
                    return result;
                };

                Console.WriteLine($"del6: {del6()}"); // Using Func delegate to return a double value

                Func<int, int, double> del7 = (x, y) =>
                {
                    return (x + y) / 2.0; // Example calculation
                };
                Console.WriteLine($"del7: {del7(5, 10)}"); // Using Func delegate to return a double value with parameters

                Action<int,int , double> del8 = (a,b,c) => 
                {
                    Console.WriteLine($"Action delegate: {a} : {b} : {c}");
                };
                del8(42,10,724);

                Predicate<int> del9 = IsPositive;
                del9(5);
                del9 += IsEven; // Combining predicates
                del9(8);
                Console.WriteLine($"del9(5): {del9(5)}");
              */
            #endregion

            SportClup alAhly = new SportClup() { Name = "Al Ahly" };
            Journalist journalist = new Journalist();
            Journalist journalist2 = new Journalist();
            Magazine magazine = new Magazine();
            Website website = new Website();


            alAhly.PlayerAdded += journalist.PlayereAdded;
            alAhly.PlayerAdded += magazine.NewPlayerAdded;
            website.Playercom += journalist.PlayereAdded;

            alAhly.AddPlayer("Mohamed Salah");

            SportClup madred = new SportClup() { Name = "Real Madred" };


            madred.PlayerAdded += journalist.PlayereAdded;
            madred.PlayerAdded += magazine.NewPlayerAdded;
            //! madred.PlayerAdded = journalist2.PlayereAdded;
            //! madred.PlayerAdded = null;

            madred.AddPlayer("Omer Ahmed");
            website.AddPlayer();
        }
    }
}
