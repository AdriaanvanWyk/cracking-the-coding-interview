// Return the intersecting node of two linked lists

// I used a hash table for this which requires a pass through each list tossing in the hash of each object into it
// If the hash has already been filled by the other list's nodes, there are intersecting nodes

// The book recommends a O(A+B) time and O(1) space approach
// If the the last node is the same, then the two lists must have an intersection
// Cut off the extra nodes off the longer list (if any) and then iterate through the lists simultaneously 
using System;
using DataStructures;
using System.Collections;

namespace Exercises
{

    class Exercise2_7
    {

        static void notMain(string[] args)
        {
            Node intersectingNode = new Node(66);
            SinglyLinkedList L1 = new SinglyLinkedList(6);
            L1.appendToList(8);
            L1.appendToList(1);
            L1.appendToList(4);

            SinglyLinkedList L2 = new SinglyLinkedList(5);
            L2.appendToList(3);
            L2.appendToList(7);

            L1.head.next.next.next.next = intersectingNode;
            L2.head.next.next.next = intersectingNode;

            L1.appendToList(55);
            L1.appendToList(44);

            L1.printList();
            L2.printList();

            Exercise2_7 e7 = new Exercise2_7();

            Console.WriteLine(e7.getIntersectingNode(L1, L2).data);
        }

        Node getIntersectingNode(SinglyLinkedList list1, SinglyLinkedList list2)
        {

            Node currNode1 = list1.head;
            Node currNode2 = list2.head;
            Node intersectNode = new Node(1);
            Hashtable ht = new Hashtable();
            
            while(currNode1 != null && currNode2 != null)
            {

                if(ht[currNode1] == null)
                {
                    ht.Add(currNode1, true);
                }
                else if((bool)ht[currNode1])
                {
                    return currNode1;
                }

                if(ht[currNode2] == null)
                {
                    ht.Add(currNode2, true);
                }
                else if((bool)ht[currNode2])
                {
                    return currNode2;
                }
                currNode1 = currNode1.next;
                currNode2 = currNode2.next;
            }

            return intersectNode;
        }
    }
}