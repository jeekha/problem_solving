/***********************************************************************************************************************
Write a GetNth() function that takes a linked list and an integer index and returns the data value stored in the node at that index position. 
***********************************************************************************************************************/
public class NthNode
{
    public void Output()
    {
        int index = 3;
        Solution(index);
    }

    private void Solution(int index)
    {

        LinkedList linkedList = new LinkedList();
        linkedList.Push(1);
        linkedList.Push(2);
        linkedList.Push(3);
        linkedList.Push(4);

        Console.WriteLine("Data is :" + linkedList.GetNthItem(0) + linkedList.GetNthItem(1) + linkedList.GetNthItem(2) + linkedList.GetNthItem(3));
    }
}

public class LinkedList
{
    Node head;
    public int GetNthItem(int index)
    {
        Node current = head;
        int count = 0;
        while (current != null)
        {
            if (count == index)
                return current.Data;

            current = current.Next;
            count++;
        }
        return -1;
    }

    public void Push(int data)
    {
        Node newNode = new Node(data);
        newNode.Next = head;
        head = newNode;
    }
}
public class Node
{
    public Node Next { get; set; }
    public int Data { get; set; }
    public Node(int data)
    {
        this.Data = data;
    }
}