using System;

class Program
{
    static void Main(string[] args)
    {
        // matriz 
        Shape[] shapes = new Shape[]
        {
            new Rectangle(5, 10),
            new Triangle(6, 8),
            new Circle(4)
        };

        double[] areas = new double[shapes.Length];

        for (int i = 0; i < shapes.Length; i++)
        {
            areas[i] = shapes[i].CalculateSurface();
            Console.WriteLine($"Area de la forma {i + 1}: {areas[i]}");
        }
    }
}
