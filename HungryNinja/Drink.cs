using System;

namespace HungryNinja
{
    public class Drink : IConsumable
    {
        public string Name {get;set;}
        public int Calories {get;set;}
        public bool IsSpicy {get;set;}
        public bool IsSweet {get;set;}

        public string GetInfo()
        {
            return $"{Name} (Drink). Calories: {Calories}. Spicy?: {IsSpicy}, Sweet?: {IsSweet}";
        }

        public Drink(string n, int c, bool spicy, bool sweet)
        {
            Name = n;
            Calories = c;
            IsSpicy = spicy;
            IsSweet = sweet;
        }
    }
}