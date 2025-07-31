using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    internal class ControlFlowStatementIfElse1
    {

        static void Main()
        {
            Console.WriteLine("Enter Number");

            //Read and convert input to integer
            int num = Convert.ToInt32(Console.ReadLine());
            if (num > 0)
            {
                Console.WriteLine("The number is positive");

            }
            else if (num < 0)
            {
                Console.WriteLine("The number is Negative");

            }
            else
            {
                Console.WriteLine("The number is Zero");
            }

        }
    }
}

