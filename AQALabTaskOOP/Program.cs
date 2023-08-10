using AQALabTaskOOP.Abstraction.Task1;
using AQALabTaskOOP.Encapsulation.Task1;
using AQALabTaskOOP.InheritanceAndPolymorphism.Task1;

var shapes = new List<IDrawable>
{
    new Circle(5),
    new Rectangle(10, 5.5),
    new Triangle(3, 4, 5),
    new Ellipse(15, 5),
    new Square(4),
    new Picture()
};
shapes.ForEach(drawable =>
{
    drawable.Draw();
    Console.WriteLine(drawable.GetDrawingInstructions());
});


var employees = new List<Employee>{
    new Accountant(1, "Petya", 1000, "Junior accountant"),
    new Developer(3, "Vasya", 5000)
    {
        Position = "Senior developer"
    }
};
employees.ForEach(Console.WriteLine);


var bankAccount = new BankAccount(1, "owner", 1000);
bankAccount.Notify += Console.WriteLine;
bankAccount.WithdrawMoneyFromAccount(100);
bankAccount.DepositMoneyIntoAccount(150);
bankAccount.WithdrawMoneyFromAccount(2000);