using System;
using DataStructures;
using System.Collections;
using System.Collections.Generic;

namespace Exercises
{

    class Exercise4_3
    {

        public static void Main(string[] args)
        {
            BinaryNode<char> root = new BinaryNode<char>('f');
            BinaryNode<char> b = new BinaryNode<char>('b');
            BinaryNode<char> c = new BinaryNode<char>('c');
            BinaryNode<char> d = new BinaryNode<char>('d');
            BinaryNode<char> e = new BinaryNode<char>('e');
            BinaryNode<char> a = new BinaryNode<char>('a');
            BinaryNode<char> g = new BinaryNode<char>('g');
            BinaryNode<char> h = new BinaryNode<char>('h');
            BinaryNode<char> i = new BinaryNode<char>('i');

            root.leftChild = b;
            root.rightChild = g;

            b.leftChild = a;
            b.rightChild = d;

            d.leftChild = c;
            d.rightChild = e;

            g.rightChild = i;

            i.leftChild = h;


            Exercise4_3 program = new Exercise4_3();
            program.createDepthLinkedLists(root); 


        }

        public void createDepthLinkedLists(BinaryNode<char> root)
        {
            
            List<LinkedList<BinaryNode<char>>> depthChart = new List<LinkedList<BinaryNode<char>>>();

            LinkedList<BinaryNode<char>> currentList = new LinkedList<BinaryNode<char>>();

            
            currentList.AddLast(root);
            
            


            while(currentList.Count != 0)
            {
                depthChart.Add(currentList);
                LinkedList<BinaryNode<char>> nextList = new LinkedList<BinaryNode<char>>();
                LinkedListNode<BinaryNode<char>> currentNode = currentList.First;
                while(currentNode != null)
                {
                    
                    BinaryNode<char> currentValue = currentNode.Value;

                    if(currentValue.leftChild != null)
                    {
                        nextList.AddFirst(currentValue.leftChild);
                    }
                    
                    if(currentValue.rightChild != null)
                    {
                        nextList.AddFirst(currentValue.rightChild);
                    }

                    currentNode = currentNode.Next;
                    
                }

                currentList = nextList;

            }
            

            










        }


    }
}