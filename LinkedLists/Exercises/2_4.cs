using System;
using DataStructures;

namespace Exercises
{

    class Exercise2_4
    {

        static void notMain(string[] args)
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
            sll.appendToList(5);

            sll.printList();

            Exercise2_4 e4 = new Exercise2_4();

            e4.partitionList(sll, 7);

            sll.printList();


        }

        void partitionList(SinglyLinkedList inputList, int pivotValue)
        {

            SinglyLinkedList listAbovePivot = new SinglyLinkedList();
            SinglyLinkedList listBelowPivot = new SinglyLinkedList();

            Node currentNode = inputList.head;
            Node lastBelowPivotNode = new Node(0);

            while(currentNode != null)
            {

                if(currentNode.data < pivotValue)
                {
                    listBelowPivot.appendToList(currentNode.data);
                }
                else
                {
                    listAbovePivot.appendToList(currentNode.data);
                }

                currentNode = currentNode.next;
                
            }

            inputList.head = listBelowPivot.head;
            listBelowPivot.tail.next = listAbovePivot.head;
        }
    }
}