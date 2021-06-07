using System;

namespace Fundamentals_1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int m = 1; m< 256; m++)
            {
                Console.WriteLine(m);
            }

            for (int n=1; n<101; n++)
            {
                if(n % 3 == 0 || n % 5 == 0)
                {
                    Console.WriteLine(n);
                }
            }

            for (int x=1; x<101; x++)
            {
                if(x % 3 == 0 && x % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if(x % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (x % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
            }

            int i = 1;
            while(i<256)
            {
                Console.WriteLine(i);
                i = i + 1;
            }

            int j = 1;
            while(j<101)
            {
                if(j % 3 == 0 || j % 5 == 0)
                {
                    Console.WriteLine(j);
                }
                j = j + 1;
            }

            int t = 1;
            while(t<101)
            {
                if(t % 3 == 0 && t % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (t % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (t % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                t = t + 1;
            }
        }
    }
}