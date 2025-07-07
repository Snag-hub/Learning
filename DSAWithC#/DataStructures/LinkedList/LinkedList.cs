using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSAWithC_.DataStructures.LinkedList
{
    public class LinkedList
    {
        public void RunAll()
        {

            Console.WriteLine("Singly LinkedList");
            SinglyLinkedList list = new();

            list.InsertLast(10);
            list.InsertLast(20);
            list.InsertLast(30);
            list.InsertFirst(5);
            list.InsertAt(2, 15); // Insert 15 at index 2

            list.PrintList(); // Expected: 5 -> 10 -> 15 -> 20 -> 30 -> null

            list.DeleteByValue(15);
            list.PrintList(); // Expected: 5 -> 10 -> 20 -> 30 -> null

            list.DeleteFirst();
            list.DeleteLast();
            list.PrintList(); // Expected: 10 -> 20 -> null

            Console.WriteLine("Contains 20? " + list.Contains(20)); // true
            Console.WriteLine("Contains 50? " + list.Contains(50)); // false

            // Doubly Linkedlist
            Console.WriteLine("Doubly LinkedList");
            DoublyLinkedList dll = new();

            dll.InsertFirst(30);
            dll.InsertFirst(20);
            dll.InsertFirst(10);
            dll.InsertLast(40);
            dll.InsertLast(50);

            Console.WriteLine("Forward Traversal:");
            dll.PrintForward(); // 10 <-> 20 <-> 30 <-> 40 <-> 50 <-> null

            Console.WriteLine("Backward Traversal:");
            dll.PrintBackward(); // 50 <-> 40 <-> 30 <-> 20 <-> 10 <-> null

            dll.DeleteFirst();
            dll.DeleteLast();

            Console.WriteLine("After Deletions:");
            dll.PrintForward(); // 20 <-> 30 <-> 40 <-> null

            // circular LinkedList
            Console.WriteLine("Circular LinkedList");
            CircularLinkedList cll = new();

            cll.InsertEnd(10);
            cll.InsertEnd(20);
            cll.InsertEnd(30);
            cll.InsertFront(5);

            cll.PrintList();  // 5 -> 10 -> 20 -> 30 -> (head)

            cll.DeleteFront();
            cll.PrintList();  // 10 -> 20 -> 30 -> (head)

            // Doubly Circular Linkedlist
            Console.WriteLine("Doubly Circular LinkedList");
            DoublyCircularLinkedList dcll = new DoublyCircularLinkedList();

            dcll.InsertEnd(10);
            dcll.InsertEnd(20);
            dcll.InsertFront(5);
            dcll.InsertFront(1);

            Console.WriteLine("Forward:");
            dcll.PrintForward(); // 1 <-> 5 <-> 10 <-> 20 <-> (head)

            Console.WriteLine("Backward:");
            dcll.PrintBackward(); // 20 <-> 10 <-> 5 <-> 1 <-> (tail)

            dcll.DeleteFront();
            dcll.DeleteEnd();

            Console.WriteLine("After Deletion:");
            dcll.PrintForward(); // 5 <-> 10 <-> (head)
        }
    }
}