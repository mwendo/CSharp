using System;

namespace WizardNinjaSamurai
{
    public class Wizard : Human
    {
        public Wizard(string name) : base("wizard", 3, 25, 3, 50)
        {
            Name = name;
        }

        public override int Attack(Human target)
        {
            int dmg = 5 * this.Intelligience;
            target.Health -= dmg;
            this.Health += dmg;
            Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
            return target.Health;
        }

        public int Heal(Human target)
        {
            int heal = 10 * Intelligience;
            target.Health += heal;
            Console.WriteLine($"{Name} healed {target.Name} for {heal} points!");
            return target.Health;
        }
    }
}