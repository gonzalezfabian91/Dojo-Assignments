using System;

namespace iron_ninja
{
    class Program
    {
        static void Main(string[] args)
        {
            Buffet World = new Buffet();
            SweetTooth sweet = new SweetTooth();
            SpiceHound spice = new SpiceHound();
            while (sweet.IsFull == false)
            {
                sweet.Consume(World.Serve());
            }
            while (spice.IsFull == false)
            {
                spice.Consume(World.Serve());
            }
        }
    }
}
