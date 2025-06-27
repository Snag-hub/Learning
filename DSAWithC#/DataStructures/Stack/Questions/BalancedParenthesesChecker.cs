using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSAWithC_.DataStructures.Stack.Questions
{
    public static class BalancedParenthesesChecker
    {
        public static bool IsBalanced()
        {
            string input = "a + (b * c) - {d / [e + f](}";
            Stack<char> stack = new();
            Dictionary<char, char> match = new()
            {
                { ')', '(' },
                { '}', '{' },
                { ']', '[' }
            };

            foreach (char ch in input)
            {
                if (match.ContainsValue(ch))
                {
                    stack.Push(ch);
                }
                else if (match.ContainsKey(ch))
                {
                    if (stack.Count == 0 || stack.Pop() != match[ch])
                        return false;
                }
            }

            return stack.Count == 0;
        }
    }
}