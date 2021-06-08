using System;
using System.Collections.Generic;

namespace HungryNinja
{
    class Program
    {
        static void Main(string[] args)
        {   
            Buffet YummyBuffet = new Buffet();
            Ninja micah = new Ninja();
            
            while(!micah.IsFull)
            {
                micah.Eat(YummyBuffet.Serve());
            }
        }
    }
}