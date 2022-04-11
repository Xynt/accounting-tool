using backend.Accounts.Entities;
using Microsoft.EntityFrameworkCore;

namespace backend;

public class AccountDbContext : DbContext
{
    public AccountDbContext(IConfiguration configuration)
    {
    }

    public DbSet<Account> accounts { get; set; } = null!;
}