using System.Diagnostics.Metrics;

namespace LabActOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Activity 1: Inheritance

            Animal animal = new Animal();
            Dog dog = new Dog();
            Cat cat = new Cat();

            animal.MakeSound();
            dog.MakeSound();
            cat.MakeSound();

            // Added for spacing of expected outputs
            Console.WriteLine();

            // Activity 2: Polymorphism

            // Array of objects that inerits from the Animal class
            Animal[] myArr = { animal, dog, cat};

            // foreach loop can also be used
            //for (int i = 0; i < myArr.Count(); i++)
            //{
            //    myArr[i].MakeSound();
            //}

            foreach(Animal arr in myArr)
            {
                arr.MakeSound();
            }

        }
    }
    // Parent Class
    class Animal
    {
        // Method to be overriden - use virtual
        public virtual void MakeSound()
        {
            Console.WriteLine("The animal makes a sound.");
        }
    }
    // Inherit from Parent Class
    class Dog : Animal
    {
        // use override to override the method content
        public override void MakeSound()
        {
            Console.WriteLine("The dog barks.");
        }
    }
    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("The cat meows.");
        }
    }
}
