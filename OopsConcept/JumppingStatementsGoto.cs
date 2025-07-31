using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    internal class JumppingStatementsGoto
    {
        static void Main()
        {
            int age;
            Console.WriteLine("Enter Your Valid age...");
        startloop:
            age = Convert.ToInt32(Console.ReadLine());

            if (age > 0 && age < 120)
            {
                Console.WriteLine($"Your Age is {age}");
                goto startloop;
            }
            else
            {
                Console.WriteLine("Invalid Age.Try again");


            }
        }
    }
}
