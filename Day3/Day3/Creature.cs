using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    internal class Creature
    {
        public int Age;
        protected int Height;
        private int Weight;
        public Creature() : this(7)
        {
            //Creature(7);
        }
        public Creature(int weight) : this(weight,10)
        {
            //Creature(weight, 10);
        }
        public Creature(int weight,int height)
        {
            Weight = weight;
            Age = 1;
            Height = height;
            Console.WriteLine("Creature is Here");
            Console.WriteLine($"Creature is Here weight is {Weight}");
            Console.WriteLine($"Creature is Here Height is {Height}");
        }
        public virtual void Mov()
        {
            Console.WriteLine("Creature is moving");
        }
        protected void Eat()
        {
            Console.WriteLine("Creature is eating");
        }
        private void Die()
        {
            Console.WriteLine("Creature is dies");
        }

        public virtual void Like()
        {
            Console.WriteLine("Creaure is Like");
        }

        public virtual void Like2()
        {
            Console.WriteLine("Creaure 222222 is Like");
        }
    }
}
