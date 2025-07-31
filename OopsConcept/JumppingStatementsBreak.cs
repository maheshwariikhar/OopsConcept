using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    internal class JumppingStatementsBreak
    {
        static void Main()
        {
            int sum = 0;
            while (true)
            {
                Console.WriteLine("Enter a Number(Negative to Stop)");
                int num = Convert.ToInt32(Console.ReadLine());
                if (num < 0)
                {
                    break; //exit loop
                }
                sum += num;
            }
            Console.WriteLine("Sum of all Entered Numbers is:" + sum);
        }

    }
}
