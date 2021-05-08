
using System;
using Datastructures;

namespace Exercises
{

    class Exercise3_3
    {

        public static void notMain(string[] args)
        {

            SetOfStacks<int> sos = new SetOfStacks<int>(3);

            sos.push(1);
            sos.push(1);
            sos.push(1);

            sos.push(2);
            sos.push(2);
            sos.push(2);

            sos.push(3);
            sos.push(3);
            sos.push(3);

            sos.push(4);
            sos.push(4);

            sos.pop();
            sos.pop();
            sos.pop();
            sos.pop();

            sos.pop(1);

            sos.push(5);
            sos.push(5);
        }
    }
}