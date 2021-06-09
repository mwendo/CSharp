using System;

namespace HungryNinja
{
    public class SpiceHound : Ninja
    {
        public SpiceHound()
        {
            
        }
        public override bool IsFull
        {
            get {return calorieIntake > 1200; }
        }

        public override void Consume(IConsumable item)
        {
            if(IsFull == false)
            {
                calorieIntake += item.Calories + (item.IsSpicy ? - 5 : + 0);
                ConsumptionHistory.Add(item);
                Console.WriteLine($"You are being served a {item.Name}. It is spicy {item.IsSpicy}. It is sweet {item.IsSweet}.");
            }
            else
            {
                Console.WriteLine("WARNING. Your ninja is full and can't eat or drink anymore.");
            }
        }
    }
}