using System;


public class PriorityQueue
{

    public PriorityQueue()
    {
        elements = new int[10];
    }

    public void AddElement(int x)
    {
        elements.SetValue(x, numberOfItems);
        numberOfItems++;
    }
    private Array elements;
    private int numberOfItems = 0;

}

/*
Parent i
Left child = 2 * i + 1
Right child = 2 * i + 2

Child i 
Parent = (i - 1 ) / 2 
(Works due to integer division)


peek() Return element with highest priority

enqueue(e)
- Put at first available slot. heap[heapsize] = newElement
- Bubble up
- Loop at the newly added element and it's parent. Do they have a proper min-heap relationship?
    -If yes, we-re done.
    -If not, SWAP the newly added element with it's parent.
    -Continue until done or newly added element is root of heap.

dequeue()
-Remove the root of the three.
-Replace with the last element in our three, farthest right.
-Bubble down to regain heap property.
    -Compare the moved element to its new children.
    -Of one of the two children is smaller, swap with that child.
    -IF both of the children are smallen, swap with the one that's smaller.
    -Repeat until you no longer bubble down or there are no more children to compare against.

peek() - Look at the root of the three = index 0


*/