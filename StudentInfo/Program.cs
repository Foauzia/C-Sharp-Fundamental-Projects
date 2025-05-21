using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks;


namespace StudentInfo
{
    internal class Program
    {
        public string name { get; set; }
        public int age { get; set; }

        public void displayInfo()
        {
            Console.WriteLine($"Name: {name}, Age: {age}");

        }
        static void Main(string[] args)
        {
            Program info = new Program();
            info.name = "Fozia Abako";
            info.age = 27; 
            info.displayInfo();
            Console.ReadLine();
        }
    }
}
