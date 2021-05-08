using System;
using System.Collections;
using System.Collections.Generic;

namespace Datastructures
{
    public class MinStack
    {
        private class Node
        {   
            public Node(int t)
            {
                data = t;
            }

            private int data;

            public int Data
            {
                get { return data;}
            }
        }

        private class EmptyStackException : Exception
        {
            public EmptyStackException()
            {
            }

            public EmptyStackException(string message)
                : base(message)
            {
            }

            public EmptyStackException(string message, Exception inner)
                : base(message, inner)
            {
            }
        }


        private List<Node> stack;
        private List<int> minValues;
        private int top = -1;
        private int minValue;
        public MinStack()
        {
            stack = new List<Node>();
            minValues = new List<int>();

        }

        public int pop()
        {
            if(top < 0) throw new EmptyStackException("Stack is Empty, cannot remove any more elements");
            Node tempNode = stack[top];
            stack.RemoveAt(top);
            top -= 1;
            
            if(tempNode.Data == minValue)
            {
                minValues.Remove(minValue);
            }

            return tempNode.Data;
        }

        public void push(int t)
        {
            if(top == -1)
            {
                minValue = t;
                minValues.Add(t);

            }
            else if(t < minValue)
            {
                minValue = t;
                minValues.Add(t);
            }
            Node newNode = new Node(t);
            stack.Add(newNode);
            top += 1;
        }

        public int peek()
        {
            if(top < 0) throw new EmptyStackException("Stack is Empty, cannot show any elements");
            return stack[top].Data;
        }

        public int min()
        {
            
            return minValues[minValues.Count-1];
        }

        public bool isEmpty()
        {
            return top < 0 ? true : false;
        }
        
    }

    
}
