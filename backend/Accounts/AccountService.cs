using backend.Accounts.Dtos;
using backend.Accounts.Entities;

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

    public async Task AddAccount(PostAccountDto dto)
    {
        await _context.Accounts.AddAsync(ToAccount(dto));
        await _context.SaveChangesAsync();
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