using System;
using Xunit;

namespace tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestOneItem()
        {
            PriorityQueue<int> test = new PriorityQueue<int>();
            test.Enqueue(32);
            int returnValue = test.Dequeue();
            Assert.Equal(32, returnValue);
        }

        [Fact]
        public void MixedOperations()
        {
            PriorityQueue<int> test = new PriorityQueue<int>();
            test.Enqueue(32);
            test.Enqueue(8);
            test.Dequeue();
            test.Dequeue();
            test.Enqueue(1);
            int returnValue = test.Dequeue();
            Assert.Equal(1, returnValue);
        }

        [Fact]
        public void TestManyItems()
        {
            PriorityQueue<int> test = new PriorityQueue<int>();
            for (int x = 100000; x >= 0; x--)
            {
                test.Enqueue(x);
            }

            for (int x = 0; x < 100000; x++)
            {
                var result = test.Dequeue();
                Assert.Equal(x, result);
            }


        }
    }
}
