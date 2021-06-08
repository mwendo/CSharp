using System;
using System.Collections.Generic;

namespace Puzzles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(", ",RandomArray()));
            TossCoin();
            Console.WriteLine(TossMultipleCoins(10));
            Names();
        }


        // Function that creates random array
        public static int[] RandomArray()
        {
            Random rand = new Random();
            int[] ranArr = new int[10];
            int min = 26;
            int max = 0;
            int sum = 0;

            for (int i = 0; i<ranArr.Length; i++)
            {
                ranArr[i] = rand.Next(5,26);
                if(ranArr[i] < min)
                {
                    min = ranArr[i];
                }
                else if(ranArr[i] > max)
                {
                    max = ranArr[i];
                }
                sum += ranArr[i];
            }
            Console.WriteLine("Min: " + min);
            Console.WriteLine("Max: " + max);
            Console.WriteLine("Sum: " + sum);
            return ranArr;
        }

        // Function to simulate a coin toss
        public static string TossCoin()
        {
            Random rand = new Random();
            string result = "";
            int coin = rand.Next(0,2);
            if(coin == 0)
            {
                result = "heads";
            }
            else if(coin == 1)
            {
                result = "tails";
            }
            
            Console.WriteLine(result);
            return result;
        }


        // Function to simulate multiple coin tosses
        public static double TossMultipleCoins(int num)
        {
            double headsCounter = 0;
            double tailsCounter = 0;
            double ratio = 0;

            for(int i = 0; i <= num; i++)
            {
                string result = TossCoin();

                if(result == "heads")
                {
                    headsCounter += 1;
                }

                else if(result == "tails")
                {
                    tailsCounter += 1;
                }
            }
            ratio = headsCounter / num;
            // double ActualRatio = ratio;

            return ratio;
        }


        // Names function
        public static List<string> Names()
        {
            List<string> people = new List<string>();
            people.Add("Todd");
            people.Add("Tiffany");
            people.Add("Charlie");
            people.Add("Geneva");
            people.Add("Sydney");


            Random r = new Random();
            for(int n = people.Count -1; n > 0; n--)
            {
                int k = r.Next(n+1);
                string temp = people[n];
                people[n] = people [k];
                people[k] = temp;
            }

            for(int i = 0; i < people.Count; i++)
            {
                if(people[i].Length < 5)
                {
                    people.Remove(people[i]);
                }
            }

            Console.WriteLine(people);
            return people;
        }
    }
}