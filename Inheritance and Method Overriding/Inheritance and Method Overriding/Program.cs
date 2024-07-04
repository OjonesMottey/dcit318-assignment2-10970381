using System;

// Base class
class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Some generic sound");
    }
}

// Derived class Dog
class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Bark");
    }
}

// Derived class Cat
class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Meow");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Animal genericAnimal = new Animal();
        Dog dog = new Dog();
        Cat cat = new Cat();

        Console.WriteLine("Generic Animal sound:");
        genericAnimal.MakeSound();

        Console.WriteLine("\nDog sound:");
        dog.MakeSound();

        Console.WriteLine("\nCat sound:");
        cat.MakeSound();

        Console.ReadLine(); // To keep the console window open
    }
}