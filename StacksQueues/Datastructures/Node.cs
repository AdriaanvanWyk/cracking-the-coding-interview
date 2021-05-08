
namespace Datastructures
{

    public class Node<T>
    {   
        public Node(T t)
        {
            data = t;
        }

        private T data;

        public T Data
        {
            get { return data;}
        }
    }
}