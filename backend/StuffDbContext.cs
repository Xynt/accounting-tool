using backend.Accounts.Entities;
using Microsoft.EntityFrameworkCore;

namespace backend;

public class StuffDbContext : DbContext
{
    public StuffDbContext(IConfiguration configuration)
    {
    }

    public DbSet<Account> accounts { get; set; } = null!;
}