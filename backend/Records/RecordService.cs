namespace backend.Records;

public class RecordService : IRecordService
{
    private readonly StuffDbContext _context;

    public RecordService(StuffDbContext context)
    {
        _context = context;
    }
}