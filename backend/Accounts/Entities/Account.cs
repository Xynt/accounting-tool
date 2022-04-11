namespace backend.Accounts.Entities;

public class Account
{
    public Guid id { get; set; }

    public string name { get; set; } = null!;
    
    public double amount { get; set; }
}