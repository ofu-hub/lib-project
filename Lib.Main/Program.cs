// See https://aka.ms/new-console-template for more information
using models;

Console.WriteLine("Hello, World!");

Circle circle = new Circle("Circle",12);
Triangle triangle = new Triangle("Triangle",4,4,5);

Console.WriteLine(circle.Square());
Console.WriteLine(triangle.Square());