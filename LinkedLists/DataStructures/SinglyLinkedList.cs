using System;
using System.Text;

public class SinglyLinkedList
{

    public Node head {get; set;}
    public Node tail {get; set;}
    public SinglyLinkedList(int n)
    {
        head = new Node(n);
    }

    public SinglyLinkedList()
    {
        head = null;
    }

    public void appendToList(int n)
    {
        if(head == null)
        {
            head = new Node(n);
            tail = head;
        }
        else
        {
            tail = new Node(n);
            Node currentNode = head;
            while(currentNode.next != null)
            {
                currentNode = currentNode.next;
            }

            currentNode.next = tail;
        }


    }

    public void deleteNode(int d)
    {
        if(head.data == d)
        {
            head = head.next;
        }

        Node currentNode = head.next;
        Node previousNode = head;
        while(currentNode.next != null)
        {
            if(currentNode.data == d)
            {
                previousNode.next = currentNode.next;
                break;
            }
        }
    }

    public void printList()
    {
        Console.WriteLine("\n--- Singly Linked List Elements ---");
        StringBuilder sb = new StringBuilder();
        Node n = head;
        if(head != null)
        {
            sb.Append("HEAD");
            while(n.next != null)
            {
                sb.Append($" -> {n.data}");
                n = n.next;
            }
            
            sb.Append($" -> {n.data}");
        }

        Console.WriteLine(sb.ToString());
        
    }
}