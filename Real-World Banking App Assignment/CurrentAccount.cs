using System;

public class CurrentAccount : Account
{
    public decimal OverdraftLimit { get; set; } = -1000m;

    public override void Withdraw(decimal amount)
    {
        if (Balance - amount < OverdraftLimit)
            Console.WriteLine("Overdraft limit exceeded.");
        else
        {
            UpdateBalance(Balance - amount);
            ExecuteTransaction(amount, "Withdraw");
        }
    }
}
