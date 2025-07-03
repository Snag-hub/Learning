using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using DSAWithC_.DataStructures.Queue.Questions;

namespace DSAWithC_.DataStructures.Queue
{
    public class Queues
    {
        MyQueue q = new MyQueue(5);

        public void RunAll()
        {
            q.Enqueue(10);
            q.Enqueue(20);
            q.Dequeue();
            int a = q.Peek();
            Console.WriteLine(a);
        }
    }
}