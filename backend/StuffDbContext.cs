using backend.Accounts.Entities;
using backend.Records.Entities;
using Microsoft.EntityFrameworkCore;

namespace backend;

public class StuffDbContext : DbContext
{
    public StuffDbContext(IConfiguration configuration)
    {
    }

    public DbSet<Account> Accounts { get; set; } = null!;
    
    public DbSet<Record> Records { get; set; } = null!;
}