using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{

    public class Node
    {
        public string name;
        public List<Node> children;

        public Node(string name)
        {
            this.name = name;
            children = new List<Node>();
        }

        public void addChild(Node n)
        {
            children.Add(n);
        }
        
    }
}