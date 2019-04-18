using System;
using System.Collections.Generic;

namespace RandomNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
        // Generate a list of random numbers 0-5
            Random random = new Random();
            List<int> numbers = new List<int> {
        random.Next(6),
        random.Next(6),
        random.Next(6),
        random.Next(6),
        random.Next(6),
        random.Next(6),
        };

        // iterate over the list to see if the value of the index is in the list and print the appropriate message
            for (int i = 0; i < numbers.Count; i++)

                if (numbers.Contains(i))
                {   // if i is in the list
                    Console.WriteLine($"random list contains {i}");
                }
                else
                {   // if i is not in the list
                    Console.WriteLine($"random list does not contain {i}");
                }
        }
    }
}