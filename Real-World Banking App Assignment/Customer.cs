using System.Collections.Generic;

public class Customer
{
    public string Name { get; set; }
    public string ContactInfo { get; set; }
    public string CustomerID { get; set; }
    public List<Account> Accounts { get; } = new List<Account>();
}
