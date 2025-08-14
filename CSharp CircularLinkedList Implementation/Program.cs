// Node class: Represents a node (wagon) in the circular linked list (train)
public class Node
{
    // Value stored in this node (wagon)
    public int Data { get; set; }

    // Reference to the next node (wagon) in the list
    public Node Next { get; set; }

    // Constructor: Initializes a node with the given value
    public Node(int data)
    {
        Data = data;
        Next = null;
    }
}

// CircularLinkedList class: Implements a circular linked list (train of wagons)
public class CircularLinkedList
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
            // The first node points to itself to start the circle
            newNode.Next = Head;
            return;
        }

        // Link the current tail to the new node
        Tail.Next = newNode;
        // Make the new node's Next pointer point back to the Head, closing the circle.
        newNode.Next = Head;

        // Update the Tail to be the new last node
        Tail = newNode;
    }

    // Prints all nodes (wagons) in the list, starting from the Head and traversing the circle once.
    public void PrintList()
    {
        if (Head == null)
        {
            Console.WriteLine("Circular Linked List is empty.");
            return;
        }

        Console.Write("Circular Linked List :  ");
        var current = Head;
        do
        {
            Console.Write($"{current.Data} --> ");
            current = current.Next;
        } while (current != Head);
        // Shows the final link from the tail back to the head
        Console.Write($"(Back To Head : {current.Data})");
    }
}

// Program class: Demonstrates usage of the custom circular linked list
public class Program
{
    public static void Main(string[] args)
    {
        // Create a new instance of our linked list (the train)
        var train = new CircularLinkedList();

        // Add nodes (wagons) to the linked list (train)
        train.AddLast(10);
        train.AddLast(20);
        train.AddLast(30);

        Console.WriteLine("Train contents:");

        // Print the list to verify its contents and the circular structure
        train.PrintList();
    }
}