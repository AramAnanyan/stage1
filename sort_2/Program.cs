using System;

namespace sort_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 0;
            int sum = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[sum];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }


            for(int i=1; i<arr.Length-1;i++)
            {
                if (arr[i] < arr[i + 1])
                {
                    max = arr[i];
                    arr[i] = arr[i + 1];
                    arr[i + 1] = max;
                    i--;
                    continue;
                }
            }
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
