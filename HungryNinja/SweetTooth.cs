using System;

namespace HungryNinja
{
    public class SweetTooth : Ninja
    {
        public SweetTooth()
        {
            
        }
        public override bool IsFull
        {
            get{ return calorieIntake > 1500; }
        }
        public override void Consume(IConsumable item)
        {
            if(IsFull == false)
            {
                calorieIntake += item.Calories + (item.IsSweet ? + 10 : + 0);
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