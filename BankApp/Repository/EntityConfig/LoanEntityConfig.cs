using BankApp.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BankApp.Repository.EntityConfig
{
    internal class LoanEntityConfig : IEntityTypeConfiguration<Loan>
    {
        public void Configure(EntityTypeBuilder<Loan> builder)
        {
            builder.HasKey(d => d.UUID);

            builder.Property(d => d.UUID)
                .ValueGeneratedOnAdd();

            builder.Property(c => c.Number)
                .HasMaxLength(50)
                .IsRequired();

            builder.HasOne(l => l.Client)
                .WithMany(c => c.Loans);
        }
    }
}
