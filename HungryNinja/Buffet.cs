using System;
using System.Collections.Generic;

namespace HungryNinja
{
    class Buffet
    {
        public List<Food> Menu;

        public Buffet()
        {
            Menu = new List<Food>()
            {
                new Food("Chicken", 600, true, false),
                new Food("Pizza", 700, false, false),
                new Food("Bagel", 400, false, false),
                new Food("Pretzel", 500, false, false),
                new Food("Apple Pie", 750, false, true),
                new Food("Vanilla Cake", 825, false, true),
                new Food("Burrito", 900, true, false),
            };
        }

        public Food Serve()
        {
            Random rand = new Random();
            return Menu[rand.Next(0, Menu.Count)];
        }
    }
}