using System;

namespace priorityqueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            PriorityQueue<int> test = new PriorityQueue<int>();



            for (int x = 10; x > 0; x--)
            {
                test.Enqueue(x);
            }

            System.Console.WriteLine(test.count);


            for (int x = 0; x < 10; x++)
            {
                var a = test.Dequeue();
                System.Console.WriteLine(a);
            }



        }
    }
}
