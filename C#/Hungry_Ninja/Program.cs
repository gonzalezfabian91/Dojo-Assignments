using System;

namespace Hungry_Ninja
{
    class Program
    {
        static void Main(string[] args)
        {
            Buffet World = new Buffet();
            Ninja Fabian = new Ninja(12);
            while(!Fabian.IsFull)
            {
                Fabian.Eat(World.Serve());
            }
        }
    }
}
