namespace backend.Accounts.Entities;

public class Account
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;
    
    public double Amount { get; set; }
}