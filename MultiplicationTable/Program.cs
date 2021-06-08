using System;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,,] multiplicationTable = new int[10, 10];

            for(int i = 0; i < multiplicationTable.Length; i++)
            {
                Console.WriteLine(multiplicationTable[i]);
            }
        }
    }
}
