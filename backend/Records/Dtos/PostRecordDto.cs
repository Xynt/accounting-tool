namespace backend.Records.Dtos;

public class PostRecordDto
{
    public string Description { get; set; } = null!;
    
    public double Amount { get; set; }
    
    public Guid CreditId { get; set; }

    public Guid DebitId { get; set; }
}