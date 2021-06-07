using System;
using System.Collections.Generic;

namespace CollectionsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3 Basic Arrays
            int[] numberArray = new int[10] {0,1,2,3,4,5,6,7,8,9};
            string[] nameArray = new string[4] {"Tim", "Martin", "Nikki", "Sara"};
            bool[] stupidArray = new bool[10] {true, false, true, false, true, false, true, false, true, false};
            for(int i = 0; i < stupidArray.Length; i++)
            {
                Console.WriteLine(stupidArray[i]);
            }


            // List of Flavors
            List<string> flavors = new List<string>();
            flavors.Add("pistachio");
            flavors.Add("vanilla");
            flavors.Add("rocky road");
            flavors.Add("chocolate");
            flavors.Add("strawberry");

            Console.WriteLine(flavors.Count);
            Console.WriteLine(flavors[2]);

            flavors.RemoveAt(2);

            Console.WriteLine(flavors[2]);
            Console.WriteLine(flavors.Count);


            // User Info Dictionary
            Dictionary<string,string> users = new Dictionary<string,string>();
            users.Add("Micah", "pistachio");
            users.Add("Jake", "vanilla");
            users.Add("Bryce", "chocolate");
            users.Add("Mac", "rocky road");
            users.Add("Dylan", "strawberry");

            foreach(KeyValuePair<string,string> person in users)
            {
                Console.WriteLine(person.Key + " - " + person.Value);
            }
        }
    }
}