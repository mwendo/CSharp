using System;
using System.Collections.Generic;

namespace HungryNinja
{
    class Program
    {
        static void Main(string[] args)
        {   
            Buffet YummyBuffet = new Buffet();
            SweetTooth bobby = new SweetTooth();
            SpiceHound micah = new SpiceHound();
            
            while(!micah.IsFull)
            {
                micah.Consume(YummyBuffet.Serve());
            }
            micah.Consume(YummyBuffet.Serve());

            while(!bobby.IsFull)
            {
                bobby.Consume(YummyBuffet.Serve());
            }

            if(micah.ConsumptionHistory.Count > bobby.ConsumptionHistory.Count)
            {
                Console.WriteLine("Micah consumed more items than Bobby.");
                Console.WriteLine($"Micah consumed {micah.ConsumptionHistory.Count} items.");
            }
            else
            {
                Console.WriteLine("Bobby consumed more items than Micah.");
                Console.WriteLine($"Bobby consumed {bobby.ConsumptionHistory.Count} items");
            }
        }
    }
}