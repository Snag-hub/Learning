using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSAWithC_.DataStructures.LinkedList.Questions
{
    public class LLQuestions
    {
        public static bool Search(Node head, int target)
        {
            while (head != null)
            {
                if (head.Data == target)
                {
                    return true;
                }
                head = head.Next;
            }
            return false;
        }

        public static int NodeCounter(Node head)
        {
            int count = 0;
            while (head != null)
            {
                count += 1;
                head = head.Next;
            }
            return count;
        }

        public static int SameOccureance(Node head, int target)
        {
            int count = 0;
            while (head != null)
            {
                if (head.Data == target)
                {
                    count += 1;
                }
                head = head.Next;
            }
            return count;
        }
    }
}