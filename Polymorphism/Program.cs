// #region Method Overloading:
// Console.WriteLine(MathOperations.Add(1, 2));
// Console.WriteLine(MathOperations.Add(1.1, 2, 3.0));
// System.Console.WriteLine();
// static class MathOperations
// {
//     public static int Add(int a, int b) => a + b;

//     public static double Add(double a, double b, double c) => a + b + c;
// }
// #endregion

// #region Method Overriding
// Animal animal = new Animal();
// Dog dog = new Dog();
// animal.Speak();
// dog.Speak();
// Console.WriteLine();

// class Animal
// {
//     public virtual void Speak()
//     {
//         Console.WriteLine("The animal speaks.");
//     }
// }

// class Dog : Animal
// {
//     public override void Speak()
//     {
//         Console.WriteLine("Dog barks.");
//     }
// }

// #endregion

// #region Interface Implementation
// IDrawable square = new Square();
// IDrawable circle = new Circle();
// List<IDrawable> shapes = new List<IDrawable>();
// shapes.Add(square);
// shapes.Add(circle);
// foreach (var shape in shapes)
// {
//     shape.Draw();
// }
// Console.WriteLine();

// interface IDrawable
// {
//     void Draw();
// }

// class Square : IDrawable
// {
//     public void Draw()
//     {
//         Console.WriteLine("Drawing a square.");
//     }
// }

// class Circle : IDrawable
// {
//     public void Draw()
//     {
//         Console.WriteLine("Drawing a circle.");
//     }
// }

// #endregion

// #region Abstract method and class
// // Create a circle and rectangle object.
// Circle circle = new Circle(5);
// Rectangle rectangle = new Rectangle(4, 7);

// // Display circle info.
// Console.WriteLine("Circle:");
// circle.DisplayInfo();

// Console.WriteLine();

// // Display rectangle info.
// Console.WriteLine("Rectangle:");
// rectangle.DisplayInfo();
// public abstract class Shape
// {
//     // Abstract method to calculate area of the shape.
//     public abstract double Area();

//     // Abstract method to calculate perimeter of the shape.
//     public abstract double Perimeter();

//     // A regular method inside the abstract class.
//     public void DisplayInfo()
//     {
//         Console.WriteLine($"Area: {Area()}");
//         Console.WriteLine($"Perimeter: {Perimeter()}");
//     }
// }

// // Step 2: Define derived classes implementing the abstract methods.
// public class Circle : Shape
// {
//     public double Radius { get; set; }

//     public Circle(double radius)
//     {
//         Radius = radius;
//     }

//     public override double Area()
//     {
//         return Math.PI * Radius * Radius;
//     }

//     public override double Perimeter()
//     {
//         return 2 * Math.PI * Radius;
//     }
// }

// public class Rectangle : Shape
// {
//     public double Width { get; set; }
//     public double Height { get; set; }

//     public Rectangle(double width, double height)
//     {
//         Width = width;
//         Height = height;
//     }

//     public override double Area()
//     {
//         return Width * Height;
//     }

//     public override double Perimeter()
//     {
//         return 2 * (Width + Height);
//     }
// }
// #endregion



