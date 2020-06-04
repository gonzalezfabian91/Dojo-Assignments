using System;

namespace Hungry_Ninja
{
    class Program
    {
        static void Main(string[] args)
        {
            Buffet World = new Buffet();
            Ninja Fabian = new Ninja();
            while(Fabian.IsFull == false)
            {
                Fabian.Eat(World.Serve());
            }
        }
    }
}
