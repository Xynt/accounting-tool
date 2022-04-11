using backend.Accounts.Entities;

namespace backend.Records.Entities;

public class Record
{
    public Guid Id { get; set; }

    public string Description { get; set; } = null!;

    public double Amount { get; set; }

    public DateTime Date { get; set; }

    public Account Credit { get; set; } = null!;

    public Account Debit { get; set; } = null!;
}