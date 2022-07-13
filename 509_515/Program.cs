using System;

namespace _509_515
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            
            char[,] arr = new char[n,n];

            for(int i=0; i<n; i++)
            {
                for(int j=0; j<n; j++)
                {
                    arr[i, j] = Convert.ToChar(Console.ReadLine());
                }
            }
            int x = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if ( arr[i, j] == 'a')
                        x++;
                }
            }
            Console.WriteLine(x);

        }
    }
}
