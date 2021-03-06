using System;

namespace HungryNinja
{
    class Food : IConsumable
    {
        public string Name {get;set;}
        public int Calories {get;set;}
        public bool IsSpicy {get;set;}
        public bool IsSweet {get;set;}
        public string GetInfo()
        {
            return $"{Name} (Food). Calories: {Calories}. Spicy?: {IsSpicy}, Sweet?: {IsSweet}";
        }

        public Food(string n, int c, bool spicy, bool sweet)
        {
            Name = n;
            Calories = c;
            IsSpicy = spicy;
            IsSweet = sweet;
        }
    }
}