using System;
using DataStructures;
using System.Collections.Generic;


namespace Exercises
{

    class Exercise4_2
    {

        public static void notMain(string[] args)
        {

            int[] sortedArray = {2, 4, 5, 8, 9, 10, 33, 40, 62, 66, 67, 69, 70, 75, 80, 85, 90, 91, 101, 131};


            
            Exercise4_2 program = new Exercise4_2();
            BinaryNode<int> root = program.createBinarySearchTree(sortedArray);


        }

        public BinaryNode<int> createBinarySearchTree(int[] sortedArray)
        {
            Index rootIndex = sortedArray.Length/2;

            BinaryNode<int> root = new BinaryNode<int>(sortedArray[sortedArray.Length/2]);

            if(sortedArray.Length == 1)
            {
                return root;
            }
            else if(sortedArray.Length == 2)
            {
                root.leftChild = new BinaryNode<int>(sortedArray[0]);
                return root;
            }
            else if(sortedArray.Length == 3)
            {
                root.leftChild = new BinaryNode<int>(sortedArray[0]);
                root.rightChild = new BinaryNode<int>(sortedArray[2]);
                return root;
            }


            root.leftChild = createBinarySearchTree(sortedArray[0..rootIndex]);
            root.rightChild = createBinarySearchTree(sortedArray[(rootIndex.Value+1)..sortedArray.Length]);

            return root;

        }
    }
}