using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.Repository.EntityConfig
{
    internal class ClientEntityConfig : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.HasKey(c => c.UUID);

            builder.Property(c => c.UUID)
                .ValueGeneratedOnAdd();

            builder.Property(c => c.FirstName)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(c => c.LastName)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(c => c.PhoneNumber)
                .HasMaxLength(15)
                .IsRequired();

            builder.Property(c => c.Number)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(c => c.Type)
                .HasConversion<string>()
                .IsRequired();

            builder.HasMany(c => c.Deposits)
                .WithOne(d => d.Client)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(c => c.Loans)
                .WithOne(l => l.Client)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
