// Implement a function to check if a linked list is a palindrome
using System;
using DataStructures;

namespace Exercises {

    class Exercise2_6 {

        static void Main(string[] args)
        {

            SinglyLinkedList sll = new SinglyLinkedList();

            Exercise2_6 e6 = new Exercise2_6();

            sll.printList();
            Console.WriteLine(e6.isPalindrome(sll));

        }


        bool isPalindrome(SinglyLinkedList inputList)
        {

            Node currentNode = inputList.head;
            // Reverse Linked List
            SinglyLinkedList reversedList = new SinglyLinkedList();

            while(currentNode != null)
            {
                Node tempNode = new Node(currentNode.data);
                tempNode.next = reversedList.head;
                reversedList.head = tempNode;
                currentNode = currentNode.next;
            }
            reversedList.printList();

            currentNode = inputList.head;
            Node currentReverseNode = reversedList.head;

            while(currentNode != null)
            {
                if(currentNode.data != currentReverseNode.data)
                {
                    return false;
                }

                currentNode = currentNode.next;
                currentReverseNode = currentReverseNode.next;
            }

            return true;
        }
    }
}