using System;

public class SavingsAccount : Account
{
    public decimal InterestRate { get; set; } = 0.02m;

    public override void Withdraw(decimal amount)
    {
        if (Balance - amount < 0)
            Console.WriteLine("Insufficient funds in Savings Account.");
        else
        {
            UpdateBalance(Balance - amount);
            ExecuteTransaction(amount, "Withdraw");
        }
    }

    public void ApplyInterest()
    {
        decimal interest = Balance * InterestRate;
        Deposit(interest);
        Console.WriteLine($"Interest applied: {interest:C}");
    }
}
