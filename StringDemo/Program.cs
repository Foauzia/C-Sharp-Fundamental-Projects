namespace StringDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string hukm = " second batch  ";

            Console.WriteLine(hukm.Length);
            Console.WriteLine(hukm.ToUpper());
            Console.WriteLine(hukm.Trim());
            Console.WriteLine(hukm.ToLower());
            Console.WriteLine(hukm.TrimStart());
            Console.WriteLine(hukm.TrimEnd());
            Console.WriteLine(hukm.Contains("batch"));
            Console.WriteLine(hukm.IndexOf("batch"));
            Console.WriteLine(hukm.LastIndexOf("batch"));
            Console.WriteLine(hukm.Substring(0, 6));
            Console.WriteLine(hukm.Substring(6, 5));
            Console.WriteLine(hukm.Replace("batch", "first"));
            Console.WriteLine(hukm.Split(' ')[0]);
            Console.WriteLine(hukm.Split(' ')[1]);
            Console.WriteLine(hukm.Split(' ')[2]);
            Console.WriteLine(hukm.Split(' ')[3]);
            Console.WriteLine(hukm.Split(' ')[4]);
            Console.WriteLine(hukm.Split(','));
            Console.WriteLine(hukm.ToCharArray());

            Console.WriteLine("Hello, World!");
        }
    }
}
