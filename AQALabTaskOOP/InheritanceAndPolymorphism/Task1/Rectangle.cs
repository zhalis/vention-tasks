namespace AQALabTaskOOP.InheritanceAndPolymorphism.Task1;

public class Rectangle : Shape
{
    public double SideA { get; set; }
    public double SideB { get; set; }

    public Rectangle(double sideA, double sideB)
    {
        SideA = sideA;
        SideB = sideB;
    }

    public override double CalculateArea() => SideA * SideB;

    public override double CalculatePerimeter() => 2 * (SideA + SideB);
}