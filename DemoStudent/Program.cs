using System;

namespace DemoStudent
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

        public int Age => DateTime.Now.Year - DOB.Year;

        public void DisplayStudentDetails()
        {
            Console.WriteLine($"\n--- Student Details ---");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"DOB: {DOB.ToShortDateString()}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Gender: {Gender}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Phone: {Phone}");
            Console.WriteLine($"Address: {Address}");
            Console.WriteLine($"City: {City}");
            Console.WriteLine($"Department: {Department}");
            Console.WriteLine($"Course: {Course}");
            Console.WriteLine($"Batch: {Batch}");
            Console.WriteLine($"Course Instructor: {CourseInstructor}");
        }

        static void Main(string[] args)
        {
            Student student = new Student();

            Console.Write("Enter Student ID: ");
            student.Id = int.Parse(Console.ReadLine());

            Console.Write("Enter Student Name: ");
            student.Name = Console.ReadLine();

            Console.Write("Enter Student DOB (yyyy-mm-dd): ");
            student.DOB = DateTime.Parse(Console.ReadLine());

            Console.Write("Enter your Gender: ");
            student.Gender = Console.ReadLine();

            Console.Write("Enter Student Email: ");
            student.Email = Console.ReadLine();

            Console.Write("Enter your Phone Number: ");
            student.Phone = Console.ReadLine();

            Console.Write("Enter Your Address: ");
            student.Address = Console.ReadLine();

            Console.Write("Enter Your City: ");
            student.City = Console.ReadLine();

            Console.Write("Enter Your Department: ");
            student.Department = Console.ReadLine();

            Console.Write("Enter the course you're taking: ");
            student.Course = Console.ReadLine();

            Console.Write("Enter which Batch of year you're in: ");
            student.Batch = Console.ReadLine();

            Console.Write("Enter the name of your instructor: ");
            student.CourseInstructor = Console.ReadLine();

           // Console.Clear();

            student.DisplayStudentDetails();

            Console.ReadLine();
        }
    }
}
