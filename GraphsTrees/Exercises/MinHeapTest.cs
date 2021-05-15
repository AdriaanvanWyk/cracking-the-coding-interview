using System;
using DataStructures;

namespace Exercises
{

    class MinHeapTest
    {

        public static void Main(string[] args)
        {
            MinHeap mh = new MinHeap();

            mh.insert(3);
            mh.insert(32);
            mh.insert(5);
            mh.insert(43);
            mh.insert(98);
            mh.insert(439);
            mh.insert(62);
            mh.insert(22);
            mh.insert(8);
            mh.insert(75);
            mh.insert(9);
            mh.insert(1);
            mh.insert(44);
            mh.insert(52);
            mh.insert(31);

            // Mins 1, 3, 5, 8, 9

            Console.WriteLine(mh.extractMin());
            Console.WriteLine(mh.extractMin());
            Console.WriteLine(mh.extractMin());
            Console.WriteLine(mh.extractMin());
            Console.WriteLine(mh.extractMin());
            Console.WriteLine(mh.extractMin());
        }
        
    }
}