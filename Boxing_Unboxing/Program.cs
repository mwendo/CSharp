using System;
using System.Collections.Generic;

namespace Boxing_Unboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> Box = new List<object>();
            Box.Add(7);
            Box.Add(28);
            Box.Add(-1);
            Box.Add("chair");

            int sum = 0;
            for(int i = 0; i < Box.Count; i++)
            {
                if (Box[i] is int)
                {
                    int temp = (int)Box[i];
                    sum = sum + temp;
                }
                else if(Box[i] is string)
                {
                    Console.WriteLine("this is a string");
                }
                Console.WriteLine(sum);
            }
        }
    }
}