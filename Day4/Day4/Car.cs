using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    internal class Car : IMovable, ITestable, IReplacable
    {


        // implicit interface imple

        //public void Move()
        //{
        //    Console.WriteLine("Imoveble car is Moving");
        //}


        // explicit interface imple
        void IMovable.Move()
        {
            Console.WriteLine("Imoveble car is Moving");
        }

        // ! Error
        //public void Foo()
        //{
        //    throw new NotImplementedException();
        //}

        //public void Foo()
        //{
        //    throw new NotImplementedException();
        //}

        void IReplacable.Foo()
        {
            Console.WriteLine("Interface Replacable test ");
        }

        void ITestable.Foo()
        {
            Console.WriteLine("Interface Tesetable test ");
        }

        public void Foo()
        {
            Console.WriteLine("this is Owner Class Car 🤞");
        }
    }
}
