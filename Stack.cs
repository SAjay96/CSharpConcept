using System;
using System.Collections;

namespace ArrayList
{
    class stack
    {
        static void Main(String[] args)
        {
            Stack stack = new Stack();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            stack.Push(40);
            stack.Push(50);

            stack.Pop();
            stack.Pop();
            foreach(object item in stack)
            {
                Console.WriteLine(item);
            }

            Queue queue = new Queue();
            queue.Enqueue(100);
            queue.Enqueue(200); 
            queue.Enqueue(300);


            queue.Dequeue();

            foreach(Object item in queue)
            {
                Console.WriteLine(item);
            }

        }
    }
}
