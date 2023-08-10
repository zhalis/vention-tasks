namespace AQALabTaskOOP.InheritanceAndPolymorphism.Task2;

public class ElectricCar : Car
{
    public int BatteryCapacity { get; }
    public int RangePerCharge { get; }

    public ElectricCar(string make, string model, int year, int price, int batteryCapacity, int rangePerCharge)
        : base(make, model, year, price)
    {
        BatteryCapacity = batteryCapacity;
        RangePerCharge = rangePerCharge;
    }

    protected override void StartEngine()
    {
        Console.WriteLine("Electric engine started");
    }

    protected sealed override void OpenDoor()
    {
        base.OpenDoor();
    }

    protected new void StopEngine()
    {
        base.StopEngine();
        Console.WriteLine("The car does not use electricity");
    }

    protected void StopEngine(string reason)
    {
        StopEngine();
        Console.WriteLine($"Reason: {reason}");
    }
}