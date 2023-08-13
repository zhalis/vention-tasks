namespace AQALabTaskOOP.InheritanceAndPolymorphism.Task1;

public class Picture : IDrawable
{
    public void Draw() => Console.WriteLine("Beautiful picture");

    public string GetDrawingInstructions() => "Draw beautiful picture";
}