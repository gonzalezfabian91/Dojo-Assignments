using System;
using System.Collections.Generic;

namespace Hungry_Ninja
{
    public class Ninja
    {
        private int calorieIntake;
        private int calorieLimit;
        public List<Food> FoodHistory;
        public bool IsFull{
            get{
                return calorieIntake >= calorieLimit;
            }
        }

        public Ninja()
        {
            calorieIntake = 0;
            calorieLimit = 1200;
            FoodHistory = new List<Food>();
        }

        public void Eat(Food item)
        {
            if (this.IsFull == true)
            {
                Console.WriteLine("Ninja is full");
            }
            else
            {
                Console.WriteLine($"Ninja is about to eat {item.Name}");
                calorieIntake += item.Calories;
                FoodHistory.Add(item);
            }
        }


    }
}
