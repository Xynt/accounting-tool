namespace backend.Accounts.Dtos;

public class PostAccountDto
{
    public string Name { get; set; } = null!;
    
    public bool isPhysical { get; set; }
    
    public double? Amount { get; set; }
}