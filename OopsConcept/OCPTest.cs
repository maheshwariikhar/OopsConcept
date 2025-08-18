using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    public class OCPTest
    {
        static void Main()
        {
            Console.WriteLine("Enter Customer Type");
            string CustomerType = Console.ReadLine();
            VIPDiscount v1 = new VIPDiscount();
            decimal Discount = v1.GetDiscount(CustomerType);
            Console.WriteLine("Discount=" + Discount);
        }
        
    }
}
