// Node class: Represents a node (wagon) in the doubly circular linked list (train)
public class Node
{
    // Value stored in this node (wagon)
    public int Data { get; set; }

    // Reference to the next node (wagon) in the list
    public Node Next { get; set; }

    // Reference to the previous node (wagon) in the list
    public Node Previous { get; set; }

    // Constructor: Initializes a node with the given value
    public Node(int data)
    {
        Data = data;
        Next = null;
        Previous = null;
    }
}

// DoublyCircularLinkedList class: Implements a doubly circular linked list (train of wagons)
public class DoublyCircularLinkedList
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
            // The first node points to itself in both directions to start the circle
            newNode.Next = Head;
            newNode.Previous = Tail;
            return;
        }

        // Link the current tail's Next pointer to the new node
        Tail.Next = newNode;
        // Link the new node's Previous pointer back to the old tail
        newNode.Previous = Tail;

        // Update the Tail to be the new last node
        Tail = newNode;
        
        // Close the circle by linking the new Tail and the Head
        Tail.Next = Head;
        Head.Previous = Tail;
    }

    // Prints all nodes (wagons) in forward order, starting from the Head and traversing the circle once.
    public void PrintForward()
    {
        if (Head == null)
        {
            Console.WriteLine("Doubly Circular Linked List is empty.");
            return;
        }

        Console.Write("Forward Traversal : ");
        var current = Head;
        do
        {
            Console.Write($"{current.Data} <-> ");
            current = current.Next;
        } while (current != Head);
        // Shows the final link from the tail back to the head
        Console.Write($"(Back To Head: {current.Data})");
    }
    
    // Prints all nodes (wagons) in reverse order, starting from the Tail and traversing the circle once.
    public void PrintBackward()
    {
        if (Head == null)
        {
            Console.WriteLine("Doubly Circular Linked List is empty.");
            return;
        }

        Console.Write("Backward Traversal: ");
        var current = Tail;
        do
        {
            Console.Write($"{current.Data} <-> ");
            current = current.Previous;
        } while (current != Tail);
        // Shows the final link from the head back to the tail
        Console.Write($"(Back To Tail: {current.Data})");
    }
}

// Program class: Demonstrates usage of the custom doubly circular linked list
public class Program
{
    public static void Main(string[] args)
    {
        // Create a new instance of our linked list (the train)
        var train = new DoublyCircularLinkedList();

        // Add nodes (wagons) to the linked list (train)
        train.AddLast(10);
        train.AddLast(20);
        train.AddLast(30);

        Console.WriteLine("Train contents:");

        // Print the list forwards to verify its contents and structure
        train.PrintForward();
        Console.WriteLine();
        
        // Print the list backwards to verify its contents and structure
        train.PrintBackward();
    }
}