namespace AQALabTaskOOP.InheritanceAndPolymorphism.Task1;

public abstract class Shape : IDrawable
{
    public abstract double CalculateArea();

    public abstract double CalculatePerimeter();

    public void Draw() => Console.WriteLine(GetShapeName());

    public virtual string GetDrawingInstructions() =>
        $"Shape name: {GetShapeName()}, Perimeter: {CalculatePerimeter()}, Area: {CalculateArea()}";

    private string GetShapeName() => GetType().Name;
}