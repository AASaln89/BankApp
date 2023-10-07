using BankApp.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.Repository.EntityConfig
{
    internal class BankEntityConfig : IEntityTypeConfiguration<Bank>
    {
        public void Configure(EntityTypeBuilder<Bank> builder)
        {
            builder.HasKey(b => b.UUID);
            builder.Property(b => b.UUID).ValueGeneratedOnAdd();
            builder.Property(b => b.Name).HasMaxLength(50);

            builder.HasMany(b => b.Clients).WithOne(c => c.Bank);
        }
    }
}
