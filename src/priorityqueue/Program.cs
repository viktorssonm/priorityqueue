using System;

namespace priorityqueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            PriorityQueue<int> test = new PriorityQueue<int>();
            test.Enqueue(8);
            test.Enqueue(7);
            test.Enqueue(6);
            test.Enqueue(5);
            test.Enqueue(2);
            // test.Dequeue();
            // test.Dequeue();
            // test.Dequeue();
            // test.Dequeue();
            // for (int x = 200; x > 0; x--)
            // {
            //     test.Enqueue(x);
            // }

            for (int x = 0; x < 5; x++)
            {
                System.Console.WriteLine(test.Dequeue());
            }

        }
    }
}
