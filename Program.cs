using System;


        // Cannot create an instance of the abstract Shape class
        // Shape myShape = new Shape("Red"); // This would result in a compile-time error

        // Create instances of the concrete derived classes
        Rectangle myRectangle = new Rectangle("Blue", 10, 5);
        Circle myCircle = new Circle("Green", 7);

        // Access common properties and methods
        myRectangle.DisplayColor(); // Output: Color of the shape: Blue
        myCircle.DisplayColor();    // Output: Color of the shape: Green

        // Call the implemented abstract method
        Console.WriteLine($"Area of the rectangle: {myRectangle.CalculateArea()}"); // Output: Area of the rectangle: 50




// Abstract base class
abstract class Shape
{
    public string Color { get; set; }

    public Shape(string color)
    {
        Color = color;
    }

    // Abstract method to calculate area
    public abstract double CalculateArea();

    // Non-abstract method (common to all shapes)
    public void DisplayColor()
    {
        Console.WriteLine($"Color of the shape: {Color}");
    }
}

// Concrete derived class: Rectangle
class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(string color, double width, double height) : base(color)
    {
        Width = width;
        Height = height;
    }

    // Implementation of the abstract CalculateArea method for Rectangle
    public override double CalculateArea()
    {
        return Width * Height;
    }
}

// Concrete derived class: Circle
class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(string color, double radius) : base(color)
    {
        Radius = radius;
    }

    // Implementation of the abstract CalculateArea method for Circle
    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}