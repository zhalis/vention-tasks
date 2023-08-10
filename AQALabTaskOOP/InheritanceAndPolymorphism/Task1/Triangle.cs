namespace AQALabTaskOOP.InheritanceAndPolymorphism.Task1;

public class Triangle : Shape
{
    private double SideA { get; set; }
    private double SideB { get; set; }
    private double SideC { get; set; }

    public Triangle(double sideA, double sideB, double sideC)
    {
        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }

    public override double CalculateArea()
    {
        var perimeter = CalculatePerimeter();
        return Math.Sqrt(perimeter * (perimeter - SideA) * (perimeter - SideB) * (perimeter - SideC));
    }

    public override double CalculatePerimeter()
    {
        return SideA + SideB + SideC;
    }
}