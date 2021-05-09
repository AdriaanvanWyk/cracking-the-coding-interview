using System;
using System.Collections;
using System.Collections.Generic;

namespace Datastructures
{

    public class AnimalShelterQueue
    {

        public enum animalType
        {
            Cat,
            Dog
        }
        LinkedList<animalType> animalQueue;
        public AnimalShelterQueue()
        {
            animalQueue = new LinkedList<animalType>();
        }

        public void enqueue(animalType a)
        {
            animalQueue.AddLast(a);
        }

        public animalType dequeueAny()
        {
            animalType animal = animalQueue.First.Value;
            animalQueue.RemoveFirst();
            return animal;
        }

        public animalType dequeueCat()
        {
            
            LinkedListNode<animalType> the_node = animalQueue.Find(animalType.Cat);
            animalQueue.Remove(the_node);
            return the_node.Value;
        }

        public animalType dequeueDog()
        {
            
            LinkedListNode<animalType> the_node = animalQueue.Find(animalType.Dog);
            animalQueue.Remove(the_node);
            return the_node.Value;
        }

        public void printQueue()
        {
            Console.Write(animalQueue.ToString());
        }
    }
}