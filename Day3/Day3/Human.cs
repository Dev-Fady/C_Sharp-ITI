using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    internal class Human : Creature
    {
        public Human(): base(47)
        {
        }
        public void Think()
        {
            Console.WriteLine("Human is Thanking");
        }
        public override void Mov()
        {
            base.Mov();
            Console.WriteLine("Human is moving");
        }
        public override void Like()
        {
            Console.WriteLine("Human is Like");
        }
        public new virtual void Like2()
        {
            Console.WriteLine("Human 222 is Like");
        }

        public override bool Equals(object? obj)
        {
            //Human h = (Human)obj;
            //return this.Age == h.Age;

            //or

            //Human h = obj as Human;
            //if (h !=null)
            //{
            //    return this.Age == h.Age;
            //}
            //else
            //{
            //    return false;
            //}

            //or

            //if (obj is Human)
            //{
            //    Human h = obj as Human;
            //    return this.Age == h.Age;
            //}
            //return false;

            //or

            if (obj is Human h)
            {
                //Human h = obj as Human;
                return this.Age == h.Age;
            }
            return false;
        }

        public override string ToString()
        {
            return "this is class Human is nameSpace in Day 3";
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public Human clone()
        {
            return (Human)this.MemberwiseClone();
        }
    }
}
