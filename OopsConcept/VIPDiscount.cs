using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    public class VIPDiscount:DiscountCalculator
    {
        public override decimal GetDiscount(string CustomerType)
        {
            if (CustomerType == "VIP")
            {
                return 0.3m;
            }
            else
            {
                RegularCustomer R1 = new RegularCustomer();
                return R1.GetDiscount(CustomerType);
            }
        }
    }
}
