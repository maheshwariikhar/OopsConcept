using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    internal class Datatypes
    {
        static void Main()
        {
            //Datatypes Declaration
            int age = 30;
            float price = 95.25f;
            double pi = 3.14159;
            decimal salary = 100000.50m;
            char grade = 'A';
            bool isActive = false;
            DateTime Today = DateTime.Now;
            object data = 200;
            int? score = null;
            String name = "Mahi";


            //print datatypes

            Console.WriteLine("int:" + age);
            Console.WriteLine("float:" + price);
            Console.WriteLine("double:" + pi);
            Console.WriteLine("decimal:" + salary);
            Console.WriteLine("char:" + grade);
            Console.WriteLine("bool:" + isActive);
            Console.WriteLine("DataTime:" + Today);
            Console.WriteLine("object:" + data);
            Console.WriteLine("int?:" + score);
            Console.WriteLine("string:" + name);






        }

    }
}
