using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
namespace Profile
{
    partial class Program
    {
        public String FirstName
        {
            get; set;

        }
        public String LastName
        {
            get; set;
        }
        public String Title { get; set; }
        public String Address { get; set; }
        public String Phone { get; set; }
        public String Email { get; set; }

        public Program(String fname, String lname , String address , String email , String title , string phone)
        {
            FirstName = fname;
            LastName = lname;
            Title = title;
            Email = email;
            Address = address;
            Phone = phone;

        }
        public void PrintName()
        {
            Console.WriteLine($"{FirstName} {LastName} {Address} {Email} {Title} {Phone}");
        }
        /*static void Main (string[] args)
        {
            Program p = new Program("Fozia", "Abako");
            p.PrintName();
        }
    }*/
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first name:");
            string FirstName = Console.ReadLine();
            Console.WriteLine("Enter your last name:");
            string LastName = Console.ReadLine();
            Console.WriteLine("Enter your address:");
            string address = Console.ReadLine();
            Console.WriteLine("Enter your email:");
            string email = Console.ReadLine();
            Console.WriteLine("Enter your title:");
            string title = Console.ReadLine();
            Console.WriteLine("Enter your phone number:");
            string phone = Console.ReadLine();

            Program p = new Program(FirstName, LastName, address , email, title , phone );
            p.PrintName();
            Console.ReadLine();
        }
    }
}
