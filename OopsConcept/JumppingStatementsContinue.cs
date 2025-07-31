using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    internal class JumppingStatementsContinue
    {
        static void Main()
        {
            Console.WriteLine("Numbers from 1 to 20 Those Divisible by 3");
            for (int i = 0; i <= 20; i++)
            {
                if (i % 3 == 0)
                {
                    continue;
                }
                Console.WriteLine(i);
            }

        }
    }
}
