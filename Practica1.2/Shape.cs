using System;

public abstract class Shape
{
    protected double Width { get; set; }
    protected double Height { get; set; }

    protected Shape(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public abstract double CalculateSurface();
}
