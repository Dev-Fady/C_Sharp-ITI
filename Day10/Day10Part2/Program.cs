using System.Collections.Generic;

namespace Day10Part2
{
    internal class Program
    {
        static IEnumerable<T> Filter<T>( IEnumerable<T> items,Predicate<T> predicate)
        {
            List<T> newItem = new List<T>();
            foreach (T item in items)
            {
                if (predicate(item))
                {
                    newItem.Add(item);
                }
            }
            return newItem;
        }

        static IEnumerable<int> Squence()
        {
            Console.WriteLine("Squence method called");
            List<int> list = new List<int>() { 1, 2, 3, -4, 5, 6, -7, 8, -9, 10 };
            yield return list[0];

            yield return 1;
            yield return 2;
            yield return 3;
            yield return -4;
            yield return 'e';
        }
        static void Main(string[] args)
        {

            #region Anonymous object
            //var x = new { ID = 1, name = "aly" };
            //var y = new { ID = 2, name = "Zam" ,salary =200 };
            //Console.WriteLine($"x.ID : {x.ID} , x.name : {x.name}");
            //Console.WriteLine(y); 
            #endregion

            #region EXtention methods
            //List<int> numbers = new List<int>() { 1, 2, 3, -4, 5, 6, -7, 8, -9, 10 };
            //IEnumerable<int> res = Filter<int>(numbers, x => x > 0);
            ////.ToList()
            ////.ForEach(x => Console.WriteLine(x));
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}

            //IEnumerable<int> result = numbers.Filter(x => x > 0);

            //string str = "Hello World";
            //string newStr = Extensions.RemoveVowrld(str);
            //Console.WriteLine(newStr);
            //string newStr2 = str.RemoveVowrld();
            //Console.WriteLine(newStr2);
            //char newStr3 = Extensions.GetMiddleChar(newStr2);
            //Console.WriteLine(newStr3);

            //bool flag = Extensions.IsCapital(Extensions.GetMiddleChar(Extensions.RemoveVowrld(str)));
            //Console.WriteLine(flag);

            //bool flag2 = str.RemoveVowrld().GetMiddleChar().IsCapital();
            //Console.WriteLine(flag2); 
            #endregion

            #region Squence
            //IEnumerable<int> data = Squence();

            //foreach (var item in data)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("End of Squence method");

            //List<int> numbers = new List<int>() { 1, 2, 3, -4, 5, 6, -7, 8, -9, 10 };
            //IEnumerable<int> res = numbers.Filter(x => x > 0);

            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("After changing the numbers[0] to -1");
            //numbers[0] = -1;
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("--=-=-=-=-=-=-=-=-=Test FilterTest method--=-=-=-=-=-=-=-=-=");

            //List<int> numbersTest = new List<int>() { 1, 2, 3, -4, 5, 6, -7, 8, -9, 10 };
            //IEnumerable<int> resTest = numbersTest.FilterTest(x => x > 0);
            //foreach (var item in resTest)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("After changing the numbersTest[0] to -1");
            //numbersTest[0] = -1;
            //foreach (var item in resTest)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

        }
    }
}
