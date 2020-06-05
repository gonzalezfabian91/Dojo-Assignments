using System;

namespace Wizard_Ninja_Samurai
{
    public class Ninja : Human
    {
        // public string Name {get;set;}
        // public int Strength {get;set;}
        // public int Intelligence {get;set;}
        // public int Dexterity {get;set;}
        // public int Health {get;set;}

        // public int health
        // {
        //     // get {return Health;}
        // }

        public Ninja(string name, int strength, int intelligence, int hp):base(name)
        {
            Name = name;
            Strength = strength;
            Intelligence = intelligence;
            Dexterity = 175;
            Health = hp;
        }
        public Ninja(string name, int strenght, int intelligence, int dexterity, int hp):base(name)
        {
            Name = name;
            Strength = strenght;
            Intelligence = intelligence;
            Dexterity = dexterity;
            Health = hp;
        }

        public void Attack(Object target)
        {
            var dmg = new Random().Next(5 * Dexterity, 885);
            Human enemy = (Human)target;
            enemy.Health -= dmg;
            Console.WriteLine($"{Name} has attacked {enemy.Name} and delt a damage of {dmg} and killed him.");
        }

        public void Steal(Object target)
        {
            Human enemy = (Human)target;
            enemy.Health -= 5;
            Health += 5;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Strength: {Strength}, Intelligence: {Intelligence}, Dexterity: {Dexterity}, Health: {Health}";
        }
    }
}