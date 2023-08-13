namespace AQALabTaskOOP.InheritanceAndPolymorphism.Task1;

public class Square : Shape
{
    public double SideA { get; set; }

    public Square(double sideA)
    {
        SideA = sideA;
    }

    public override double CalculatePerimeter() => SideA * 4;

    public override double CalculateArea() => Math.Pow(SideA, 2);

    public override string GetDrawingInstructions() => $"{base.GetDrawingInstructions()}, Side: {SideA}";
}