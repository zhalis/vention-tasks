namespace AQALabTaskOOP.Encapsulation.Task2;

public class CollegeStudent : Student
{
    public string CollegeName { get; }

    public CollegeStudent(int id, string firstName, string lastName, int age, string collegeName)
        : base(id, firstName, lastName, age)
    {
        CollegeName = collegeName;
    }

    public string WakeUp() => WakeUp(10);
}