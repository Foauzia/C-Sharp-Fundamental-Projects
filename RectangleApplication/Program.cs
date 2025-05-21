using System;
namespace RectangleApplication
{
    internal class Rectangle
    {
        double Length;
        double Width;

        public void AcceptDetails()
        {
            Length = 4.5;
            Width = 7.8;
        }
        public double GetArea()
        {
            return Length * Width;
        }
        public void Display()
        {
            Console.WriteLine("Length: {0}" ,Length);
            Console.WriteLine("Width:{0}" , Width);
            Console.WriteLine("Area:{0}" ,GetArea());

        }
        
    }
    class Executable
    {
         static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.AcceptDetails();
            r.Display();
            Console.WriteLine($"The Area of Rectangle is " $);
            Console.ReadLine();

        }
    }
}
