namespace Day1
{
    internal class Program
    {
        static void Swap(ref int first,ref int scound)
        {
            int temp = first;
            first = scound;
            scound = temp;
        }

        static int Div(int nem,int den,out int rem)
        {
            rem = nem % den;
            return nem / den;
        }
         static void UseRef(ref int a)
        {
            a += 10;
        }

        static void UseOut(out int b)
        {
            b = 20;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Hello world *****");
            string x = default;
            String x1 = "ff";
            Console.WriteLine(x);
            Console.WriteLine(x1);
            bool falg = default;
            Console.WriteLine(falg);

            float y = 5.5f;
            decimal x2 = 2.2m;
            Console.WriteLine(y);
            Console.WriteLine(x2);
            Console.WriteLine(" X is " + x2 + "y is " + y);
            Console.WriteLine(" X is {0} \t Y is ", x2, y);
            Console.WriteLine($" X is {x2} \t yy is {y}");

            string? str1 = Console.ReadLine();
            string? str2 = Console.ReadLine();
            int a = int.Parse(str1??"00");
            Console.WriteLine($" a is {a},{str1}");
            //int b = int.Parse(str2);
            //int b;
            int.TryParse(str2, out int b);
            Console.WriteLine($" b is {b},{str2}");
            if (int.TryParse(str2, out int c))
            {
                Console.WriteLine($" c is {c},{str2}");
            }

            //int a = 5, b = 10;
            Swap(ref a, ref b);
            Console.WriteLine($"a is {a} , b is {b}");
            int rem;
            int res = Div(a, b, out rem);
            Console.WriteLine($"Div is {res}, rem is {rem}");

            int xx = 5;
            UseRef(ref xx); // لازم xx = 5 يكون له قيمة
            Console.WriteLine(xx); // 15

            int yy; // مفيش قيمة
            UseOut(out yy); // الدالة لازم تدي y قيمة
            Console.WriteLine(yy); // 20


            // discard
            if (int.TryParse("123", out _))
            {
                Console.WriteLine("Parsing succeeded!");
            }
        }
    }
}
