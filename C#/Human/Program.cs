using System;

namespace Human
{
    class Human
    {
        public string Name { get; set; }
        public int Strength { get; set; } = 3;
        public int Intelligence { get; set; } = 3;
        public int Dexterity { get; set; } = 3;
        private int Health { get; set; } = 100;

        public Human(string name)
        {
            Name = name;
        }

        public Human(string name, int strength, int intelligence, int dexterity, int health)
        {
            Name = name;
            Strength = strength;
            Intelligence = intelligence;
            Dexterity = dexterity;
            Health = health;
        }

        public void Attack(Object victum)
        {
            var Vic = (Human)victum;
            Vic.Health -= 5 * Strength;
            Console.WriteLine($"{Vic.Name} loses {5 * Strength} pts from health.");
        }

        public override string ToString()
        {
            return
                $"Name: {Name}, Strength: {Strength}, Intelligence: {Intelligence}, Dexterity: {Dexterity}, Health: {Health}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var player2 = new Human("Elena");
            var player1 = new Human("Fabian");
            Console.WriteLine(player1);
            player2.Attack(player1);
            Console.WriteLine(player1);
        }
    }
}
