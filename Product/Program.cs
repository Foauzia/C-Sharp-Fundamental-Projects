using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System;

namespace Product
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Department { get; set; }
        public string Course { get; set; }
        public string Batch { get; set; }
        public string CourseInstructor { get; set; }

        //public int Age => DateTime.Now.Year - DOB.Year;

        public void DisplayStudentDetails()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"DOB: {DOB.ToShortDateString()}");
            //Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Gender: {Gender}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Phone: {Phone}");
            Console.WriteLine($"Address: {Address}");
            Console.WriteLine($"City: {City}");
            Console.WriteLine($"Department: {Department}");
            Console.WriteLine($"Course: {Course}");
            Console.WriteLine($"Batch: {Batch}");
            Console.WriteLine($"CourseInstructor: {CourseInstructor}");
        }


        static void Main(string[] args)
        {

            {
                Student student = new Student();
                Console.WriteLine("Enter Student ID: ");
                student.Id = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Student Name: ");
                student.Name = Console.ReadLine();

                Console.WriteLine("Enter Student DOB : ");
                student.DOB = DateTime.Parse(Console.ReadLine());

                Console.WriteLine(" Enter your Gender");
                student.Gender = Console.ReadLine();

                Console.WriteLine("Enter Student Email: ");
                student.Email = Console.ReadLine();

                Console.WriteLine("Enter your PhoneNumber");
                student.Phone = Console.ReadLine();

                Console.WriteLine("Enter Your Address");
                student.Address = Console.ReadLine();

                Console.WriteLine("Enter Your City");
                student.City = Console.ReadLine();

                Console.WriteLine("Enter Your Department");
                student.Department = Console.ReadLine();

                Console.WriteLine("Enter the course you're taking");
                student.Course = Console.ReadLine();

                Console.WriteLine("Enter which Batch of year you're");
                student.Batch = Console.ReadLine();

                Console.WriteLine("Enter the name of your  instructor");
                student.CourseInstructor = Console.ReadLine();



                /*Id = 41,
                Name = "Fozia Abako",
                DOB = new DateTime(1997, 4, 19),
                Gender = "Female",
                Email = "contact.foziaabako@gmail.com",
                Phone = "+251-972-733-872",
                Address = "Hossana, Ethiopia",
                City = "Hossana",
                Department = "Software Engineering",
                Course = "C# Programming",
                Batch = "2nd Batch",
                CourseInstructor = "Ustaz Anwar Bilcha"*/

                

                student.DisplayStudentDetails();
            }
        }
    }
}

