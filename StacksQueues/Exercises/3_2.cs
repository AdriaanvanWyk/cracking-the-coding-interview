using System;
using Datastructures;

namespace Exercises
{

    class Exercise3_2
    {

        public static void notMain(string[] args)
        {

            MinStack minStack = new MinStack();

            minStack.push(1);
            minStack.push(5);
            minStack.push(111);
            minStack.push(150);
            minStack.push(1000);
            minStack.push(12983);
            minStack.push(-5);

            minStack.pop();
            minStack.pop();
            minStack.pop();
            minStack.pop();
            minStack.pop();
            minStack.pop();



            Console.WriteLine();

        }
    }
}