using System;
using System.Collections.Generic;
using System.Linq;

class RelativeSorting
{
    // sample data: 
    // Arr = {9 5 8 4 6 5}
    // Brr = {8 4 5}
    // Output = {8 4 5 5 6 9}

    public static void Run()
    {
        int[] Arr = { 9, 5, 8, 4, 6, 5 };
        int[] Brr = { 8, 4, 5 };
        var res = RelativeSort(Arr, Brr);
        Console.WriteLine(string.Join(" ", res));
    }

    public static int[] RelativeSort(int[] arr1, int[] arr2)
    {
        var freq = new Dictionary<int, int>();
        foreach (var x in arr1)
        {
            if (freq.ContainsKey(x))
                freq[x]++;
            else
                freq[x] = 1;
        }

        var result = new List<int>();
        foreach (var x in arr2)
        {
            if (freq.ContainsKey(x))
            {
                for (int i = 0; i < freq[x]; i++)
                {
                    result.Add(x);
                }
                freq.Remove(x);
            }
        }

        var remaining = new List<int>();
        foreach (var kvp in freq)
        {
            for (int i = 0; i < kvp.Value; i++)
            {
                remaining.Add(kvp.Key);
            }
        }
        remaining.Sort();
        result.AddRange(remaining);
        return result.ToArray();
    }
}
