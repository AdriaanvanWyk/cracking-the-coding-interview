using System;
using DataStructures;

namespace Exercises
{

    class Exercise2_5
    {

        static void Main(string[] args)
        {

            SinglyLinkedList L1 = new SinglyLinkedList(6);
            L1.appendToList(8);
            L1.appendToList(1);

            SinglyLinkedList L2 = new SinglyLinkedList(5);
            L2.appendToList(3);
            L2.appendToList(7);
            L2.appendToList(7);

            Exercise2_5 e5 = new Exercise2_5();

            
            SinglyLinkedList summedLists = e5.sumLists(L1, L2);

            summedLists.printList();


        }

        SinglyLinkedList sumLists(SinglyLinkedList L1, SinglyLinkedList L2)
        {

            Node currentNode1 = L1.head;
            Node currentNode2 = L2.head;

            SinglyLinkedList summedLists = new SinglyLinkedList();

            bool carryOne = false;
            int currentSum = 0;

            while(currentNode1 != null && currentNode2 != null)
            {
                
                currentSum = currentNode1.data + currentNode2.data;

                if(carryOne)
                {
                    currentSum += 1;
                    carryOne = false;
                }

                if(currentSum > 10)
                {
                    carryOne = true;
                    currentSum = currentSum-10;
                }

                summedLists.appendToList(currentSum);

                currentNode1 = currentNode1.next;
                currentNode2 = currentNode2.next;

            }

            while(currentNode1 != null)
            {
                summedLists.appendToList(currentNode1.data);
                currentNode1 = currentNode1.next;
            }

            while(currentNode2 != null)
            {
                summedLists.appendToList(currentNode2.data);
                currentNode2 = currentNode2.next;
            }

            return summedLists;
            
        }
    }
}