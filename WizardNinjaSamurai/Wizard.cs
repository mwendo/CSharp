using System;

namespace WizardNinjaSamurai
{
    class Wizard : Human
    {
        public Wizard(string n, int s, int d) : base(n, s, d)
        {
            health = 50;
            Intelligience = 25;
        }

        public override int Attack(Human target)
        {
            int dmg = 5 * this.Intelligience;
            target.health -= dmg;
            this.health += dmg;
            Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
            return target.Health;
        }

        public int Heal(Human target)
        {
            int heal = 10 * Intelligience;
            target.health += heal;
            Console.WriteLine($"{Name} healed {target.Name} for {heal} points!");
            return target.Health;
        }
    }
}