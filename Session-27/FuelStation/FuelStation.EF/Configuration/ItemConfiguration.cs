using FuelStation.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.EF.Configuration
{
    public class ItemConfiguration : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            builder.ToTable("Item");
            builder.HasKey(item => item.ID);
            builder.Property(item => item.ID).ValueGeneratedOnAdd();
            builder.Property(item => item.Description).HasMaxLength(50);
            builder.Property(item => item.Code).HasMaxLength(50);
            builder.HasIndex(item => item.Code).IsUnique(true);

        }
    }
}
