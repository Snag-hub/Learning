using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace DSAWithC_.DataStructures.Queue.Questions
{
    public class MyQueue
    {
        private int[] data;
        private int front;
        private int rear;
        private int size;
        private int capacity;

        public MyQueue(int cap)
        {
            capacity = cap;
            data = new int[capacity];
            front = 0;
            rear = -1;
            size = 0;
        }

        public bool Enqueue(int val)
        {
            if (size == capacity) return false;
            rear = (rear + 1) % capacity;
            data[rear] = val;
            size++;
            return true;
        }

        public bool Dequeue()
        {
            if (size == 0) return false;
            front = (front + 1) % capacity;
            size--;
            return true;
        }

        public int Peek() => size == 0 ? -1 : data[front];

        public bool IsEmpty() => size == 0;
    }

}