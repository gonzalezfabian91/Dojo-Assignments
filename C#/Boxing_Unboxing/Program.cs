using System;
using System.Collections.Generic;

namespace Boxing_Unboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> info = new List<object>();
            info.Add(7);
            info.Add(28);
            info.Add(-1);
            info.Add(true);
            info.Add("chair");
            foreach (var i in info)
            {
                Console.WriteLine(i);
            }
            int sum = 0;
            foreach (var i in info)
            {
                if (i is int)
                {
                    sum += (int)i;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
