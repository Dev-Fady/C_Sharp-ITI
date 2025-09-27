using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1LinqDay2
{
    public static class ExtentionMethods
    {
        // SubRoutine
        public static IEnumerable<TSource> FilterV1<TSource>(this IEnumerable<TSource> source, Func<TSource , bool> predicate)
        {
            List<TSource> result = new List<TSource>();
            foreach (var item in source)
            {
                if (predicate(item))
                {
                    result.Add(item);
                }
            }
            return result;
        }
        
        //CoRoutine
        public static IEnumerable<TSource> FilterV2<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
        {
            foreach (TSource item in source)
            {
                if (predicate(item))
                    yield return item;
            }
        }

        public static IEnumerable<TResult> MySelect<TSource, TResult>(this IEnumerable<TSource> sources, Func<TSource, TResult> selector)
        {
            foreach (TSource item in sources)
            {
                yield return selector(item);
            }
        }

        public static List<TSource> ToMyList<TSource>(this IEnumerable<TSource> sources)
        {
            List<TSource> result = new List<TSource>();
            foreach (var item in sources)
            {
                result.Add(item);
            }
            return result;
        }

        public static TSource MyFirst<TSource>(this IEnumerable<TSource> sources)
        {
            foreach (var item in sources)
            {
                return item;
            }
            throw new InvalidOperationException("Collection not contains values");
        }
        public static TSource MyFirst<TSource>(this IEnumerable<TSource> sources, Func<TSource, bool> predicate)
        {
            foreach (var item in sources)
            {
                if (predicate(item))
                    return item;
            }
            throw new InvalidOperationException("Collection not contains values");
        }

        public static TSource MyFirstOrDefault<TSource>(this IEnumerable<TSource> sources)
        {
            foreach (var item in sources)
            {
                return item;
            }
            return default;
        }
        public static TSource MyFirstOrDefault<TSource>(this IEnumerable<TSource> sources, Func<TSource, bool> predicate)
        {
            foreach (var item in sources)
            {
                if (predicate(item))
                    return item;
            }
            return default;
        }
        public static TSource MyLast<TSource>(this IEnumerable<TSource> sources)
        {
            bool flag = false;
            TSource source = default;

            foreach (var item in sources)
            {
                source = item;
                flag = true;
            }
            if (flag)
            {
                return source;
            }
            throw new InvalidOperationException("Collection not contains values");
        }
        public static TSource MyLast<TSource>(this IEnumerable<TSource> sources, Func<TSource, bool> predicate)
        {
            bool flag = false;
            TSource source = default;

            foreach (var item in sources)
            {
                if (predicate(item))
                {
                    source = item;
                    flag = true;
                }
            }
            if (flag)
            {
                return source;
            }
            throw new InvalidOperationException("Collection not contains values");
        }
        public static TSource MyLastOrDefault<TSource>(this IEnumerable<TSource> sources)
        {
            bool flag = false;
            TSource source = default;

            foreach (var item in sources)
            {
                source = item;
                flag = true;
            }
            return source;
        }
        public static TSource MyLastOrDefault<TSource>(this IEnumerable<TSource> sources, Func<TSource, bool> predicate)
        {
            bool flag = false;
            TSource source = default;

            foreach (var item in sources)
            {
                if (predicate(item))
                {
                    source = item;
                    flag = true;
                }
            }
            return source;
        }
        public static bool MyAny<TSource>(this IEnumerable<TSource> sources, Func<TSource, bool> predicate)
        {
            foreach (var item in sources)
            {
                if (predicate(item))
                {
                    return true;
                }
            }
            return false;
        }
        public static bool MyAll<TSource>(this IEnumerable<TSource> sources, Func<TSource, bool> predicate)
        {
            foreach (var item in sources)
            {
                if (!predicate(item))
                {
                    return false;
                }
            }
            return true;
        }
        public static int MyCount<TSource>(this IEnumerable<TSource> sources)
        {
            int counter = 0;
            foreach (var item in sources)
            {
                counter++;
            }
            return counter;
        }
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
