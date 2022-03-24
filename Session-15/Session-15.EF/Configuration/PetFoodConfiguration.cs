using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Session_15.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_15.EF.Configuration
{
    public class PetFoodConfiguration : IEntityTypeConfiguration<PetFood>
    {
        public void Configure(EntityTypeBuilder<PetFood> builder)
        {
            builder.ToTable("PetFood");

            builder.HasKey(petFood => petFood.ID);
            builder.Property(petFood => petFood.Type).HasMaxLength(50);
            builder.Property(petFood => petFood.Brand).HasMaxLength(50);
            builder.Property(petFood => petFood.Cost).HasMaxLength(50);
            builder.Property(petFood => petFood.Price).HasMaxLength(50);
        }
    }
}
