using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    internal class AvgArray
    {

        static void Main()
        {
            int[] values = { 5, 7, 9, 11, 13, 15 };
            int sum = 0;
            double avg = 0;
            for (int i = 0; i < values.Length; i++)
            {
                sum += values[i];
                avg = sum / 6; // value length is: 6
            }
            Console.WriteLine("Average of Array values is:" + avg);
        }
    }
}

