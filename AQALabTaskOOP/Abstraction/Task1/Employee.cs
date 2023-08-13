namespace AQALabTaskOOP.Abstraction.Task1;

public abstract class Employee
{
    public int EmployeeId { get; set; }
    public string? Name { get; set; }
    public int Salary { get; set; }

    public abstract string Position { get; set; }

    protected Employee(int employeeId, string? name, int salary)
    {
        EmployeeId = employeeId;
        Name = name;
        Salary = salary;
    }

    public override string ToString() =>
        $"{nameof(EmployeeId)}: {EmployeeId}, {nameof(Name)}: {Name}, {nameof(Salary)}: {Salary}, " +
        $"{nameof(Position)}: {Position}";
}