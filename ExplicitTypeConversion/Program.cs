using System;
namespace ExplicitTypeConversion
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double d = 4.4566;
            float i;
            i = (float)d;
            Console.WriteLine(i);
            Console.ReadLine();
        }
    }
}
