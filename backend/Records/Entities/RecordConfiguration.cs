using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace backend.Records.Entities;

public class RecordConfiguration : IEntityTypeConfiguration<Record>
{
    public void Configure(EntityTypeBuilder<Record> builder)
    {
        builder.ToTable("Record", "Core");
        builder.HasKey(r => r.Id);
        builder.Property(r => r.Amount).HasColumnName("Amount").IsRequired();
        builder.Property(r => r.Date).HasColumnName("Date").IsRequired();
        builder.Property(r => r.Description).HasColumnName("Description").IsRequired();
        builder.Property(r => r.CreditId).HasColumnName("CreditId").IsRequired();
        builder.Property(r => r.DebitId).HasColumnName("DebitId").IsRequired();
        builder.HasOne(r => r.Credit).WithMany().HasForeignKey(r => r.CreditId);
        builder.HasOne(r => r.Debit).WithMany().HasForeignKey(r => r.DebitId);
    }
}