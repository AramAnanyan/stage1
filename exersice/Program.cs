using System;

namespace exersice
{
    class Program
    {
        public static int Size(int a)
        {
            int k = 0;
            while (a != 0)
            {
                a /= 10;
                k++;
            }
            return k;
        }
        static void Main(string[] args)
        {
            //1
            int max;
            int num1 = Convert.ToInt32(Console.ReadLine());
            double sum2 = 0;
            int[] num = new int[Size(num1)];
            for (int i = num.Length; i > 0; i--)
            {
                num[i] = num1 % 10;
                num1 /= 10;
            }
            for (int i = 0; i < num.Length - 1; i++)
            {
                if (num[i] < num[i + 1])
                {
                    max = num[i];
                    num[i] = num[i + 1];
                    num[i + 1] = max;
                    if (i != 0) i -= 2;
                }
            }
            for (int i = num.Length; i > 0; i--)
            {
                sum2 += num[num.Length - i] * Math.Pow(10, i);
            }
            Console.WriteLine(sum2);
        }
        }
}
