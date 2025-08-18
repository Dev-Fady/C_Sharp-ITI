using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charpday4
{
    public class EmployeeTest
    {
        private int age;
        protected int Id;
        protected internal int Salary;
        /// <summary>
        /// access modifiers internal 
        /// </summary>
        internal int Experience;
        private protected int Bonus;
        public string Name;
    }
    class employeeTest2 : EmployeeTest
    {
        public employeeTest2()
        {
            Console.WriteLine(Id);
            Console.WriteLine(Salary);
            Console.WriteLine(Experience);
            Console.WriteLine(Bonus);
            Console.WriteLine(Name);

        }
    }

    class managerTest
    {
        public managerTest()
        {
            EmployeeTest employee = new EmployeeTest();
            employee.Experience = 5; // Accessible due to internal access modifier
            employee.Salary = 50000; // Accessible due to protected internal access modifier
            employee.Name = "John Doe"; // Accessible due to public access modifier
        }
    }
    public class PersonTest
    {
        private int age;
        public string Name;

        public int GetAge()
        {
            return age;
        }
        public void SetAge(int age)
        {
            if (age >= 30 && age <= 60)
            {
                throw new ArgumentOutOfRangeException("Age must be between 30 and 60.");
            }
            age = age;
        }

    }
}
