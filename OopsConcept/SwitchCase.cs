using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    internal class SwitchCase
    {
        static void Main()

        {
            Console.WriteLine("----Food Menu----");
            Console.WriteLine("1. Burger");
            Console.WriteLine("2. Pizza");
            Console.WriteLine("3. Salad");
            Console.WriteLine("Enter Your Choice(1-3):");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("You Selected Burger:\n Price:RS.90");
                    break;
                case 2:
                    Console.WriteLine("You Selected Pizza:\n Price:RS.250");
                    break;
                case 3:
                    Console.WriteLine("You Selected Salad:\n Price:RS.40");
                    break;
                default:
                    Console.WriteLine("Please Enter Your correct Choice");
                    break;

            }




        }
    }
}


