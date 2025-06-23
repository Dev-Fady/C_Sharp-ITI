namespace Day2
{
   /* Enum
    * 
    * // ENUM => List of const var 
    enum Gender
    {
        Male=0,
        Female=1, 
        // vlaue is defult is intger , [int  , float , double , long , short]  
    }
    [Flags]
    enum Weather
    {
        Normal,
        Sunny,
        Rainy=9,
        windy,
        normal,
    }
    [Flags]
    enum Weather2
    {
        Normal = 1,
        Sunny = 2,
        Rainy = 4,
        windy = 8,
        normal = 16,
    }*/
    internal class Program
    {
        /*Ref Typr
         * static void Div(int num) {
            num = 50;
        }
        static void Div(Person per)
        {
            per = new Person();
            per.x = 10;
            Console.WriteLine(per.x);
        }
        static void Div(ref Person per)
        {
            per = new Person();
            per.x = 10;
            Console.WriteLine(per.x);
        }*/
        static void Main(string[] args)
        {
            /* Ref Type
             * Console.WriteLine("Hello, World!");
              var p = new Person();
             //! error be Div referns to Person berfor run , but dynamic referns to person after run 
             // dynamic p = new Person();
              p.x = 800;
              Console.WriteLine(p.x);
              Div(ref p);
              Console.WriteLine(p.x);
            */

            /* Enum
             * 
             * Gender g = Gender.Female;
            Gender h = Gender.Male;
            Person p = new Person();
            p.Type = Gender.Male;
            if (p.Type == 0)
            {
                Console.WriteLine("0000000");
            }
            else
            {
                Console.WriteLine("1111111");
            }
            Weather w = (Weather)0;
            Weather w2 = Weather.Sunny;
            Weather w3 = (Weather)100;

            Console.WriteLine(w);
            Console.WriteLine(w2);
            Console.WriteLine((int)w);
            Console.WriteLine((int)w2);

            Console.WriteLine(w3);
            Console.WriteLine((int)w3);

            Weather todayWeather = Weather.Sunny | Weather.Rainy | Weather.normal;
            Console.WriteLine(todayWeather);
            Console.WriteLine((int)todayWeather);
            Weather2 todayWeather2 = Weather2.Sunny | Weather2.Rainy | Weather2.normal;
            Console.WriteLine(todayWeather2);
            Console.WriteLine((int)todayWeather2);

            if ((todayWeather2 & Weather2.Rainy) == Weather2.Rainy)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }*/

            #region struct
            //Complex c1;
            //c1.Real = 10;
            //c1.Img = 20;
            //Console.WriteLine($"c1 Real is {c1.Real}, Img is {c1.Img}");
            //// or => with defult Constructors
            //Complex c2 = new Complex();
            //Console.WriteLine($"c2 Real is {c2.Real}, Img is {c2.Img}");

            //Complex c3 = new Complex(100,200);
            //Console.WriteLine($"c3 Real is {c3.Real}, Img is {c3.Img}");

            //c1 = c3;
            //Console.WriteLine($"c1 Real is {c1.Real}, Img is {c1.Img}");

            //c2 = c1 + c3;
            //Console.WriteLine($"c2 Real is {c2.Real}, Img is {c2.Img}");

            ////c1 = c2;
            //if(c1 == c2)
            //{
            //    Console.WriteLine(true);
            //}
            //else
            //{
            //    Console.WriteLine(false);
            //}
            //if (c1 != c2)
            //{
            //    Console.WriteLine(false);
            //}
            //else
            //{
            //    Console.WriteLine(true);
            //}

            //Complex c4 = c1++;
            //Console.WriteLine($"c4 Real is {c4.Real}, Img is {c4.Img}");
            //Complex c5 = ++c1;
            //Console.WriteLine($"c5 Real is {c5.Real}, Img is {c5.Img}"); 
            #endregion

        }
    }
}
