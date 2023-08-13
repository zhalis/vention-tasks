namespace AQALabTaskOOP.InheritanceAndPolymorphism.Task2;

public class GasCar : Car
{
    public string FuelType { get; }
    public int FuelEfficiency { get; }

    public GasCar(string make, string model, int year, int price, string fuelType, int fuelEfficiency)
        : base(make, model, year, price)
    {
        FuelType = fuelType;
        FuelEfficiency = fuelEfficiency;
    }

    protected override void StartEngine() => Console.WriteLine("Gas engine is started");

    protected sealed override void OpenDoor() => base.OpenDoor();
}