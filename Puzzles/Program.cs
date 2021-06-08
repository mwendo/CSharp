using System;

namespace Puzzles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(", ",RandomArray()));
        }
        public static int[] RandomArray()
        {
            Random rand = new Random();
            int[] ranArr = new int[10];
            int min = 0;
            int max = ranArr[0];

            for (int i = 0; i<ranArr.Length; i++)
            {
                ranArr[i] = rand.Next(5,26);
                if(ranArr[i] < min)
                {
                    min = ranArr[i];
                    Console.WriteLine(min);
                }
            }
            return ranArr;
        }
    }
}