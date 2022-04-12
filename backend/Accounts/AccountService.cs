using backend.Accounts.Dtos;
using backend.Accounts.Entities;
using CSharpFunctionalExtensions;

namespace backend.Accounts;

public class AccountService : IAccountService
{
    private readonly StuffDbContext _context;

    public AccountService(StuffDbContext context)
    {
        _context = context;
    }

    public IReadOnlyList<Account> GetAllAccounts()
    {
        return _context.Accounts.ToList();
    }

    public async Task<Result> AddAccount(PostAccountDto dto)
    {
        if (!dto.isPhysical && dto.Amount.HasValue)
        {
            return Result.Failure("Cannot add starting value to virtual account.");
        }
        
        await _context.Accounts.AddAsync(ToAccount(dto));
        await _context.SaveChangesAsync();
        
        return Result.Success();
    }

    private static Account ToAccount(PostAccountDto dto)
    {
        return new()
        {
            Amount = dto.Amount ?? 0d,
            isPhysical = dto.isPhysical,
            Name = dto.Name
        };
    }
}