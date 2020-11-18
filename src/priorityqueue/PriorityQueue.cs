using System;
using System.Collections.Generic;

public class PriorityQueue<T> where T : IComparable<T>
{

    public PriorityQueue()
    {
        elements = new List<T>();
    }

    public void Enqueue(T data)
    {
        elements.Add(data);
        BubbleUp(numberOfItems);
        numberOfItems++;
    }

    public T Dequeue()
    {
        // Check if there is any items in the array;
        if (numberOfItems < 1)
        {
            throw new IndexOutOfRangeException("No more items in array");
        }

        T rootElement = elements[0];

        if (numberOfItems == 1)
        {
            numberOfItems--;
            elements.RemoveAt(0);
            return rootElement;
        }

        elements[0] = elements[numberOfItems - 1];
        elements.RemoveAt(numberOfItems - 1);
        numberOfItems--;
        BubbleDown(0);

        return rootElement;

    }

    private void BubbleDown(int root)
    {
        T rootElement = elements[0];
        T? leftChild;
        T? rightChild;




    }

    // private void BubbleDown(int root)
    // {
    //     if (numberOfItems == 1)
    //     {
    //         return;
    //     }

    //     if (numberOfItems == 2)
    //     {
    //         if (elements[0].CompareTo(elements[1]) > 0)
    //         {
    //             T temp = elements[0];
    //             elements[0] = elements[1];
    //             elements[1] = temp;
    //         }
    //         return;
    //     }


    //     T rootElement = elements[root];
    //     int leftChildIndex = GetLeftChild(root);
    //     int rightChildIndex = GetRightChild(root);


    //     if ((leftChildIndex > numberOfItems - 1) || (rightChildIndex > numberOfItems - 1))
    //     {
    //         return;
    //     }

    //     T leftChild = elements[GetLeftChild(root)];
    //     T rightChild = elements[GetRightChild(root)];

    //     if ((rootElement.CompareTo(leftChild) <= 0) && rootElement.CompareTo(rightChild) <= 0)
    //     {
    //         return;
    //     }

    //     if (leftChild.CompareTo(rightChild) < 0)
    //     {
    //         // Left child is less.
    //         elements[root] = leftChild;
    //         elements[GetLeftChild(root)] = rootElement;
    //         BubbleDown(GetLeftChild(root));
    //     }
    //     else
    //     {
    //         elements[root] = rightChild;
    //         elements[GetRightChild(root)] = rootElement;
    //         BubbleDown(GetRightChild(root));
    //     }



    // }

    private void BubbleUp(int position)
    {
        if (position == 0)
        {
            return;
        }
        T parentItem = elements[GetParent(position)];
        T childItem = elements[position];

        if (parentItem.CompareTo(childItem) >= 0)
        {
            System.Console.WriteLine("Less");
            elements[GetParent(position)] = childItem;
            elements[position] = parentItem;
            BubbleUp(GetParent(position));
        }
    }



    // Helper functions to get index of data
    private int GetLeftChild(int value)
    {
        return 2 * value + 1;
    }

    private int GetRightChild(int value)
    {
        return 2 * value + 2;
    }

    private int GetParent(int value)
    {
        return (value - 1) / 2;
    }

    // Helper swap function
    private void swap(int firstIndex, int secondIndex)
    {
        if ((firstIndex > numberOfItems - 1) || (secondIndex > numberOfItems - 1))
        {
            throw new IndexOutOfRangeException("Trying to swap something out of bouds.");
        }
        T temp = elements[firstIndex];
        elements[firstIndex] = elements[secondIndex];
        elements[secondIndex] = temp;
    }


    private List<T> elements;
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