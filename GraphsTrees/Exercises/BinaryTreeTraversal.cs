using System;
using DataStructures;

namespace Exercises
{

    class BinarTreeTraversal
    {

        public static void notMain(string[] args)
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

            BinarTreeTraversal program = new BinarTreeTraversal();

            Console.WriteLine("================= In Order Traversal =================");
            program.inOrderTraversal(root);

            Console.WriteLine("================= Pre Order Traversal =================");
            program.preOrderTraversal(root);

            Console.WriteLine("================= Post Order Traversal =================");
            program.postOrderTraversal(root);
        }

        public void inOrderTraversal(BinaryNode<char> root)
        {
            if(root != null)
            {
                inOrderTraversal(root.leftChild);
                Console.WriteLine(root.data);
                inOrderTraversal(root.rightChild);
            }
        }

        public void preOrderTraversal(BinaryNode<char> root)
        {
            if(root != null)
            {
                Console.WriteLine(root.data);
                preOrderTraversal(root.leftChild);
                preOrderTraversal(root.rightChild);
            }
        }

        public void postOrderTraversal(BinaryNode<char> root)
        {
            if(root != null)
            {
                postOrderTraversal(root.leftChild);
                postOrderTraversal(root.rightChild);
                Console.WriteLine(root.data);
            }
        }
    }
}