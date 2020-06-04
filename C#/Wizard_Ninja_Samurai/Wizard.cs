using System;

namespace Wizard_Ninja_Samurai
{
    public class Wizard : Human
    {
        // public string Name {get;set;}
        // public int Strength {get;set;}
        // public int Intelligence {get;set;}
        // public int Dexterity {get;set;}
        // public int Health {get;set;}

        // public int health
        // {
        //     get {return health;}
        // }

        public Wizard(string name, int strenght, int dexterity):base(name)
        {
            Name = name;
            Strength = strenght;
            Intelligence = 25;
            Dexterity = dexterity;
            Health = 50;
        }

        public Wizard(string name, int strenght, int intelligence, int dexterity, int hp):base(name)
        {
            Name = name;
            Strength = strenght;
            Intelligence = intelligence;
            Dexterity = dexterity;
            Health = hp;
        }

        public void Attack(Object target)
        {
            var dmg = 5 * Intelligence;
            Human enemy = (Human)target;
            enemy.Health -= dmg;
            Health += dmg;
            Console.WriteLine($"{Name} has attacked {enemy.Name} and delt a blow of {dmg} while his health has increased by {dmg}.");
        }

        public void Heal(Object target)
        {
            var heal = 10 * Intelligence;
            Human healed = (Human)target;
            healed.Health += heal;
            Console.WriteLine($"{Name} has healed {healed.Name} by {heal}.");
        }

        public override string ToString()
        {
            return $"Name: {Name}, Strength: {Strength}, Intelligence: {Intelligence}, Dexterity: {Dexterity}, Health: {Health}";
        }
    }
}