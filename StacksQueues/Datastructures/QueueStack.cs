using System;


namespace Datastructures
{

    public class QueueStack<T>
    {

        private Stack<T> queueStack;
        private Stack<T> tempStack;

        public QueueStack()
        {

            queueStack = new Stack<T>();
            tempStack = new Stack<T>();
        }

        public void queue(T input)
        {

            if(queueStack.isEmpty())
            {
                queueStack.push(input);
            }
            else
            {
                while(!queueStack.isEmpty())
                {
                    tempStack.push(queueStack.pop());
                }

                queueStack.push(input);

                while(!tempStack.isEmpty())
                {
                    queueStack.push(tempStack.pop());
                }

            }

        }

        public T dequeue()
        {
            if(!queueStack.isEmpty())
            {
                return queueStack.pop();
            }
            
            throw new Exception();
            
        }
    }

}