namespace AQALabTaskOOP.Encapsulation.Task1;

public class BankAccount
{
    private readonly int accountId;
    public string AccountOwner { get; }
    public double Balance { get; private set; }

    public event AccountHandler? Notify;

    public int AccountId { get; }

    public BankAccount(int accountId, string accountOwner, double balance)
    {
        this.accountId = accountId;
        AccountOwner = accountOwner;
        Balance = balance;
    }

    public delegate void AccountHandler(string message);

    public void DepositMoneyIntoAccount(double deposit)
    {
        Balance += deposit;
        Notify?.Invoke($"Received on account {deposit};");
    }

    public void WithdrawMoneyFromAccount(double amountToWithdraw)
    {
        Notify?.Invoke($"Attempt to withdraw from account {amountToWithdraw}$");
        _ = amountToWithdraw > Balance ? throw new NotEnoughMoneyException(Balance) : Balance -= amountToWithdraw;
    }
}