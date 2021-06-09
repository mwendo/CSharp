using System;

namespace WizardNinjaSamurai
{
    public class Human
    {
        // Fields for Human
        public string Name;
        public int Strength;
        public int Intelligience;
        public int Dexterity;
        protected int health;

        public int Health
        {
            get { return health; }
            set { health = value; }
        }

        public Human(string n)
        {
            Name = n;
            Strength = 3;
            Intelligience = 3;
            Dexterity = 3;
            health = 100;
            Console.WriteLine($"My name is {Name}. My strength is {Strength}. My intelligience is {Intelligience}. My dexterity is {Dexterity}. And i have {health} health.");
        }

        public Human(string n, int s, int i, int d, int h)
        {
            Name = n;
            Strength = s;
            Intelligience = i;
            Dexterity = d;
            health = h;
        }

        public virtual int Attack(Human target)
        {
            target.health -= 3 * this.Strength;
            return target.Health;
        }
    }
}
