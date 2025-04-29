
using System;
using System.Collections.Generic;

public abstract class Account : Itransaction
{
    private decimal _balance;

    public string AccountNumber { get; set; }
    public decimal Balance => _balance;
    public List<Transaction> Transactions { get; } = new List<Transaction>();

    public abstract void Withdraw(decimal amount);

    public virtual void Deposit(decimal amount)
    {
        _balance += amount;
        ExecuteTransaction(amount, "Deposit");
    }

    public void ExecuteTransaction(decimal amount, string type)
    {
        Transactions.Add(new Transaction
        {
            Amount = amount,
            TransactionType = type,
            Timestamp = DateTime.Now
        });
    }

    protected void UpdateBalance(decimal newBalance)
    {
        _balance = newBalance;
    }
}
