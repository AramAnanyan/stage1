using System;

namespace error_enum
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double num1, num2;
            int error = 0;
            char x;
            Console.WriteLine("only integer type");
            Console.WriteLine("enter first number");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter one of these symbols - '+' '-' '*' '/'");
            x = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("enter second number");
            num2 = Convert.ToDouble(Console.ReadLine());

            if(num1!=(int)num1 || num2 != (int)num2)
            {
                
                //var a = MyClass.Error.only_integer;
                //Console.WriteLine(a);
                Console.Write(MyClass.Error.only_integer);
                Console.WriteLine(". error number - "+(int)MyClass.Error.only_integer);
                error = 1;
            }
            if (num2 == 0 && x=='/')
            {
                Console.Write(MyClass.Error.div_by_0);
                Console.WriteLine(". error number - " + (int)MyClass.Error.div_by_0);
                error = 1;
            }
            if(x!='+' && x != '-' && x != '*' && x != '/')
            {
                Console.Write(MyClass.Error.wrong_symbol);
                Console.WriteLine(". error number - " + (int)MyClass.Error.wrong_symbol);
                error = 1;
            }
            if (error != 1)
            {
                Console.Write("answer: ");
                switch (x)
                {

                    case '+':
                        Console.WriteLine(num1+num2);
                        break;
                    case '-':
                        Console.WriteLine(num1 - num2);
                        break;
                    case '*':
                        Console.WriteLine(num1 * num2);
                        break;
                    case '/':
                        Console.WriteLine(num1 / num2);
                        break;
                }
            }
        }
    }
}
