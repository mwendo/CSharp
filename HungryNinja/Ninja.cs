using System;
using System.Collections.Generic;

namespace HungryNinja
{
    class Ninja
    {
        private int calorieIntake;
        public List<Food> FoodHistory;

        public Ninja()
        {
            calorieIntake = 0;
            FoodHistory = new List<Food>();
        }

        public bool IsFull
        {
            get{ return calorieIntake > 1200; }
        }

        public void Eat(Food item)
        {
            if(IsFull == false)
            {
                calorieIntake += item.Calories;
                FoodHistory.Add(item);
                Console.WriteLine($"You are being served a {item.Name}. It is spicy {item.IsSpicy}. It is sweet {item.IsSweet}.");
            }
            else
            {
                Console.WriteLine("WARNING. Your ninja is full and can't eat anymore");
            }
        }
    }
}