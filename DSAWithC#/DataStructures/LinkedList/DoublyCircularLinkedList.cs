using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSAWithC_.DataStructures.LinkedList
{
    public class DCNode
    {
        public int Data;
        public DCNode Next;
        public DCNode Prev;

        public DCNode(int data)
        {
            Data = data;
            Next = Prev = null;
        }
    }

    public class DoublyCircularLinkedList
    {
        private DCNode head;

        // Insert at the end
        public void InsertEnd(int data)
        {
            DCNode newNode = new DCNode(data);

            if (head == null)
            {
                head = newNode;
                head.Next = head;
                head.Prev = head;
                return;
            }

            DCNode tail = head.Prev;

            tail.Next = newNode;
            newNode.Prev = tail;
            newNode.Next = head;
            head.Prev = newNode;
        }

        // Insert at the beginning
        public void InsertFront(int data)
        {
            InsertEnd(data); // Reuse logic
            head = head.Prev; // Move head to the newly inserted node
        }

        // Delete from front
        public void DeleteFront()
        {
            if (head == null) return;

            if (head.Next == head)
            {
                head = null;
                return;
            }

            DCNode tail = head.Prev;
            head = head.Next;

            tail.Next = head;
            head.Prev = tail;
        }

        // Delete from end
        public void DeleteEnd()
        {
            if (head == null) return;

            if (head.Next == head)
            {
                head = null;
                return;
            }

            DCNode tail = head.Prev;
            DCNode newTail = tail.Prev;

            newTail.Next = head;
            head.Prev = newTail;
        }

        // Print forward
        public void PrintForward()
        {
            if (head == null)
            {
                Console.WriteLine("List is empty.");
                return;
            }

            DCNode current = head;
            do
            {
                Console.Write(current.Data + " <-> ");
                current = current.Next;
            } while (current != head);
            Console.WriteLine("(head)");
        }

        // Print backward
        public void PrintBackward()
        {
            if (head == null)
            {
                Console.WriteLine("List is empty.");
                return;
            }

            DCNode tail = head.Prev;
            DCNode current = tail;
            do
            {
                Console.Write(current.Data + " <-> ");
                current = current.Prev;
            } while (current != tail);
            Console.WriteLine("(tail)");
        }
    }

}