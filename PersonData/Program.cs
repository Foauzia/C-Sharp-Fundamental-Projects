using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace PersonData
{
    public partial class Program
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
      

        public Program(string FirstName, string LastName)
        {
            FirstName = FirstName;
            LastName = LastName;
           
        }
        public  static void Main (string[] args) {
            {
                Console.WriteLine($"{FirstName} {LastName}");
            }
        }
    }
}
