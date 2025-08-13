using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    public class EmailService
    {
        public void SendEmail(string email)
        {
            Console.WriteLine($"Welcome Email Send to:{email}");
        }
    }
}
