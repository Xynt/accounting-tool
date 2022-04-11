using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace backend.Accounts.Entities;

public class AccountConfiguration : IEntityTypeConfiguration<Account>
{
    public void Configure(EntityTypeBuilder<Account> builder)
    {
        builder.ToTable("Record", "Core");
        builder.HasKey(r => r.Id);
        builder.Property(r => r.Amount).HasColumnName("Amount").IsRequired();
        builder.Property(r => r.isPhysical).HasColumnName("IsPhysical").IsRequired();
        builder.Property(r => r.Name).HasColumnName("Name").IsRequired();
    }
}