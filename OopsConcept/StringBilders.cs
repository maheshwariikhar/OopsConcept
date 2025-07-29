using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    internal class StringBilders
    {
        // string 
        static void Main()
        {
            string str = "Hello world";
            Console.WriteLine(str);

            str = "Test";
            Console.WriteLine(str);

            string Firstname = "Mahi ";
            string Lastname = "Ikhar";
            string Fullname = Firstname + Lastname;

            Console.WriteLine(Fullname);



            ///string builder 
            StringBuilder sb = new StringBuilder();
            sb.Append("My Name ");
            sb.Append("is ");
            sb.Append("Mahi ");
            sb.Append("Badwaik");

            //insert value to string builder
            sb.Insert(11, "Ms ");

            // replace value in specific index
            sb.Replace("Badwaik", "Ikhar");



            Console.WriteLine(sb.ToString());
            sb.Clear();








        }
    }
}
