using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

namespace StudentProfile
{
    internal class Program
    {
        
        public string FirstName { get; set; }
        public string FatherName { get; set; }
        public int Age { get; set; }
        public string KinName { get; set; }

        public void DisplayProfile()
        {
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"FirstName : {FirstName}");
            Console.WriteLine($"FatherName : {FatherName}");
            Console.WriteLine($"KinName : {KinName}");
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("Enter Your First Name:");
            string FirstName = Console.ReadLine();
            Console.WriteLine("Enter Your Father Name ");
            string FatherName = Console.ReadLine();
            Console.WriteLine("Enter Your Age");
            int Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Your Kin Name");
            string KinName = Console.ReadLine();
            p.DisplayProfile();
        }
    }
}
