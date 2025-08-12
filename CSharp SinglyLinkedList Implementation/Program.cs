// Node class: Represents a node (wagon) in the singly linked list (train)
public class Node
{
    // Value stored in this node (wagon)
    public int Data { get; set; }

    // Reference to the next node (wagon) in the list
    public Node Next { get; set; }

    // Initializes a node with the given value
    public Node(int data)
    {
        Data = data;
        Next = null;
    }
}

// MyLinkedList class: Implements a singly linked list (train of wagons)
public class MyLinkedList
{
    // Reference to the first node (head/engine) of the list
    public Node Head { get; private set; }

    // Adds a new node (wagon) with the specified value to the end of the list
    public void AddLast(int data)
    {
        var newNode = new Node(data);

        if (Head == null)
        {
            Head = newNode;
            return;
        }

        var current = Head;
        // Traverse to the last node (wagon)
        while (current.Next != null)
        {
            current = current.Next;
        }

        // Attach the new node (wagon) at the end
        current.Next = newNode;
    }

    // Prints all nodes (wagons) in the list from head to tail
    public void Print()
    {
        var current = Head;
        while (current != null)
        {
            Console.Write($"{current.Data}->");
            current = current.Next;
        }
        Console.WriteLine("null");
    }
}

// Program class: Demonstrates usage of the custom linked list
public class Program
{
    public static void Main(string[] args)
    {
        var train = new MyLinkedList();

        // Add nodes (wagons) to the linked list (train)
        train.AddLast(10);
        train.AddLast(20);
        train.AddLast(30);

        Console.WriteLine("Train contents :");

        // Print the linked list (train)
        train.Print();
    }
}