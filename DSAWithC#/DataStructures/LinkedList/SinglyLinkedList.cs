using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSAWithC_.DataStructures.LinkedList
{
    public class Node
    {
        public int Data;
        public Node Next;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
#pragma warning disable IDE0290 // Use primary constructor
        public Node(int data)
#pragma warning restore IDE0290 // Use primary constructor
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
        {
            Data = data;
            Next = null;
        }
    }
    public class SinglyLinkedList
    {
        private Node head;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
        public SinglyLinkedList()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
        {
            head = null;
        }

        // Add at the end
        public void InsertLast(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
                return;
            }

            Node current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }

        // Add at the beginning
        public void InsertFirst(int data)
        {
            Node newNode = new Node(data);
            newNode.Next = head;
            head = newNode;
        }

        // Insert at a specific position (0-based)
        public void InsertAt(int index, int data)
        {
            if (index == 0)
            {
                InsertFirst(data);
                return;
            }

            Node newNode = new Node(data);
            Node current = head;
            for (int i = 0; i < index - 1; i++)
            {
                if (current == null) return;
                current = current.Next;
            }

            newNode.Next = current.Next;
            current.Next = newNode;
        }

        // Delete first node
        public void DeleteFirst()
        {
            if (head != null)
                head = head.Next;
        }

        // Delete last node
        public void DeleteLast()
        {
            if (head == null || head.Next == null)
            {
                head = null;
                return;
            }

            Node current = head;
            while (current.Next.Next != null)
            {
                current = current.Next;
            }
            current.Next = null;
        }

        // Delete node by value
        public void DeleteByValue(int value)
        {
            if (head == null) return;

            if (head.Data == value)
            {
                head = head.Next;
                return;
            }

            Node current = head;
            while (current.Next != null && current.Next.Data != value)
            {
                current = current.Next;
            }

            if (current.Next != null)
            {
                current.Next = current.Next.Next;
            }
        }

        // Print the list
        public void PrintList()
        {
            Node current = head;
            while (current != null)
            {
                Console.Write(current.Data + " -> ");
                current = current.Next;
            }
        }

        // Search for value
        public bool Contains(int value)
        {
            Node current = head;
            while (current != null)
            {
                if (current.Data == value)
                    return true;
                current = current.Next;
            }
            return false;
        }
    }

}