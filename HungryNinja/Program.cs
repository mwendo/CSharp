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
            micah.Eat(YummyBuffet.Serve());
            micah.Eat(YummyBuffet.Serve());
            micah.Eat(YummyBuffet.Serve());
        }
    }
}