using System;

namespace iron_ninja
{
    public class SweetTooth : Ninja
    {
        public override bool IsFull
        {
            get
            {
                if (calorieIntake > 1500)
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
                Console.WriteLine("SweetTooth is full");
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