using System;

namespace stage1
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 0, k = 0, x=0;
            int sum=Convert.ToInt32(Console.ReadLine());
            int[] arr= new int[sum];
            for(int i=0; i<arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for(int i=0; i<arr.Length; i++)
            {
                for(int j=i; j<arr.Length; j++)
                {
                    if (arr[j] > max)
                    {
                        max = arr[j];
                        k = j;
                    }
                }
                x = arr[i];
                arr[i] = max;
                arr[k] = x;
                max = 0;
                k = 0;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
