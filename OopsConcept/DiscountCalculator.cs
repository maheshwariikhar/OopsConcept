using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    public abstract class DiscountCalculator
    {
        public abstract decimal GetDiscount(string CustomerType);
    }
    class RegularCustomer : DiscountCalculator
    {
        public override decimal GetDiscount(string CustomerType)
        {
            if (CustomerType == "Regular")
                return 0.1m;
            else if (CustomerType == "Premium")
                return 0.2m;
            else return 0;
        }
        

    }
}
