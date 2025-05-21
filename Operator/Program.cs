namespace Operator
{
    internal class Program
    {


        static int FindMaxNumber(int a, int b, int c)
        {
            int result = 0;
            if (a > b && a > c) {
                result = a;

            }
            if (b > c && b > a)
            {
                result = b;
            }
            if (c > a && c > b)
            {
                result = c;
            }
            if ((a == b  && b==  c  && a==c))
                {
                result = 1;
                }
            return result;
            
        }
            static void Main(string[] args)
        {
            DateTime dateTime = new DateTime(1997, 10, 2);
           
            int age = DateTime.Now.Year - dateTime.Year;

            Console.WriteLine($"Age of the student born in {dateTime} is: {age}");

            int num1 = 32, num2 = 25, num3= 2 , sum , pro , que , diff , rem;

            sum = num1 + num2;
            pro = num1 * num2;
            que = num1 / num2;
            diff = num1 - num2;
            rem = num1 % num3;

            Console.WriteLine($" the value of {nameof(num1)} is {num1} , num1++: is {num1++} , num1--: is {num1--}," +
                $"++num1 is {++num1}, sum is {sum}, pro is {pro}");

            Console.WriteLine($" the value of {nameof(num2)} is {num2} , num2++: is {num2++} , num2--: is {num2--}," +
                $"++num2 is {++num2}, sum is {sum}, pro is {pro}");

            Console.WriteLine($" the value of {nameof(num3)} is {num3} , num3++: is {num3++} , num3--: is {num3--}," +
                $"++num3 is {++num3}, sum is {sum}, pro is {pro}");

            Console.WriteLine(Program.FindMaxNumber(12, 13, 14));
            Console.WriteLine(Program.FindMaxNumber(12, 18, 14));
            Console.WriteLine(Program.FindMaxNumber(12, 12, 12));
            Console.ReadLine();


            //var x = 10;
            //Console.WriteLine("what do you want to do with numbers");
            //string operation = Console.ReadLine();
            //string choice = Console.ReadLine().Substring(0,1);
            //var choices = operation.ToCharArray()[0]; 

            // int result = (choice === 'A' || choice = ()););
        }
    }
}
