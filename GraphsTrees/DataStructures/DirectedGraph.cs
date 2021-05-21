using System;
using System.Text;
using System.Collections.Generic;

namespace DataStructures
{

    public class DirectedGraph
    {
        public List<Node> nodes;

        public DirectedGraph()
        {
            nodes = new List<Node>();
        }

        public void addNode(Node n)
        {
            nodes.Add(n);
        }


        public bool isPathBetweenNodes(Node n1, Node n2, bool useDFS=false)
        {

            List<Node> visitedNodes = new List<Node>();
            bool isPath = false;

            if(useDFS)
            {
                // Use Depth First Search
                void dfsSearch(Node root)
                {
                    if(root == null) return;
                    if(isPath) return;
                    Console.WriteLine($"Current Node: {root.name}");
                    visitedNodes.Add(root);
                    if(root.name.Equals(n2.name))
                    {
                        isPath = true;
                        return;
                    }

                    foreach(Node child in root.children)
                    {
                        if(!visitedNodes.Contains(child))
                        {
                            dfsSearch(child);
                        }
                    }

                    

                }

                dfsSearch(n1);
                if(isPath)
                {
                    Console.WriteLine("There is a path!!");
                }
                else
                {
                    Console.WriteLine("No path found");
                }
                
                return isPath;
            }
            else
            {
                // A breadth first seach
                Queue<Node> searchQueue = new Queue<Node>();
                
                searchQueue.Enqueue(n1);
                Node currentNode;

                while(searchQueue.Count != 0)
                {   
                    currentNode = searchQueue.Dequeue();
                    visitedNodes.Add(currentNode);
                    Console.WriteLine($"Current Node: {currentNode.name}");

                    if(currentNode.name.Equals(n2.name))
                    {
                        Console.WriteLine("There is a path!!");
                        return true;
                    }

                    foreach(Node child in currentNode.children)
                    {
                        if(!visitedNodes.Contains(child))
                        {
                            searchQueue.Enqueue(child);
                        }
                    }
                    
                }
            }
            

            Console.WriteLine("No path found");
            return false;

        }


        override public string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach(Node node in nodes)
            {
                sb.Append($"{node.name}:"); 
                
                foreach(Node child in node.children)
                {
                    sb.Append($"{child.name} ");
                }
                sb.AppendLine();
                    
            }

            return sb.ToString();
        }

        
    }

    
}