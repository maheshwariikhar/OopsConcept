using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    //create interfaces
    public interface IPrint
    {
        void Print();
    }
    public interface IScan
    {
        void Scan();
    }
    public interface IFax
    {
        void Fax();
    }
    // Create device Classes
    public class Printer : IPrint
    {
        public void Print()
        {
            Console.WriteLine("Printer: Printing a documents.....");
        }
    }
    public class Scanner : IScan
    {
        public void Scan()
        {
            Console.WriteLine("Scanner: Scanning a documents.....");
        }
    }
    public class MultiFunctionDevice : IPrint, IScan, IFax
    {
        public void Print()
        {
            Console.WriteLine("MultiFunctionDevice: Printing a document...");
        }
        public void Scan()
        {
            Console.WriteLine("MultiFunctionDevice: Scanning a document...");
        }
        public void Fax()
        {
            Console.WriteLine("MultiFunctionDevice: Sending a Fax...");
        }
    }

    internal class InterfaceSegrationPrinciple
    {
        static void Main()
        {
            IPrint printer = new Printer();
            printer.Print();

            IScan scanner = new Scanner();
            scanner.Scan();

            MultiFunctionDevice md = new MultiFunctionDevice();
            md.Print();
            md.Scan();
            md.Fax();

            Console.ReadLine();
        }
    }
}
