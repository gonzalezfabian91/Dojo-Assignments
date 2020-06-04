using System;

namespace Wizard_Ninja_Samurai
{
    public class Human
    {
        public string Name {get;set;}
        public int Strength {get;set;}
        public int Intelligence {get;set;}
        public int Dexterity {get;set;}
        public int Health {get;set;}

        public int health
        {
            get {return health;}
        }

        public Human(string name)
        {
            Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            Health = 100;

        }

        public Human(string name, int strength, int intelligence, int dexterity, int hp)
        {
            Name = name;
            Strength = strength;
            Intelligence = intelligence;
            Dexterity = dexterity;
            Health = hp;
        }

        public int Attack(Human target)
        {
            int damage = 5 * Strength;
            target.Health -= damage;
            Console.WriteLine($"{target.Name} loses {damage} pts from health.");
            return target.Health;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Strength: {Strength}, Intelligence: {Intelligence}, Dexterity: {Dexterity}, Health: {Health}";
        }
    }
}