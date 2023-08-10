namespace AQALabTaskOOP.Abstraction.Task1;

public class Developer : Employee
{
    public Developer(int employeeId, string? name, int salary) : base(employeeId, name, salary)
    {
    }

    public override required string Position { get; set; }
}