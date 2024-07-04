using System;

// Define the IMovable interface
interface IMovable
{
    void Move();
}

// Create the Car class that implements IMovable
class Car : IMovable
{
    public void Move()
    {
        Console.WriteLine("Car is moving");
    }
}

// Create the Bicycle class that implements IMovable
class Bicycle : IMovable
{
    public void Move()
    {
        Console.WriteLine("Bicycle is moving");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create instances of Car and Bicycle
        Car myCar = new Car();
        Bicycle myBicycle = new Bicycle();

        // Call the Move() method on each instance
        myCar.Move();
        myBicycle.Move();

        Console.ReadLine(); // Keep the console window open
    }
}
