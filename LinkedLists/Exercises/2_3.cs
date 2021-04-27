using System;
using DataStructures;

namespace Exercises
{

    class Exercise2_3
    {

        static void Main(string[] args)
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

            Exercise2_3 e3 = new Exercise2_3();

            // Delete 8
            e3.deleteNode(sll.head.next.next.next.next);
            
            sll.printList();

        }


        bool deleteNode(Node node)
        {

            if(node == null || node.next == null)
            {
                return false;
            }

            node.data = node.next.data;
            node.next = node.next.next;

            return true;
        }
    }
}