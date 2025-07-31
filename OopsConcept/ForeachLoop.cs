using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    internal class ForeachLoop
    {
        static void Main()
        {
            string[] mobilebrand = { "Samsung", "Apple", "OnePlus", "oppo", "Realme", "Redmi", "Vivo", "Nokia", "Infinix", "Motorola" };

            Console.WriteLine("List of Mobile Brands");
            foreach (string brand in mobilebrand)
            {
                Console.WriteLine(brand);
            }



        }
    }
}
