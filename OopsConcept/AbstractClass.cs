using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    public abstract class Shape1
    {
        public string Shape { get; set; }
        public abstract void CalculateArea(); // abstact method
        public void Display() // non-abstract method
        {
            Console.WriteLine($"Shape is {Shape}");

        }
    }
    public class Circle1 : Shape1
    {
        int r = 12;
        float pi = 3.13f, area;
        public override void CalculateArea()
        {
            area = pi * r * r;
            Console.WriteLine("Area of the Circle is :" + area);
        }
    }
    public class Reactangle1 : Shape1
    {
        int L = 12;
        int B = 6, area;
        public override void CalculateArea()
        {
            area = L * B;
            Console.WriteLine("Area of the Reactangle is :" + area);

        }
    }
    internal class AbstractClass
    {
        static void Main()
        {
            Circle1 c1 = new Circle1();
            c1.Shape = "Circle";
            c1.Display();
            c1.CalculateArea();
            Console.WriteLine();

            Reactangle1 R1 = new Reactangle1();
            R1.Shape = "Reactangle";
            R1.Display();
            R1.CalculateArea();

        }
    }
}