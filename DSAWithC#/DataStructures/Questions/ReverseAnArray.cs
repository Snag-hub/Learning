using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSAWithC_.DataStructures.Questions;

public static class ReverseAnArray
{
    public static void ReverseArray(int[] arr)
    {
        if (arr.Length <= 0)
        {
            Console.WriteLine("array is empty");
            return;
        }

        Console.WriteLine(string.Join(',', arr));

        // todo: loop all elements and with two pointer technique.
        int left = 0;
        int right = arr.Length - 1;

        while (left < right)
        {
            var temp = arr[left];
            arr[left] = arr[right];
            arr[right] = temp;
            left++;
            right--;
        }

        Console.WriteLine(string.Join(',', arr));
    }
}
