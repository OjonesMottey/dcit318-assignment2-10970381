using System;

// Abstract base class
abstract class Shape
{
    // Abstract method
    public abstract double GetArea();
}

// Derived class Circle
class Circle : Shape
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    // Implementation of abstract method
    public override double GetArea()
    {
        return Math.PI * radius * radius;
    }
}

// Derived class Rectangle
class Rectangle : Shape
{
    private double width;
    private double height;

    public Rectangle(double width, double height)
    {
        this.width = width;
        this.height = height;
    }

    // Implementation of abstract method
    public override double GetArea()
    {
        return width * height;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Circle circle = new Circle(3);
        Rectangle rectangle = new Rectangle(6, 8);

        Console.WriteLine("Area of circle: {0:F2}", circle.GetArea());
        Console.WriteLine("Area of rectangle: {0:F2}", rectangle.GetArea());

        // Added line to keep the console window open
        Console.ReadLine();
    }
}