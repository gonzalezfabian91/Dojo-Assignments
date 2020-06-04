using System;

namespace Wizard_Ninja_Samurai
{
    class Program
    {
        static void Main(string[] args)
        {
            var player1 = new Samurai("Fabian", 20, 10, 5);
            var player2 = new Ninja("Elena", 50, 70, 30);
            var player3 = new Wizard("Anthony", 15, 30);
            Console.WriteLine(player1);
            Console.WriteLine(player2);
            // Console.WriteLine(player3);
            player2.Attack(player1);
            // player3.Heal(player2);
            // player2.Steal(player3);
            // player1.Meditate();
            Console.WriteLine(player1);
            Console.WriteLine(player2);
            
        }
    }
}
