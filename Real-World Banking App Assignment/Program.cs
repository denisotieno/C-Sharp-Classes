using System;

class Program
{
    static void Main()
    {
        Customer customer = new Customer { Name = "Denis Otieno", ContactInfo = "DenisOtieno@gmail.com", CustomerID = "D001" };
        SavingsAccount savings = new SavingsAccount { AccountNumber = "SA_001" };
        CurrentAccount current = new CurrentAccount { AccountNumber = "CA_001" };

        customer.Accounts.Add(savings);
        customer.Accounts.Add(current);

        savings.Deposit(500);
        savings.Withdraw(100);
        savings.ApplyInterest();

        current.Deposit(1000);
        current.Withdraw(1800); 

        Console.WriteLine("\nAccount Types:");
        foreach(var account in customer.Accounts)
            Console.WriteLine(account.ToString());

        Console.WriteLine("\nTransaction History for Savings:");
        foreach (var tx in savings.Transactions)
            Console.WriteLine($"{tx.Timestamp}: {tx.TransactionType} - {tx.Amount:C}");

        Console.WriteLine("\nTransaction History for Current:");
        foreach (var tx in current.Transactions)
            Console.WriteLine($"{tx.Timestamp}: {tx.TransactionType} - {tx.Amount:C}");
            Console.ReadLine();
    }
}
