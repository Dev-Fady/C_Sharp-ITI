using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10Part2
{
    internal static class Extensions
    {
        public static IEnumerable<T> Filter<T>(this IEnumerable<T> items, Predicate<T> predicate)
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


        public static string RemoveVowrld(this string str)
        {
            List<char> vowels = new List<char>() { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            string newString = "";
            foreach (var item in str)
            {
                if (!vowels.Contains(item))
                {
                    newString += item;
                }
            }
            return newString;
        }

        public static char GetMiddleChar(this string str)
        {
           return str[str.Length / 2];
        }
        public static bool IsCapital(this char c)
        {
            return char.IsUpper(c);
        }

        public static IEnumerable<T> FilterTest<T>(this IEnumerable<T> items, Predicate<T> predicate)
        {
            foreach (T item in items)
            {
                if (predicate(item))
                {
                    yield return item;
                }
            }
        }
    }
}