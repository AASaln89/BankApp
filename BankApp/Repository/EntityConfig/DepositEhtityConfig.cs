using BankApp.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BankApp.Repository.EntityConfig
{
    internal class DepositEhtityConfig : IEntityTypeConfiguration<Deposit>
    {
        public void Configure(EntityTypeBuilder<Deposit> builder)
        {
            builder.HasKey(d => d.UUID);

            builder.Property(d => d.UUID)
                .ValueGeneratedOnAdd();

            builder.Property(c => c.Number)
                .HasMaxLength(50)
                .IsRequired();

            builder.HasOne(d => d.Client)
                .WithMany(c => c.Deposits);
        }
    }
}
