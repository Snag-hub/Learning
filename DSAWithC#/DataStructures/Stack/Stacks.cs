using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DSAWithC_.DataStructures.Stack.Questions;

namespace DSAWithC_.DataStructures.Stack
{
    public static class Stacks
    {
        public static void RunAll()
        {
            string s = "Nadeem";
            ReverseString.ReverseAnArray(s);
            var bal = BalancedParenthesesChecker.IsBalanced();
            Console.WriteLine(bal);
        }
    }
}