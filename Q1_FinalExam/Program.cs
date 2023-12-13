using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1_FinalExam
{
    class MyStack
    {
        private List<int> stackList = new List<int>();

        public void Push(int n)
        {
            stackList.Add(n);
        }

        public int Pop()
        {
            if (stackList.Count == 0)
            {
                Console.WriteLine("The stack is empty"); 
                return 0;
            }

            int lastIndex = stackList.Count - 1;
            int poppedValue = stackList[lastIndex];
            stackList.RemoveAt(lastIndex);

            return poppedValue;
        }

        public int Peek()
        {
            if (stackList.Count == 0)
            {
                Console.WriteLine("The stack is empty");
                return 0;
            }

            return stackList[stackList.Count - 1];
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyStack stack = new MyStack();

            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            Console.WriteLine("Peek: " + stack.Peek()); // Output: Peek: 30

            Console.WriteLine("Pop: " + stack.Pop()); // Output: Pop: 30

            Console.WriteLine("Peek: " + stack.Peek()); // Output: Peek: 20

        }
    }
}