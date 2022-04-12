using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace backend.Accounts.Entities;

public class AccountConfiguration : IEntityTypeConfiguration<Account>
{
    public void Configure(EntityTypeBuilder<Account> builder)
    {
        builder.ToTable("Account", "Core");
        builder.HasKey(a => a.Id);
        builder.Property(a => a.Amount).HasColumnName("Amount").IsRequired();
        builder.Property(a => a.isPhysical).HasColumnName("IsPhysical").IsRequired();
        builder.Property(a => a.Name).HasColumnName("Name").IsRequired();
    }
}