using System;

namespace parse
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            int x;
            if (int.TryParse(a, out x))
            {
                Console.WriteLine(int.Parse(a));
            }
            else Console.WriteLine($"Attempted conversion of '{a}' failed.");
        }
    }
}
