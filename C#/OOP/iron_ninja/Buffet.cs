using System;
using System.Collections.Generic;

namespace iron_ninja
{
    public class Buffet
    {
        public List<IConsumable> Menu;
        public Buffet()
        {
            Menu = new List<IConsumable>()
            {
                new Food("Ramen", 200, true, false),
                new Food("Sushi", 200, false, true),
                new Food("Tacos", 150, true, false),
                new Food("Cheeseburger", 305, false, false),
                new Food("Pizza", 285, false, false),
                new Food("Philly Cheese Steak", 573, false, false),
                new Food("Steak", 679, false, false),
                new Drink("Iced Tea", 91, false, true),
                new Drink("Lemonade", 99, false, true),
                new Drink("Beer", 154, false, false),
            };
        }

        public IConsumable Serve()
        {
            Random rand = new Random();
            return Menu[rand.Next(Menu.Count)];
        }
    }
}