namespace AQALabTaskOOP.Abstraction.Task1;

public class Manager : Employee
{
    public Manager(int employeeId, string? name, int salary) : base(employeeId, name, salary)
    {
    }

    public override required string Position { get; set; }
}