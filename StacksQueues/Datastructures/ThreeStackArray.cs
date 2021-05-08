using Datastructures;
using System;
using System.Text;



namespace Datastructures
{

    public class ThreeStackArray
    {

        private Node<char>[] theArray; 
        private int stack1Top;
        private int stack2TopLeft;
        private int stack2TopRight;
        private int stack3Top;
        private Stack<int> stack2Top;
        private int stack2Size;
        
        public ThreeStackArray(int arrayLength)
        {
            theArray = new Node<char>[arrayLength];
            stack1Top = 0;
            stack2TopLeft = arrayLength/2;
            stack2TopRight = arrayLength/2+1;
            stack3Top = arrayLength-1;
            stack2Top = new Stack<int>();
            stack2Size = 0;
        }


        public void addToStack1(char inputChar)
        {

            Node<char> newNode = new Node<char>(inputChar);

            if(stack2TopLeft - stack1Top > 0)
            {
                theArray[stack1Top] = newNode;
                stack1Top += 1;
            }
            else if(stack2Size == 0)
            {
                stack2TopLeft += 1;
                stack2TopRight  += 1;
                theArray[stack1Top] = newNode;
                stack1Top += 1;
            }
            else
            {
                throw new IndexOutOfRangeException("Stack 1 is full");
            }
        }

        public void addToStack3(char inputChar)
        {

            Node<char> newNode = new Node<char>(inputChar);

            if(stack3Top - stack2TopRight >= 0)
            {
                theArray[stack3Top] = newNode;
                stack3Top -= 1;
            }
            else if(stack2Size == 0)
            {
                stack2TopLeft -= 1;
                stack2TopRight  -= 1;
                theArray[stack3Top] = newNode;
                stack3Top -= 1;
            }
            else
            {
                throw new IndexOutOfRangeException("Stack 1 is full");
            }
        }


        public void addToStack2(char inputChar)
        {

            Node<char> newNode = new Node<char>(inputChar);

            int spaceOnRight = stack3Top - stack2TopRight;
            int spaceOnLeft = stack2TopLeft - stack1Top;

            if(spaceOnLeft < 0 && spaceOnRight < 0)
            {
                throw new IndexOutOfRangeException("No space to add to stack 2");
            }

            if(spaceOnLeft >= spaceOnRight)
            {
                theArray[stack2TopLeft] = newNode;
                stack2Top.push(stack2TopLeft);
                stack2TopLeft -= 1;
                
            }
            else
            {
                theArray[stack2TopRight] = newNode;
                stack2Top.push(stack2TopRight);
                stack2TopRight += 1;
            }

            stack2Size += 1;
        }

        public Node<char> popStack1()
        {
            if(stack1Top <= 0)
            {
                throw new IndexOutOfRangeException("Stack 1 is empty");
            }

            stack1Top -= 1;

            Node<char> returnNode = theArray[stack1Top];
            theArray[stack1Top] = null;
            return returnNode;
        }

        public Node<char> popStack3()
        {
            if(stack3Top >= theArray.Length)
            {
                throw new IndexOutOfRangeException("Stack 3 is empty");
            }

            stack3Top += 1;

            Node<char> returnNode = theArray[stack3Top];
            theArray[stack3Top] = null;
            return returnNode;
        }

        public Node<char> popStack2()
        {

            if(stack2Size <= 0)
            {
                throw new IndexOutOfRangeException("Stack 2 is empty");
            }

            int top = stack2Top.pop();
            Node<char> returnNode = theArray[top];

            if(top == (stack2TopLeft+1))
            {
                stack2TopLeft += 1;
                theArray[stack2TopLeft] = null;
            }
            else if(top == (stack2TopRight-1))
            {
                stack2TopRight -= 1;
                theArray[stack2TopRight] = null;
            }

            return returnNode;
        }

        public void printThisArray()
        {

            StringBuilder sb = new StringBuilder();

            foreach(Node<char> element in theArray)
            {
                try
                {
                    sb.Append(element.Data);
                    sb.Append(" ");
                }
                catch (System.NullReferenceException)
                {
                    sb.Append("Null");
                    sb.Append(" ");
                }
                    

            }

            Console.WriteLine(sb.ToString());
        }
    }
}