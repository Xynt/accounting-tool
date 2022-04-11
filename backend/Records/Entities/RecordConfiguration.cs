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
    }
}