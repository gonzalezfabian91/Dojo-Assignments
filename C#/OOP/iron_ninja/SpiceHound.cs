using System;

namespace iron_ninja
{
    public class SpiceHound : Ninja
    {
        public override bool IsFull
        {
            get
            {
                if (calorieIntake > 1200)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public override void Consume(IConsumable item)
        {
            if (IsFull)
            {
                Console.WriteLine("SpiceHound is full");
            }
            else
            {
                calorieIntake += item.Calories;
            }
            ConsumptionHistory.Add(item);
            item.GetInfo();
        }
    }
}