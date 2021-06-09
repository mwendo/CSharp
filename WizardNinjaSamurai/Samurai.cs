namespace WizardNinjaSamurai
{
    class Samurai : Human
    {
        public Samurai(string n, int s, int i, int d) : base(n, s, i ,d)
        {
            health = 200;
        }

        public override int Attack(Human target)
        {
            int dmg = base.Attack;
            if(target.health < 50)
            {
                target.health = 0;
            }
            else
            {
                target.health -= dmg;
            }
            Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
            return target.Health;
        }

        public int Meditate()
        {
            this.health = 200;
            return this.Health;
        }
    }
}