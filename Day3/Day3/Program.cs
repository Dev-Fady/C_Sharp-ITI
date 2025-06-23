namespace Day3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Inheritance & Polymorphism
            //Creature c1 = new Creature();
            //Creature c2 = new Creature(weight: 15);
            //Creature c3 = new Creature(weight: 15, height: 80);
            //Human h1 = new Human();
            //h1.Mov();
            //h1.Think();
            //Creature c4 = new Human();
            ////! c4.Think();
            //c4.Mov();

            //Employe e1 = new Employe();
            //Human h2 = new Employe();
            //Creature c5 = new Employe();

            //e1.Like();
            //h2.Like();
            //c5.Like();

            //e1.Like2();
            //h2.Like2();
            //c5.Like2(); 
            #endregion

            /*Car c = new Car();
            c.Moving();
            c.Stop();*/

            #region Equals
            //Human h1 = new Human();
            //Human h2 = new Human();
            ////h1 = h2;

            //if (object.Equals(h1,100))
            //{
            //    Console.WriteLine("Equals");
            //}
            //else
            //{
            //    Console.WriteLine("Not Equal");
            //}

            //h1.Age = h2.Age = 10;
            //if (h1.Equals(h2))
            //{
            //    Console.WriteLine("Equals");
            //}
            //else
            //{
            //    Console.WriteLine("Not Equal");
            //} 
            #endregion 

            Console.WriteLine(h1.ToString());
            Console.WriteLine(h2.ToString());
            Console.WriteLine(h1.GetHashCode());
            Console.WriteLine(h2.GetHashCode());

            Human h3 = h1.clone();
            Console.WriteLine(h3.GetHashCode());
            Console.WriteLine(h3.Age);
        }
    }
}
