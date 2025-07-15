using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSAWithC_.DataStructures.LinkedList
{
    public class CNode
    {
        public int Data;
        public CNode Next;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
#pragma warning disable IDE0290 // Use primary constructor
        public CNode(int data)
#pragma warning restore IDE0290 // Use primary constructor
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
        {
            Data = data;
            Next = null;
        }
    }

    public class CircularLinkedList
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
        private CNode head;
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.

        public void InsertEnd(int data)
        {
            CNode newNode = new CNode(data);
            if (head == null)
            {
                head = newNode;
                head.Next = head; // Point to itself
                return;
            }

            CNode current = head;
            while (current.Next != head)
            {
                current = current.Next;
            }
            current.Next = newNode;
            newNode.Next = head;
        }

        public void InsertFront(int data)
        {
            CNode newNode = new CNode(data);
            if (head == null)
            {
                head = newNode;
                head.Next = head;
                return;
            }

            CNode current = head;
            while (current.Next != head)
            {
                current = current.Next;
            }

            newNode.Next = head;
            current.Next = newNode;
            head = newNode;
        }

        public void DeleteFront()
        {
            if (head == null) return;

            if (head.Next == head)
            {
                head = null;
                return;
            }

            CNode current = head;
            while (current.Next != head)
            {
                current = current.Next;
            }

            current.Next = head.Next;
            head = head.Next;
        }

        public void PrintList()
        {
            if (head == null)
            {
                Console.WriteLine("List is empty.");
                return;
            }

            CNode current = head;
            do
            {
                Console.Write(current.Data + " -> ");
                current = current.Next;
            } while (current != head);
            Console.WriteLine("(head)");
        }
    }

}