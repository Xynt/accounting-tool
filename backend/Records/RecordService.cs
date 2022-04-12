using backend.Records.Dtos;
using backend.Records.Entities;
using CSharpFunctionalExtensions;
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
        return _context.Records.AsNoTracking()
            .Include(r => r.Credit)
            .Include(r => r.Debit)
            .ToList()
            .ConvertAll(r => r.ToRecordDto());
    }

    public async Task<Result> AddRecord(PostRecordDto dto)
    {
        var creditAccount = _context.Accounts.AsTracking().Where(a => a.Id == dto.CreditId);
        var debitAccount = _context.Accounts.AsTracking().Where(a => a.Id == dto.DebitId);

        if (creditAccount.TryFirst().HasNoValue)
        {
            return Result.Failure("Credit account not found");
        }

        if (debitAccount.TryFirst().HasNoValue)
        {
            return Result.Failure("Debit account not found");
        }

        var creditor = creditAccount.First();
        var debitor = debitAccount.First();

        if (debitor.Amount < dto.Amount)
        {
            return Result.Failure("Debit account does not have enough funds");
        }

        creditor.Amount += dto.Amount;
        debitor.Amount -= dto.Amount;

        await _context.Records.AddAsync(ToRecord(dto));
        await _context.SaveChangesAsync();
        
        return Result.Success();
    }

    private static Record ToRecord(PostRecordDto dto)
    {
        return new Record
        {
            Amount = dto.Amount,
            CreditId = dto.CreditId,
            DebitId = dto.DebitId,
            Date = DateTime.Now,
            Description = dto.Description
        };
    }
}