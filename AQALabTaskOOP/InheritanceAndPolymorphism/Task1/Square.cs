namespace AQALabTaskOOP.InheritanceAndPolymorphism.Task1;

public class Square : Shape
{
    public double SideA { get; set; }

    public Square(double sideA)
    {
        SideA = sideA;
    }

    public override double CalculatePerimeter()
    {
        return SideA * 4;
    }

    public override double CalculateArea()
    {
        return Math.Pow(SideA, 2);
    }

    public override string GetDrawingInstructions()
    {
        return $"{base.GetDrawingInstructions()}, Side: {SideA}";
    }
}