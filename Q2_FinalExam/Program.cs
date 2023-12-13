using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2_FinalExam
{
    class MyQueue
    {
        private List<int> queueList = new List<int>();

        public void Enqueue(int n)
        {
            queueList.Add(n);
        }

        public int Dequeue()
        {
            if (queueList.Count == 0)
            {
                Console.WriteLine("The queue is empty.");
            }

            int dequeuedValue = queueList[0];
            queueList.RemoveAt(0);

            return dequeuedValue;
        }

        public int Peek()
        {
            if (queueList.Count == 0)
            {
                Console.WriteLine("The queue is empty.");
            }

            return queueList[0];
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyQueue myQueue = new MyQueue();

            myQueue.Enqueue(10);
            myQueue.Enqueue(20);
            myQueue.Enqueue(30);

            Console.WriteLine("Peek: " + myQueue.Peek()); // Output: Peek: 10

            Console.WriteLine("Dequeue: " + myQueue.Dequeue()); // Output: Dequeue: 10

            Console.WriteLine("Peek: " + myQueue.Peek()); // Output: Peek: 20
        }
    }
}
