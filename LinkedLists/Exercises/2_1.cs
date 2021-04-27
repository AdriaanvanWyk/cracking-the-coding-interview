using DataStructures;
using System;

namespace Exercises
{

    class Exercise2_1
    {

        static void Mains(string[] args)
        {
            SinglyLinkedList sll = new SinglyLinkedList(3);

            sll.appendToList(33);
            sll.appendToList(3);
            sll.appendToList(4);
            sll.appendToList(8);
            sll.appendToList(1);
            sll.appendToList(1);
            sll.appendToList(9);
            sll.appendToList(33);
            sll.appendToList(33);

            sll.printList();

            Node currentNode = sll.head;
            Node searchNode = currentNode.next;
            Node previousNode = currentNode.next;
            
            while(currentNode != null)
            {
                

                while(searchNode != null)
                {
                    
                    if(currentNode.data == searchNode.data)
                    {
                        previousNode.next = searchNode.next;
                        searchNode = previousNode.next;
                    }
                    else
                    {
                        previousNode = searchNode;
                        searchNode = searchNode.next;
                    }

                    
                }

                currentNode = currentNode.next;

                if(currentNode != null)
                {
                    searchNode = currentNode.next;
                    previousNode = currentNode;
                }

            }

            sll.printList();
        }
    }
}

