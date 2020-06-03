using System;
using System.Collections.Generic;

namespace Hungry_Ninja
{
    public class Buffet
    {
        public List<Food> Menu;
        public static Random rand = new Random();
        public Buffet()
        {
            Menu = new List<Food>()
            {
                new Food("Ramen", 200, true, false),
                new Food("Sushi", 200, false, true),
                new Food("Tacos", 150, true, false),
                new Food("Cheeseburger", 305, false, false),
                new Food("Pizza", 285, false, false),
                new Food("Philly Cheese Steak", 573, false, false),
                new Food("Steak", 679, false, false),
            };
        }

        public Food Serve()
        {
            return Menu[rand.Next(Menu.Count)];
        }
    }
}