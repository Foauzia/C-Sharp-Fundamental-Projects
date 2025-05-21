using System;
namespace tryCatchFinally
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // int a = 0;
            int a = 5;
            try
            {
                int result = 10 / a; // Will throw DivideByZeroException
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("What the hell are you trying do? Devide by Zero?? ");
            }
            finally
            {
                Console.WriteLine("This will always execute.");
                Console.ReadLine();
            }
        }
    }
}
