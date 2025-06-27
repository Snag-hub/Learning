using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSAWithC_.DataStructures.Stack.Questions
{
    public class ReverseString
    {
        public static void ReverseAnArray(string n)
        {
            if (n is null)
            {
                Console.WriteLine("Array is small");
                return;
            }

            Console.WriteLine("Non-Reversed " + n);

            var item = new Stack<char>();
            string rev = "";
            foreach (var i in n)
            {
                item.Push(i);
            }

            while (item.Count > 0)
            {
                rev += item.Pop();
            }
            Console.WriteLine($"Reversed string: {rev}");
        }
    }
}