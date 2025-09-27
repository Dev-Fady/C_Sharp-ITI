using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1LinqDay2
{
    public static class MYEX
    {
        public static int MyCount<TSource>(this IEnumerable<TSource> sources, Func<TSource, bool> predicate)
        {
            int counter = 0;
            foreach (var item in sources)
            {
                if (predicate(item))
                    counter++;
            }
            return counter;
        }

        public static IEnumerable<TSource> MyReverse<TSource>(this IEnumerable<TSource> sources)
        {
            List<TSource> temp = new List<TSource>();
            foreach (var item in sources)
            {
                temp.Add(item);
            }
            for (int i = temp.Count - 1; i >= 0; i--)
            {
                yield return temp[i];
            }
        }
        public static IEnumerable<TSource> MyOrderBy<TSource, TKey>(this IEnumerable<TSource> sources, Func<TSource, TKey> keySelector)
        {
            List<TSource> temp = new List<TSource>();
            foreach (var item in sources)
            {
                temp.Add(item);
            }
            for (int i = 0; i < temp.Count - 1; i++)
            {
                for (int j = i + 1; j < temp.Count; j++)
                {
                    if (Comparer<TKey>.Default.Compare(keySelector(temp[i]), keySelector(temp[j])) > 0)
                    {
                        TSource t = temp[i];
                        temp[i] = temp[j];
                        temp[j] = t;
                    }
                }
            }
            foreach (var item in temp)
            {
                yield return item;
            }
        }
    }
}
