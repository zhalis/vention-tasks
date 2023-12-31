namespace AQALabTaskOOP.InheritanceAndPolymorphism.Task1;

public class Ellipse : Shape
{
    public double MaxRadius { get; set; }
    public double MinRadius { get; set; }

    public Ellipse(double maxRadius, double minRadius)
    {
        MaxRadius = maxRadius;
        MinRadius = minRadius;
    }

    public override double CalculatePerimeter() =>
        2 * Math.PI * Math.Sqrt((Math.Pow(MaxRadius, 2) + Math.Pow(MinRadius, 2)) / 2);

    public override double CalculateArea() => Math.PI * MaxRadius * MinRadius;

    public override string GetDrawingInstructions() =>
        $"{base.GetDrawingInstructions()}, Max radius: {MaxRadius}, Min radius: {MinRadius}";

    public string GetDrawingInstructions(string additionalInstructions) =>
        GetDrawingInstructions() + additionalInstructions;
}