using System;
using Datastructures;


namespace Exercises
{

    class Exercise3_4
    {

        public static void Main(string[] args)
        {

            QueueStack<char> qs = new QueueStack<char>();

            qs.queue('a');
            qs.queue('b');
            qs.queue('c');

            Console.WriteLine(qs.dequeue());
            qs.queue('d');
            qs.queue('e');
            qs.queue('f');

            Console.WriteLine(qs.dequeue());
            Console.WriteLine(qs.dequeue());
            Console.WriteLine(qs.dequeue());
            Console.WriteLine(qs.dequeue());
            Console.WriteLine(qs.dequeue());
            Console.WriteLine(qs.dequeue());




            

        }
    }
}