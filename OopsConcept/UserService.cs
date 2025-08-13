using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    public class UserService
    {
        public void Register(string username, string password, string email)
        {
            DataValidator validator = new DataValidator();
            validator.Validate(username, password);

            UserRepositorycs  datasave = new UserRepositorycs();
            datasave.DataSaving(username, password, email);

            EmailService emailsend = new EmailService();
            emailsend.SendEmail(email);
        }
        public static void Main(string[] args)
        {
            UserService service = new UserService();
            service.Register("Mahi", "Password", "Mahiikhar@gmail.com");

        }

    }
}
