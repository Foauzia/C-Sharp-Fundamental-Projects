namespace program
{
    internal class Program
    {
        static void Main(string[] args)
        {

           /* int firstNum = 10;
            int secondNum = 3;

            Console.WriteLine(firstNum / secondNum);
            
            double age = 23;
            age/=10;
            Console.WriteLine(age);

            string name = " Aba";
            name += " is Programming";
            Console.WriteLine(name);

            char batch = 'A';
            bitch += 'B';
            Console.WriteLine(batch);

            int i = 0;
            Console.WriteLine(++i);
            Console.WriteLine(i);*/


            int x, y, z;

             bool  value = true;

            bool isMale = false;
            Console.WriteLine(isMale);


            string name = "Aba";
            char letter = 'f';
            Console.Write("Your name is:");
            Console.WriteLine(name);

            Console.Write(letter);
            Console.WriteLine();

            string textAge = "-23";
            int  age = Convert.ToInt32(textAge);
            Console.WriteLine(age);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);

            string bigText = "6000000000";
            long numberL = Convert.ToInt64(bigText);
            Console.WriteLine(numberL);
            Console.WriteLine(long.MaxValue);
            Console.WriteLine(long.MinValue);

            string doubleText = "56.097";
            double d1 = Convert.ToDouble(doubleText);
            Console.WriteLine(d1);
            Console.WriteLine(double.MaxValue);
            Console.WriteLine(double.MinValue);

            string decimalText = "40.99";
            decimal d7 = Convert.ToDecimal(decimalText);
            Console.WriteLine(d7);
            Console.WriteLine(decimal.MinValue);
            Console.WriteLine(decimal.MaxValue);

            string precise = "67.000000000009";
            float f2 = Convert.ToSingle(precise);
            Console.WriteLine(f2);
            Console.WriteLine(float.MinValue);
            Console.WriteLine(float.MaxValue);

            Console.ReadLine();
            Console.WriteLine("Hello, World!");
        }
    }
}
