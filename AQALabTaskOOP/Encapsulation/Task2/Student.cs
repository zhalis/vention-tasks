namespace AQALabTaskOOP.Encapsulation.Task2;

public class Student
{
    public int Id { get; }
    public string FirstName { get; }
    public string LastName { get; }
    public int Age { get; set; }

    protected Student(int id, string firstName, string lastName, int age)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Age = age;
    }

    protected string WakeUp(int atHours)
    {
        return $"I wake up at {atHours}:00 AM";
    }

    protected string GetFullName()
    {
        return $"{FirstName} {LastName}";
    }
}