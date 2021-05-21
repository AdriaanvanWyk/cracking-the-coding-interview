using System;
using DataStructures;

namespace Exercises
{

    class Exercise4_1
    {
        public static void notMain(string[] args)
        {
            DirectedGraph dg = new DirectedGraph();

            Node one = new Node("One");
            Node two = new Node("Two");
            Node three = new Node("Three");
            Node four = new Node("Four");
            Node five = new Node("Five");
            Node six = new Node("Six");
            Node seven = new Node("Seven");
            Node eight = new Node("Eight");
            Node nine = new Node("Nine");
            Node ten = new Node("ten");

            one.addChild(two);
            one.addChild(ten);

            two.addChild(three);
            two.addChild(four);
            two.addChild(seven);

            four.addChild(three);
            four.addChild(five);

            six.addChild(three);

            seven.addChild(two);

            eight.addChild(nine);
            nine.addChild(eight);

            ten.addChild(seven);

            dg.addNode(one);
            dg.addNode(two);
            dg.addNode(three);
            dg.addNode(four);
            dg.addNode(five);
            dg.addNode(six);
            dg.addNode(seven);
            dg.addNode(eight);
            dg.addNode(nine);

            Console.WriteLine(dg.ToString());

            dg.isPathBetweenNodes(one, five, false);


        }
    }
}