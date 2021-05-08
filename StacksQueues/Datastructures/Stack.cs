using System;
using System.Collections;
using System.Collections.Generic;

namespace Datastructures
{
    public class Stack<T>
    {
        private class Node
        {   
            public Node(T t)
            {
                data = t;
            }

            private T data;

            public T Data
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
        private int top = -1;
        public Stack()
        {
            stack = new List<Node>();

        }



        public T pop()
        {
            if(top < 0) throw new EmptyStackException("Stack is Empty, cannot remove any more elements");
            Node tempNode = stack[top];
            stack.RemoveAt(top);
            top -= 1;

            return tempNode.Data;
        }

        public void push(T t)
        {
            Node newNode = new Node(t);
            stack.Add(newNode);
            top += 1;
        }

        public T peek()
        {
            if(top < 0) throw new EmptyStackException("Stack is Empty, cannot show any elements");
            return stack[top].Data;
        }

        public bool isEmpty()
        {
            return top < 0 ? true : false;
        }
        
    }

    public class Queue<T>
    {
        private class Node
        {   
            public Node(T t)
            {
                data = t;
            }

            private T data;

            public T Data
            {
                get { return data;}
            }
        }

        private class EmptyQueueException : Exception
        {
            public EmptyQueueException()
            {
            }

            public EmptyQueueException(string message)
                : base(message)
            {
            }

            public EmptyQueueException(string message, Exception inner)
                : base(message, inner)
            {
            }
        }


        private List<Node> queue_list;
        private int tail = -1;
        private const int head = 0;
        private int size = 0;
        public Queue()
        {
            queue_list = new List<Node>();
        }



        public void queue(T newElement)
        {
            
            Node newNode = new Node(newElement);
            
            queue_list.Add(newNode);

            tail = tail + 1;
        }

        public T dequeue()
        {
            Node headNode = queue_list[head];
            
            this.shiftElementsLeft();

            return headNode.Data;
        }

        private void shiftElementsLeft()
        {

            for(int i=0; i < tail; i++)
            {
                queue_list[i] = queue_list[i+1];
            }

            tail = tail -1;
        }
    }

    
}
