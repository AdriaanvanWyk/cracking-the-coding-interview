using System;
using Datastructures;
using System.Collections;
using System.Collections.Generic;

namespace Exercises
{

    class Exercise3_1
    {

        static void notMain(string[] args)
        {

            int arrayLength = 10;
            
            ThreeStackArray theStack = new ThreeStackArray(arrayLength);

            theStack.addToStack1('a');
            theStack.addToStack1('b');
            theStack.addToStack1('c');

            theStack.addToStack2('a');
            theStack.addToStack2('b');
            theStack.addToStack2('c');

            theStack.addToStack3('a');
            theStack.addToStack3('b');

            theStack.addToStack2('d');
            theStack.addToStack2('e');


            Console.WriteLine(theStack.popStack3().Data);
            Console.WriteLine(theStack.popStack1().Data);
            Console.WriteLine(theStack.popStack1().Data);
            Console.WriteLine(theStack.popStack1().Data);

            Console.WriteLine(theStack.popStack2().Data);
            Console.WriteLine(theStack.popStack2().Data);
            Console.WriteLine(theStack.popStack2().Data);
            Console.WriteLine(theStack.popStack2().Data);

            Console.WriteLine(theStack.popStack3().Data);


            Console.WriteLine();
        }
    }
}