using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    internal class RefParameter
    {
        static void IncrementValue(ref int number)
        {
            number++;
        }
        static void Main()
        {
            int incnumber = 5;
            Console.WriteLine("Befor Increment Ref Parameter:" + incnumber);

            // Calling method
            IncrementValue(ref incnumber);
            Console.WriteLine("After Increment Out Parameter:" + incnumber);
        }

    }
}
