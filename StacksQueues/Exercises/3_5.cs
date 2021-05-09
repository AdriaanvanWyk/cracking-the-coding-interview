using System;
using Datastructures;

// Initial solution was a bit more needlessly complex but followed the exact same logic
namespace Exercises
{


    public class Exercise3_5
    {

        public static void Main(string[] args)
        {

            Stack<int> stackToSort = new Stack<int>();
            Stack<int> tempStack = new Stack<int>();

            stackToSort.push(3);
            stackToSort.push(2);
            stackToSort.push(8);
            stackToSort.push(1);
            stackToSort.push(4);
            stackToSort.push(9);
            stackToSort.push(6);
            stackToSort.push(5);
            stackToSort.push(7);


            

            while(!stackToSort.isEmpty())
            {
                int currentValue = stackToSort.pop();
                while(!tempStack.isEmpty() && currentValue < tempStack.peek())
                {
                    stackToSort.push(tempStack.pop());
                }
                tempStack.push(currentValue);

                

                
            }

            while(!tempStack.isEmpty())
            {
                stackToSort.push(tempStack.pop());
            }

            Console.WriteLine("----- Initial Stack -----");
            stackToSort.printStack();

            Console.WriteLine("----- Temp Stack -----");
            tempStack.printStack();

            Console.WriteLine("\n\n");
        }
    }
}