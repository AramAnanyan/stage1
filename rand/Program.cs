using System;

namespace rand
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            Random rnd = new Random();
            a=rnd.Next(100000, 200000);
            Console.WriteLine(a*22/100);
        }
    }
}
