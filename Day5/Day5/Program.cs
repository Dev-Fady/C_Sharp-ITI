
namespace Day5
{
    internal class Program
    {
        static void Main(string[] args)
        {
           MyList myList = new MyList();
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
            myList.Add(5);

            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine(myList.GetByIndex(i));
            }

            /*    int[] arr = {1, 2, 3, 4, 50, 6};
                foreach (var item in arr)
                {
                    Console.WriteLine($"item is {item}");
                }*/

            #region error becuase myList is privite
            /*
                foreach (var item in myList)
                {
                    Console.WriteLine($"item is {item}");
                }
                */
            #endregion

            Console.WriteLine("===============");
            foreach (var item in myList)
            {
                Console.WriteLine($"item is {item}");
            }
        }
    }
}
