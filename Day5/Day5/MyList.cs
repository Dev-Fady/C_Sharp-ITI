using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    internal class MyList : IEnumerable
    {
        int[] items;
        int currentIndex;

        public int Count
        {
            get 
            {
                return currentIndex + 1;
            }
        }
        public MyList()
        {
            items = new int[5];
            currentIndex = -1;
        }
        public void Add(int item)
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

        public int GetByIndex(int index)
        {
            return items[index];
        }

        public IEnumerator GetEnumerator()
        {
            return new Iterator(this);
        }

        class Iterator : IEnumerator
        {
            MyList myList;
            int index;
            public Iterator(MyList list)
            {
                myList = list;
                index = -1;
            }
            public object Current 
            { 
                get 
                {
                  return myList.items[index];
                }
            }

            public bool MoveNext()
            {
                //index+=2;
                index++;
                return index <= myList.currentIndex;
            }

            public void Reset()
            {
               index = -1;
            }
        }
    }
}
