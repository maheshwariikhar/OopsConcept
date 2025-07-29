using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    internal class EnumAssign
    {
        enum Years
        {
            January,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            Sepetember,
            Octomber,
            November,
            December

        }
        static void Main()
        {
            Years Month = Years.January;
            switch (Month)
            {
                case Years.January:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("January is the Starting Month of Year");
                    break;
                case Years.February:
                    Console.WriteLine("2nd Month of Year");
                    break;
                case Years.March:
                    Console.WriteLine("3rd Month of Year");
                    break;
                case Years.April:
                    Console.WriteLine("4th Month of Year");
                    break;
                case Years.May:
                    Console.WriteLine("5th Month of Year");
                    break;
                case Years.June:
                    Console.WriteLine("6th Month of Year");
                    break;
                case Years.July:
                    Console.WriteLine("7th Month of Year");
                    break;
                case Years.August:
                    Console.WriteLine("8th Month of Year");
                    break;
                case Years.Sepetember:
                    Console.WriteLine("9th Month of Year");
                    break;
                case Years.Octomber:
                    Console.WriteLine("10th Month of Year");
                    break;
                case Years.November:
                    Console.WriteLine("11th Month of Year");
                    break;
                case Years.December:
                    Console.WriteLine("December is the Ending Month of Year");
                    break;

            }
            if (Month == Years.January || Month == Years.December)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("December is the Ending Month Of Year");
            }

        }
    }
}
