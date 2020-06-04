using System;
using System.Collections.Generic;
using System.Linq;

namespace Basic_13
{
    class Program
    {
        static void Main(string[] args)
        {
            // PrintNumbers();
            // PrintOdds();
            // PrintSum();
            // LoopArray(1,5,7,9);
            // FindMax(8,3,6);
            // GetAverage(5, 7, 2);
            // OddArray();
            // GreaterThanY(int[] numbers, int y);
            // SquareArrayValues(int[] numbers);
            // EliminateNegatives(int[] numbers);
            // MinMaxAverage(int[] numbers);
            // ShiftValues(int[] numbers);
            // NumToString(int[] numbers);
        }
        //Print 1-255
        public static void PrintNumbers()
        {
            for (var i = 1; i <= 255; i++)
            {
                Console.WriteLine(i);
            }
        }

        //Print odd numbers between 1-255
        public static void PrintOdds()
        {
            for (var i = 1; i <= 255; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }
        }

        //Print Sum
        public static void PrintSum()
        {
            var sum = 0;
            for (var i = 1; i <= 255; i++)
            {
                sum += i;
                Console.WriteLine(sum);
            }
        }

        //Iterating through an Array
        public static void LoopArray(params int[] numbers)
        {
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        //Find Max
        public static void FindMax(params int[] maxNums)
        {
            int max = maxNums[0];
            foreach (var maxNum in maxNums)
            {
                if (maxNum > max)
                {
                    max = maxNum;
                }
            }
            Console.WriteLine(max);
        }

        //Get Average
        public static void GetAverage(params int[] numbers)
        {
            var sum = 0;
            foreach(var number in numbers)
            {
                sum += number;
            }
            Console.WriteLine("avg: " + (sum/(numbers.Length)));
        }

        //Array with Odd Numbers
        public static void OddArray()
        {
            var y = new List<int>();
            for (var i = 1; i <= 255; i++)
            {
                if (i % 2 == 1)
                {
                    y.Add(i);
                }
            }
            Console.WriteLine("array: ");
            foreach (var i in y)
            {
                Console.WriteLine( + i +", ");
            }
        }

        //Greater than Y
        public static void GreaterThanY(int[] numbers, int y)
        {
            
        }
    }
}
