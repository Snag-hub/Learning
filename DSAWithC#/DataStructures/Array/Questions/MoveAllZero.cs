using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSAWithC_.DataStructures.Questions
{
    public class MoveAllZero
    {
        public static void MoveAllZeroToEnd(int[] arr)
        {
            if (arr == null || arr.Length == 0)
            {
                Console.WriteLine("Array is empty or null");
                return;
            }

            int pos = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                {
                    arr[pos] = arr[i];
                    pos++;
                }
            }

            for (int i = pos; i < arr.Length; i++)
            {
                arr[i] = 0;
            }

            Console.WriteLine($"Move All Zero: {string.Join(',', arr)}");
        }
    }
}