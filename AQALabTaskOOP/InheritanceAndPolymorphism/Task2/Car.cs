namespace AQALabTaskOOP.InheritanceAndPolymorphism.Task2;

public abstract class Car
{
    public string Make { get; }
    public string Model { get; }
    public int Year { get; }
    public int Price { get; set; }

    protected Car(string make, string model, int year, int price)
    {
        Make = make;
        Model = model;
        Year = year;
        Price = price;
    }

    protected virtual void StartEngine()
    {
        Console.WriteLine("Engine started");
    }

    protected virtual void OpenDoor()
    {
        Console.WriteLine("Door is opened");
    }

    protected void StopEngine()
    {
        Console.WriteLine("Engine is stopped");
    }
}