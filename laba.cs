using System;

// Абстрактний клас Shape
abstract class Shape
{
    public string name;
    public string Name
    {
        get { return name; }
    }

    public Shape(string shapeName)
    {
        name = shapeName;
    }

    // Абстрактні методи для обчислення площі та периметра
    public abstract double Area();
    public abstract double Perimeter();
}

// Клас Circle похідний від Shape
class Circle : Shape
{
    private double radius;

    public double Radius
    {
        get { return radius; }
        set { radius = value; }
    }

    public Circle(string shapeName, double circleRadius) : base(shapeName)
    {
        radius = circleRadius;
    }

    // Перевизначення методів з абстрактного класу Shape
    public override double Area()
    {
        return Math.PI * radius * radius;
    }

    public override double Perimeter()
    {
        return 2 * Math.PI * radius;
    }
}

// Клас Square похідний від Shape
class Square : Shape
{
    private double side;

    public double Side
    {
        get { return side; }
        set { side = value; }
    }

    public Square(string shapeName, double squareSide) : base(shapeName)
    {
        side = squareSide;
    }

    // Перевизначення методів з абстрактного класу Shape
    public override double Area()
    {
        return side * side;
    }

    public override double Perimeter()
    {
        return 4 * side;
    }
}

class Program
{
    static void Main()
    {
        // Створення екземплярів класів Circle та Square
        Circle circle1 = new Circle("Circle 1", 5.0);
        Circle circle2 = new Circle("Circle 2", 7.5);

        Square square1 = new Square("Square 1", 4.0);
        Square square2 = new Square("Square 2", 6.0);

        // Виведення назви, площі та периметра усіх фігур
        Console.WriteLine($"{circle1.Name}: Area = {circle1.Area()}, Perimeter = {circle1.Perimeter()}");
        Console.WriteLine($"{circle2.Name}: Area = {circle2.Area()}, Perimeter = {circle2.Perimeter()}");
        Console.WriteLine($"{square1.Name}: Area = {square1.Area()}, Perimeter = {square1.Perimeter()}");
        Console.WriteLine($"{square2.Name}: Area = {square2.Area()}, Perimeter = {square2.Perimeter()}");

        // Знаходження та виведення площі найбільшого квадрата та кола
        Square largestSquare = (square1.Area() > square2.Area()) ? square1 : square2;
        Circle largestCircle = (circle1.Area() > circle2.Area()) ? circle1 : circle2;

        Console.WriteLine($"Largest Square: Area = {largestSquare.Area()}");
        Console.WriteLine($"Largest Circle: Area = {largestCircle.Area()}");

        Console.ReadLine();
    }
}
