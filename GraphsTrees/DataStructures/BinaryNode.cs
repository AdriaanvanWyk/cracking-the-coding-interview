using System;

namespace DataStructures
{
    public class BinaryNode<T>
    {
        public T data;
        public BinaryNode<T> leftChild;
        public BinaryNode<T> rightChild;

        
        public BinaryNode(T data)
        {
            this.data = data;
            leftChild = null;
            rightChild = null;
        }


    }
}
