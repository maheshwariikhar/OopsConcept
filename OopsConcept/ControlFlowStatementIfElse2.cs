using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    internal class ControlFlowStatementIfElse2
    {
        static void Main()
        {
            Console.WriteLine("Enter your Marks:");
            //Read and convert input to integer
            int grade = Convert.ToInt32(Console.ReadLine());

            if (grade >= 90)
            {
                Console.WriteLine("Your Grade is: A");

            }
            else if (grade >= 80)
            {
                Console.WriteLine("Your Grade is: B");
            }
            else if (grade >= 70)
            {
                Console.WriteLine("Your Grade is: C");
            }
            else if (grade >= 60)
            {
                Console.WriteLine("Your Grade is: D");
            }
            else if (grade >= 50)
            {
                Console.WriteLine("Your Grade is: E");
            }
            else
            {
                Console.WriteLine("Your Grade is: F");


            }

        }
    }
}
