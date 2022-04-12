namespace backend.Accounts.Entities;

public class Account
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;
    
    public bool isPhysical { get; set; }
    
    public double Amount { get; set; }
}