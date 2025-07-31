using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    internal class LoopingStatementLoops
    {
        static void Main()
        {
            //for loop
            Console.WriteLine("---- For Loop Statement----");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Student Number:" + i);
            }

            //While loop: Entry Control loop
            Console.WriteLine("----while Loop Statement----");
            int j = 1;
            while (j <= 10)
            {
                Console.WriteLine("Student Number:" + j);
                j++;
            }

            //Do while loop: exit control loop
            Console.WriteLine("---- Do-While Loop Statement----");
            int k = 1;
            do
            {
                Console.WriteLine("Student Number :" + k);
                k++;
            }
            while (k <= 10);
        }
    }
}
