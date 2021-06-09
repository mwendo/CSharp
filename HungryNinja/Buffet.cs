using System;
using System.Collections.Generic;

namespace HungryNinja
{
    class Buffet
    {
        public List<IConsumable> Menu;

        public Buffet()
        {
            Menu = new List<IConsumable>()
            {
                new Food("Chicken", 600, true, false),
                new Food("Pizza", 700, false, false),
                new Food("Bagel", 400, false, false),
                new Food("Pretzel", 500, false, false),
                new Food("Apple Pie", 750, false, true),
                new Food("Vanilla Cake", 825, false, true),
                new Food("Burrito", 1000, true, false),
                new Drink("Water", 0, false, false),
                new Drink("Iced tea", 110, false, true),
                new Drink("Coke", 140, false, true)
            };
        }

        public IConsumable Serve()
        {
            Random rand = new Random();
            return Menu[rand.Next(0, Menu.Count)];
        }
    }
}