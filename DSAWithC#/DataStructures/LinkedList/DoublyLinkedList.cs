using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSAWithC_.DataStructures.LinkedList
{
    public class DNode
    {
        public int Data;
        public DNode Prev;
        public DNode Next;

        public DNode(int data)
        {
            Data = data;
            Prev = null;
            Next = null;
        }
    }

    public class DoublyLinkedList
    {
        private DNode head;
        private DNode tail;

        public void InsertFirst(int data)
        {
            DNode newNode = new DNode(data);

            if (head == null)
            {
                head = tail = newNode;
            }
            else
            {
                newNode.Next = head;
                head.Prev = newNode;
                head = newNode;
            }
        }

        public void InsertLast(int data)
        {
            DNode newNode = new DNode(data);

            if (tail == null)
            {
                head = tail = newNode;
            }
            else
            {
                tail.Next = newNode;
                newNode.Prev = tail;
                tail = newNode;
            }
        }

        public void DeleteFirst()
        {
            if (head == null) return;

            if (head == tail)
            {
                head = tail = null;
            }
            else
            {
                head = head.Next;
                head.Prev = null;
            }
        }

        public void DeleteLast()
        {
            if (tail == null) return;

            if (head == tail)
            {
                head = tail = null;
            }
            else
            {
                tail = tail.Prev;
                tail.Next = null;
            }
        }

        public void PrintForward()
        {
            DNode current = head;
            while (current != null)
            {
                Console.Write(current.Data + " <-> ");
                current = current.Next;
            }
            Console.WriteLine("null");
        }

        public void PrintBackward()
        {
            DNode current = tail;
            while (current != null)
            {
                Console.Write(current.Data + " <-> ");
                current = current.Prev;
            }
            Console.WriteLine("null");
        }
    }

}