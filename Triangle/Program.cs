using System;
namespace Triangle
{
    internal class Triangle
    {
        double Length;
        double Width;
        public void AcceptDetails()
        {
            Length = 4.5;
            Width = 8.9;
        }
        public double GetArea()
        {
            return  Length * Width;
        }
        public void Display()
        {
            Console.WriteLine("Length {0}", Length);
            Console.WriteLine("Width {0}", Width);
            Console.WriteLine("Area {0}", GetArea());
        }   
    }
        class Executable
        {
        static void Main(string[] args)
        {
            Triangle t = new Triangle();
            t.AcceptDetails();
            t.Display();
            Console.ReadLine();
        }
    }
    }
