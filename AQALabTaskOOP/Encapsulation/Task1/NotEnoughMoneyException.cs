namespace AQALabTaskOOP.Encapsulation.Task1;

public class NotEnoughMoneyException : Exception
{
    public NotEnoughMoneyException(double balance) : base($"Not enough money on the account! Available: {balance}")
    {
    }
}