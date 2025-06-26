using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    internal class Employee : IComparable<Employee>
    {
        public int Id;
        private int Salary;

        //  Properties
        public int salary
        {
            get
            {
                return Salary;
            }
            set
            {
                if (value > 3000)
                {
                    Salary = value;
                }
            }
        }

        public int Feed { get; set; }

       public Employee()
        {
            
        }
        public Employee(int id)
        {
            Id = id;
        }
        public void setSalary(int salary)
        {
            if(salary>300)
                this.Salary = salary;
        }
        public int getSalary()
        {
            return Salary;
        }

        static public void Swap<T>(ref T x,ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }

        //public int CompareTo(object obj)
        //{
        //    if (obj is Employee emp)
        //    {
        //        if(this.Id > emp.Id)
        //        {
        //            return 1;
        //        }
        //        if (this.Id < emp.Id)
        //        {
        //            return -1;
        //        }
        //        return 0;
        //    }
        //    return 1;
        //}

        //public int CompareTo(Employee obj)
        //{
        //    if (this.Id > obj.Id)
        //        return 1;

        //    if (this.Id < obj.Id)
        //        return -1;
        //    return 0;
        //}

        public int CompareTo(Employee obj)
        {
            return this.Id.CompareTo(obj.Id);
        }
    }
}
