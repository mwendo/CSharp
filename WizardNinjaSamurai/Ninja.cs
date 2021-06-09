using System;

namespace WizardNinjaSamurai
{
    public class Ninja : Human
    {

        Random rand = new Random();
        public Ninja(string name) : base("ninja", 3, 3, 175, 100)
        {
            Name = name;
        }
        public override int Attack(Human target)
        {
            int chance = rand.Next(0,5);
            if (chance == 0)
            {
                int dmg = Dexterity * 5 + 10;
                target.Health -= dmg;
                Console.WriteLine($"{Name} attacked you for {dmg} damage!");
            }
            else
            {
                int dmg = Dexterity * 5;
                target.Health -= dmg;
                Console.WriteLine($"{Name} attacked you for {dmg} damage!");
            }
            return target.Health;
        }

        public int Steal(Human target)
        {
            int stolenHealth = 5;
            target.Health -= stolenHealth;
            this.Health += stolenHealth;
            Console.WriteLine($"{Name} stole {stolenHealth} of your health");
            return target.Health;
        }
    }
}