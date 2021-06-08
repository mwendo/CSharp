using System;

namespace Human
{
    class Program
    {
        static void Main(string[] args)
        {
            Human micah = new Human("micah");
            Human dylan = new Human("dylan");
            micah.Attack(dylan);
        }
    }

    class Human
    {
        // Fields for Human
        public string Name;
        public int Strength;
        public int Intelligience;
        public int Dexterity;
        private int health;

        public int Health
        {
            get { return health; }
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

        public int Attack(Human target)
        {
            target.health -= 5 * this.Strength;
            Console.WriteLine(target.Health);
            return target.Health;
        }
    }
}
