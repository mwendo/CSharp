using System;

namespace WizardNinjaSamurai
{
    class Ninja : Human
    {
        public Ninja(string n, int s, int i, int h) : base(n, s, i, h)
        {
            Dexterity = 175;
        }
        public override int Attack(Human target)
        {
            Random rand = new Random(0,5);
            if (rand == 0)
            {
                int dmg = Dexterity * 5 + 10;
                target.health -= dmg;
            }
            else
            {
                int dmg = Dexterity * 5;
                target.health -= dmg;
            }
            Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
            return target.Health;
        }

        public int Steal(Human target)
        {
            int stolenHealth = 5;
            target.health -= stolenHealth;
            this.health += stolenHealth;
            return target.Health;
        }
    }
}