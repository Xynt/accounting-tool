using backend.Records.Dtos;
using backend.Records.Entities;
using Microsoft.EntityFrameworkCore;

namespace backend.Records;

public class RecordService : IRecordService
{
    private readonly StuffDbContext _context;

    public RecordService(StuffDbContext context)
    {
        _context = context;
    }

    public IReadOnlyList<RecordDto> GetAllRecords()
    {
        return _context.Records.AsNoTracking().ToList().ConvertAll(r => r.toRecordDto());
    }

    public async Task AddRecord(PostRecordDto dto)
    {
        await _context.Records.AddAsync(await toRecord(dto));
    }

    private async Task<Record> toRecord(PostRecordDto dto)
    {
        return new Record
        {
            Amount = dto.Amount,
            Credit = await _context.Accounts.AsNoTracking().Where(a => a.Id == dto.CreditId).FirstAsync(),
            Debit = await _context.Accounts.AsNoTracking().Where(a => a.Id == dto.DebitId).FirstAsync(),
            Date = DateTime.Now,
            Description = dto.Description
        };
    }
}