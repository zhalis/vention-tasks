namespace AQALabTaskOOP.Abstraction.Task1;

public sealed class Accountant : Employee
{
    public override string Position { get; set; }

    public Accountant(int employeeId, string? name, int salary, string position) : base(employeeId, name, salary)
    {
        Position = position;
    }
}