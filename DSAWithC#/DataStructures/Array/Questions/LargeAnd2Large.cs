using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSAWithC_.DataStructures.Questions
{
    public class LargeAnd2Large
    {
        public static void LargeAnd2ndLarge(int[] arr)
        {
            if (arr.Length < 2)
            {
                Console.WriteLine("Array must have at least 2 elements.");
                return;
            }

            int max = int.MinValue;
            int secondMax = int.MinValue;

            foreach (var item in arr)
            {
                if (item > max)
                {
                    secondMax = max;
                    max = item;
                }
                else if (item > secondMax && item != max)
                {
                    secondMax = item;
                }
            }

            if (secondMax == int.MinValue)
                Console.WriteLine($"Max: {max}, but no distinct second max found.");
            else
                Console.WriteLine($"Max: {max}, SecondMax: {secondMax}");
        }

    }
}