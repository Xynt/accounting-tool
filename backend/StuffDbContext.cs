using backend.Accounts.Entities;
using backend.Records.Entities;
using Microsoft.EntityFrameworkCore;

namespace backend;

public class StuffDbContext : DbContext
{
    public StuffDbContext(DbContextOptions<StuffDbContext> options)
        : base(options)
    {
    }

    public DbSet<Account> Accounts { get; set; } = null!;
    
    public DbSet<Record> Records { get; set; } = null!;
}