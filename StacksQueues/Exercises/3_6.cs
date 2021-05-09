using System;
using Datastructures;


// Book suggests using two different lists for cats and dogs. Slightly more efficient but more complex
// I also used enums for simplicity, book sets u an animal class
namespace Exercises
{

    class Exercise3_6
    {

        public static void Main(string[] args)
        {

           AnimalShelterQueue asq = new AnimalShelterQueue();

           asq.enqueue(AnimalShelterQueue.animalType.Cat);
           asq.enqueue(AnimalShelterQueue.animalType.Dog);
           asq.enqueue(AnimalShelterQueue.animalType.Cat);

           asq.enqueue(AnimalShelterQueue.animalType.Dog);
           asq.enqueue(AnimalShelterQueue.animalType.Dog);
           asq.enqueue(AnimalShelterQueue.animalType.Cat);

           asq.enqueue(AnimalShelterQueue.animalType.Dog);
           asq.enqueue(AnimalShelterQueue.animalType.Cat);
           asq.enqueue(AnimalShelterQueue.animalType.Dog);

           asq.enqueue(AnimalShelterQueue.animalType.Cat);
           asq.enqueue(AnimalShelterQueue.animalType.Cat);
           asq.enqueue(AnimalShelterQueue.animalType.Dog);


           asq.dequeueAny();
           asq.dequeueAny();
           asq.dequeueAny();

           asq.dequeueCat();

           asq.dequeueDog();

           asq.dequeueDog();


        }
    }
}