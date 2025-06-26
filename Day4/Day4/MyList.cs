using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    internal class MyList<T> //where T : class
    {
        T[] items;
        int currentIndex;


        public MyList()
        {
            items = new T[5];
            currentIndex = -1;
        }
        public void Add(T item)
        {
            if (currentIndex == items.Length-1)
            {
                Console.WriteLine("Fulllll");
            }
            else
            {
                currentIndex++;
                items[currentIndex] = item;
            }
        }
        public void print()
        {
            if (currentIndex == items.Length - 1)
            {
                Console.WriteLine("Fulllll");
            }
            else
            {

                foreach (var item1 in items)
                {
                    Console.WriteLine(item1);
                }
            }
        }
    }
}
