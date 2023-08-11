class Program
{
    public static void Main(string[] args)
    {
        Func<int, int> module = Math.Abs;
        Func<int, int, int> add = (firstNum, secondNum) => firstNum + secondNum;
        Func<int, int, int> subtract = (firstNum, secondNum) => firstNum - secondNum;
        Func<int, int, int> multiply = (firstNum, secondNum) => firstNum * secondNum;
        Func<int, int, int> divide = (firstNum, secondNum) =>
            secondNum == 0 ? throw new DivideByZeroException("Can't divide by zero!") : firstNum / secondNum;

        Action<int> print = result => Console.WriteLine($"The result of operation is: {result}");

        PerformOperation(4, 0, divide, print);
        PerformOperation(-5, module, print);
    }

    private static void PerformOperation(int a, int b, Func<int, int, int> operation, Action<int> action) =>
        action.Invoke(operation.Invoke(a, b));

    private static void PerformOperation(int a, Func<int, int> operation, Action<int> action) =>
        action.Invoke(operation.Invoke(a));
}