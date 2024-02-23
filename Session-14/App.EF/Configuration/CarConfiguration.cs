using App.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.EF.Configuration
{
    public class CarConfiguration : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.HasKey(car => car.ID);
            builder.Property(car => car.Brand).HasMaxLength(50);
            builder.Property(car => car.Model).HasMaxLength(4);
            builder.Property(car => car.CarRegNumber).HasMaxLength(10);
        }
    }
}
