using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    class person
    {
        protected int id;
        protected string name;
        protected string address;

        protected void Display()
        {
            Console.WriteLine($"Employee Id is:{id}");
            Console.WriteLine($"Employee Name is:{name}");
            Console.WriteLine($"Employee Address is:{address}");
        }
    }
    class Employee : person
    {
        public Employee()
        {
            id = 1;
            name = "Mahi";
            address = "Pune";
        }
        public void Info()
        {
            Display();

        }
    }
    internal class ProtectedDemo
    {
        static void Main()
        {
            Employee e1 = new Employee();
            e1.Info();

        }
    }
}
