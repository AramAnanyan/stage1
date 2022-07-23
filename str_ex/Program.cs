using System;

namespace str_ex
{
    class Program
    {
        public static bool x(string[] arr, int f) 
        {
            int sum = 0;
            char s;
            for(int k=0; k<3; k++)
            {

                for(int j=0; j < 3; j++)
                {
                    s = ' ';
                    if (arr[f][k] == arr[f + 1][j] && s!=arr[f][k])
                    {
                        sum++;
                        s = arr[f][k];
                        j = 2;
                    }
                }
                
            }
            if (sum > 1 && f < 4)
            {
                return x(arr, f + 1);
            }else if (f == 4 && sum>1)
            {
                return true;
            }
            else return false;
        }
        static void Main(string[] args)
        {
            
            string[] arr = new string[6];
            
            for(int i=0; i < 6; i++)
            {
                arr[i] = Console.ReadLine();
            }
            
            Console.WriteLine(x(arr, 0));
        }
    }
}
