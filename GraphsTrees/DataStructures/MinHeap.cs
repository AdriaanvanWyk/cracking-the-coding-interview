using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructures
{

    public class MinHeap
    {
        private List<int> graphArray;

        public MinHeap()
        {
            graphArray = new List<int>();
        }

        public void insert(int input)
        {
            graphArray.Add(input);

            if(graphArray.Count > 0)
            {
                int parentIndex = (graphArray.IndexOf(input)-1)/2;
                int inputeIndex = graphArray.IndexOf(input);
                int newParentIndex;

                while(graphArray[parentIndex] > graphArray[inputeIndex])
                {
                    int tmp = graphArray[parentIndex];

                    graphArray[parentIndex] = graphArray[inputeIndex];
                    graphArray[inputeIndex] = tmp;

                    newParentIndex = (parentIndex-1)/2;
                    inputeIndex = parentIndex;
                    parentIndex = newParentIndex;
                    
                }
            }
 
        }

        public int extractMin()
        {
            int lastValue = graphArray[graphArray.Count-1]; 
            int min = graphArray[0];

            graphArray[0] = lastValue;
            graphArray.RemoveAt(graphArray.Count-1);


            int currentIndex = 0;
            int leftChildIndex = getLeftChildIndex(currentIndex);
            int rightChildIndex = getRightChildIndex(currentIndex);

            while(graphArray[currentIndex] > graphArray[leftChildIndex] || graphArray[currentIndex] > graphArray[rightChildIndex])
            {

                int smallestChildIndex = getSmallestChildIndex(currentIndex);
                if(graphArray[currentIndex] > graphArray[smallestChildIndex])
                {
                    swapNodes(currentIndex, smallestChildIndex);
                    currentIndex = smallestChildIndex;
                }
                else
                {
                    break;
                }

                leftChildIndex = getLeftChildIndex(currentIndex);
                rightChildIndex = getRightChildIndex(currentIndex);

                if(currentIndex >= graphArray.Count || leftChildIndex >= graphArray.Count)
                {
                    break;
                }
            }

            return min;
        }

        private int getLeftChildIndex(int parentIndex)
        {
            return 2 * parentIndex + 1;
        }

        private int getRightChildIndex(int parentIndex)
        {
            return 2 * parentIndex + 2;
        }

        private void swapNodes(int node1, int node2)
        {
            int tmpVal = graphArray[node1];
            graphArray[node1] = graphArray[node2];
            graphArray[node2] = tmpVal;
        }

        private int getSmallestChildIndex(int nodeIndex)
        {
            if(getLeftChildIndex(nodeIndex) >= graphArray.Count)
            {
                return nodeIndex;
            }
            
            if(getRightChildIndex(nodeIndex) >= graphArray.Count)
            {
                return getLeftChildIndex(nodeIndex);
            }
            else
            {
                return graphArray[getLeftChildIndex(nodeIndex)] < graphArray[getRightChildIndex(nodeIndex)] ? getLeftChildIndex(nodeIndex) : getRightChildIndex(nodeIndex);
            }
        }
        

    }
}