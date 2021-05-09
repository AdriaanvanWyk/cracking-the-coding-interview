using System;
using DataStructures;
using System.Collections;

namespace Exercises {

    class Exercise2_8 
    {

        static void Main(string[] args)
        {

            SinglyLinkedList ssl = new SinglyLinkedList(6);
            ssl.appendToList(3);
            ssl.appendToList(8);

            ssl.appendToList(9);
            ssl.appendToList(4);
            ssl.appendToList(5);

            ssl.head.next.next.next.next.next.next = ssl.head.next.next;

            Exercise2_8 e8 = new Exercise2_8();

            Console.WriteLine(e8.getLoopStartNode(ssl).data);
        }

        Node getLoopStartNode(SinglyLinkedList inputList)
        {
            
            Hashtable ht = new Hashtable();

            Node currentNode = inputList.head;
            while(true)
            {

                Console.Write($"{currentNode.data} -> ");
                if(ht[currentNode] == null)
                {
                    ht.Add(currentNode, true);
                }
                else
                {
                    return currentNode;
                }

                currentNode = currentNode.next;
            }
        }
    }