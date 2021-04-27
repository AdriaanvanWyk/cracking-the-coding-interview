using System;
using DataStructures;

namespace Exercises
{

    class Exercise2_2
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
            sll.appendToList(33);

            sll.printList();

            Exercise2_2 e2 = new Exercise2_2();

            e2.getNthFromLast(sll, 5);


        }

        void getNthFromLast(SinglyLinkedList inputList, int nthToGet)
        {
            
            Node nthNode = inputList.head;

            int currentElementCount = 0;

            Node currentNode = inputList.head;

            while(currentNode != null)
            {
                if(currentElementCount > nthToGet)
                {
                    nthNode = nthNode.next;
                }

                currentElementCount += 1;
                
                currentNode = currentNode.next;
            }
            
            if(currentElementCount < nthToGet)
            {
                Console.WriteLine("Not enough nodes in the list");
            }
            else
            {
                Console.WriteLine($"Data from Nth Node is: {nthNode.data}");
            }
        }
    }
}