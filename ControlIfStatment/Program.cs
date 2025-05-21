using System.Reflection;
namespace ControlIfStatment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double heightInMetres = 1.88;
           WriteLine($"The variable {nameof(heightInMetres)} has the value  \r\n {heightInMetres}.");
           // string firstName = "Bob"; // Assigning literal strings.
            //string lastName = "Smith";
           // string phoneNumber = "(215) 555-4256";
            // Assigning a string returned from the string class constructor.
            string horizontalLine = new('-', count: 74); // 74 hyphens.
                                                        
            string address = GetAddressFromDatabase(id: 563);
            // Assigning an emoji by converting from Unicode.
            string grinningEmoji = char.ConvertFromUtf32(0x1F600);
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string grinningEmojii = char.ConvertFromUtf32(0x1F600);
            Console.WriteLine(grinningEmojii);
            { 
            }
        }
    }
}
            
