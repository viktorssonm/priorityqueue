using System;

namespace priorityqueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            PriorityQueue<int> test = new PriorityQueue<int>();
            test.Enqueue(4);
            test.Enqueue(1);
            test.Enqueue(32);
            // test.Dequeue();
            // test.Dequeue();
            // test.Dequeue();
            // test.Dequeue();

            for (int x = 0; x < 3; x++)
            {
                System.Console.WriteLine(test.Dequeue());
            }

        }
    }
}
