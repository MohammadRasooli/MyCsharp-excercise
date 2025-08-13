// Node class: Represents a node (wagon) in the doubly linked list (train)
public class Node
{
    // Value stored in this node (wagon)
    public int Data { get; set; }

    // Reference to the next node (wagon) in the list
    public Node Next { get; set; }

    // Reference to the previous node (wagon) in the list. This makes the list doubly linked.
    public Node Previous { get; set; }

    // Constructor: Initializes a node with the given value
    public Node(int data)
    {
        Data = data;
        Next = null;
        Previous = null;
    }
}

// MyLinkedList class: Implements a doubly linked list (train of wagons)
public class MyLinkedList
{
    // Reference to the first node (head/engine) of the list
    public Node Head { get; private set; }

    // Reference to the last node (tail/caboose) of the list.
    // Having a Tail pointer allows for O(1) additions to the end.
    public Node Tail { get; private set; }

    // Adds a new node (wagon) with the specified value to the end of the list
    public void AddLast(int data)
    {
        var newNode = new Node(data);

        // If the list is empty (this is the first wagon)
        if (Head == null)
        {
            Head = newNode;
            Tail = newNode;
            return;
        }

        // Link the current tail to the new node
        Tail.Next = newNode;
        // Link the new node back to the old tail (creating the backward link)
        newNode.Previous = Tail;

        // Update the Tail to be the new last node
        Tail = newNode;
    }

    // Prints all nodes (wagons) in the list from head to tail
    public void PrintForward()
    {
        Console.Write("Forward:  ");
        var current = Head;
        while (current != null)
        {
            Console.Write($"{current.Data} <-> ");
            current = current.Next;
        }
        Console.WriteLine("null");
    }

    // Prints all nodes (wagons) in reverse order, from tail to head
    public void PrintBackward()
    {
        Console.Write("Backward: ");
        var current = Tail;
        while (current != null)
        {
            Console.Write($"{current.Data} <-> ");
            current = current.Previous;
        }
        Console.WriteLine("null");
    }
}

// Program class: Demonstrates usage of the custom doubly linked list
public class Program
{
    public static void Main(string[] args)
    {
        // Create a new instance of our linked list (the train)
        var train = new MyLinkedList();

        // Add nodes (wagons) to the linked list (train)
        train.AddLast(10);
        train.AddLast(20);
        train.AddLast(30);

        Console.WriteLine("Train contents:");

        // Print the linked list forward and backward to verify the doubly linked structure
        train.PrintForward();
        train.PrintBackward();
    }
}