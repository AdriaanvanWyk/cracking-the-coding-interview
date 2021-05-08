using System;
using Datastructures;
using System.Collections;
using System.Collections.Generic;

namespace Datastructures
{

    public class SetOfStacks<T>
    {

        List<Stack<T>> setOfStacks;
        private int maxPerStack;

        public SetOfStacks(int maxPerStack)
        {
            this.maxPerStack = maxPerStack;
            setOfStacks = new List<Stack<T>>();
        }

        private void addStack()
        {
            Stack<T> newStack = new Stack<T>();
            setOfStacks.Add(newStack);
        }

        public void push(T t)
        {

            foreach(Stack<T> stack in setOfStacks)
            {
                if(stack.stackSize < maxPerStack)
                {
                    stack.push(t);
                    return;
                }
            }
            
            addStack();

            setOfStacks[(setOfStacks.Count-1)].push(t);
            
        }

        public T pop()
        {
            T returnValue = setOfStacks[(setOfStacks.Count-1)].pop();

            if(setOfStacks[(setOfStacks.Count-1)].stackSize == 0)
            {
                setOfStacks.RemoveAt((setOfStacks.Count-1));
            }

            return returnValue;

        }

        public T pop(int index)
        {

            if(index > (setOfStacks.Count-1) || index < 0)
            {
                throw new IndexOutOfRangeException("Not that many stacks");
            }

            T returnValue = setOfStacks[index].pop();

            if(setOfStacks[index].stackSize == 0)
            {
                setOfStacks.RemoveAt(index);
            }
            
            return returnValue;

            

        }

        public void printStacks()
        {

            foreach(Stack<T> stack in setOfStacks)
            {
                stack.printStack();
            }
        }

    }
}
