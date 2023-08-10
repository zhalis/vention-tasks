namespace AQALabTaskOOP.InheritanceAndPolymorphism.Task1;

public class Circle : Shape
{
    private double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }

    public override double CalculatePerimeter()
    {
        return 2 * Math.PI * Radius;
    }

    public override string GetDrawingInstructions()
    {
        return $"{base.GetDrawingInstructions()}, Radius: {Radius}" ;
    }
}