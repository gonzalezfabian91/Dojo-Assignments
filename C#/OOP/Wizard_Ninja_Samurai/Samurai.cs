using System;

namespace Wizard_Ninja_Samurai
{
    public class Samurai : Human
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
        
        public Samurai(string name, int strength, int intelligence, int dexterity):base(name)
        {
            Name = name;
            Strength = strength;
            Intelligence = intelligence;
            Dexterity = dexterity;
            Health = 200;
        }
        public Samurai(string name, int strenght, int intelligence, int dexterity, int hp):base(name)
        {
            Name = name;
            Strength = strenght;
            Intelligence = intelligence;
            Dexterity = dexterity;
            Health = hp;
        }

        public void Attack(Object target)
        {
            Human enemy = (Human)target;
            if (enemy.Health <= 50)
            {
                enemy.Health = 0;
                Console.WriteLine($"{Name} has killed {enemy.Name} with his katana.");
            }
            else
            {
                Console.WriteLine($"{enemy.Name} dodged {Name}'s attack.");
            }
        }

        public void Meditate()
        {
            Health = 200;
        }
        
        public override string ToString()
        {
            return $"Name: {Name}, Strength: {Strength}, Intelligence: {Intelligence}, Dexterity: {Dexterity}, Health: {Health}";
        }

    }
}