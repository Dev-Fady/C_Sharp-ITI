
namespace Day5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region IEnumerable
            //MyList myList = new MyList();
            // myList.Add(1);
            // myList.Add(2);
            // myList.Add(3);
            // myList.Add(4);
            // myList.Add(5);

            // for (int i = 0; i < myList.Count; i++)
            // {
            //     Console.WriteLine(myList.GetByIndex(i));
            // }

            // /*    int[] arr = {1, 2, 3, 4, 50, 6};
            //     foreach (var item in arr)
            //     {
            //         Console.WriteLine($"item is {item}");
            //     }*/

            // #region error becuase myList is privite
            // /*
            //     foreach (var item in myList)
            //     {
            //         Console.WriteLine($"item is {item}");
            //     }
            //     */
            // #endregion

            // Console.WriteLine("===============");
            // foreach (var item in myList)
            // {
            //     Console.WriteLine($"item is {item}");
            // } 
            #endregion

            #region Object Initalizer
            //Employee employee = new Employee() {
            //    Name = "fady",
            //    Id = 1,
            //    Salary = 1000
            //};
            //Console.WriteLine($"Employee Name: {employee.Name}, Id: {employee.Id}, Salary: {employee.Salary}");

            #endregion

            MyList myList = new MyList();
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);

            int x = myList[0];
            Console.WriteLine($"First item in the list: {x}");
            myList[0] = 10;
            Console.WriteLine($"Updated first item in the list: {myList[0]}");

            List<int> list = new List<int>();
            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.AddRange(
                new int[] { 
                    40, 50, 60 }
                );
            list.Insert( 0, 5);
            list.Remove(20);
            list.RemoveAt(0);
            list.ForEach(item => Console.WriteLine($"List item: {item}"));

            LinkedList<int> linkedList = new LinkedList<int>();
            linkedList.AddLast(1);
            linkedList.AddLast(2);
            linkedList.AddLast(3);
            linkedList.AddFirst(0);
            linkedList.Remove(2);
            linkedList.Find(3)!.Value  = 33; // Update value of the node containing 3
            foreach (var item in linkedList)
            {
                Console.WriteLine($"List item :{item}");
            }

            // make sure to include only one of vlaue
            HashSet<int> hashSet = new HashSet<int>();
            hashSet.Add(1);
            hashSet.Add(2);
            hashSet.Add(3);
            hashSet.Add(3); // This will not add a duplicate value
            hashSet.Contains(2); // Check if 2 is in the set
            hashSet.Remove(1); // Remove 1 from the set
            foreach (var item in hashSet)
            {
                Console.WriteLine($"HashSet item: {item}");
            }

            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(1, "One");
            dictionary.Add(2, "Two");
            dictionary[3] = "Three"; // Add or update value for key 3
            if (dictionary.TryGetValue(2, out string? value))
            {
                Console.WriteLine($"Key 2 has value: {value}");
            }
            foreach (var item in dictionary)
            {
                Console.WriteLine($"dictionary items key : {item.Key} items vlaue : {item.Value}");
            }
        }
    }
}
