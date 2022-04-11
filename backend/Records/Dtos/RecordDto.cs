namespace backend.Records.Dtos;

public class RecordDto
{
    public Guid Id { get; set; }

    public string Description { get; set; } = null!;

    public double Amount { get; set; }

    public DateTime Date { get; set; }
    
    public Guid CreditId { get; set; }

    public Guid DebitId { get; set; }
}