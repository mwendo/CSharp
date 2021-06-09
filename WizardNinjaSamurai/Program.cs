using System;

namespace WizardNinjaSamurai
{
    class Program
    {
        static void Main(string[] args)
        {
            Human micah = new Human("micah");
            Ninja bryce = new Ninja("bryce");
            Wizard bob = new Wizard("bob");
            Samurai jake = new Samurai("jake");
            bryce.Attack(micah);
            bryce.Steal(micah);
            bob.Attack(bryce);
            jake.Attack(micah);
        }
    }
}