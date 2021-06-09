using System;

namespace WizardNinjaSamurai
{
    public class Samurai : Human
    {
        public Samurai(string name) : base("samurai", 3, 3, 3, 200)
        {
            Name = name;
        }

        public override int Attack(Human target)
        {
            if(target.Health < 50)
            {
                return target.Health = 0;
                Console.WriteLine($"{Name} attacked and killed you.");
            }
            else
            {
                Console.WriteLine($"{Name} attacked you");
                return this.Attack(target);
            }
        }

        public int Meditate()
        {
            this.Health = 200;
            return this.Health;
        }
    }
}