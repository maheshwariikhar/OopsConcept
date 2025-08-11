using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    internal class OutParameter
    {
        // method with two parameter
        static void InitializeValues(out int number, out string str)
        {
            number = 22;
            str = "Mahi";
        }
        static void Main()
        {
            //calling method with out para
            InitializeValues(out int number, out string str);
            Console.WriteLine("Out Parameter Value:"+ number );
            Console.WriteLine("Out Parameter String:" + str);
        }
    }
}
