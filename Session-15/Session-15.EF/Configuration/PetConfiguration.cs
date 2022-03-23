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
    public class PetConfiguration : IEntityTypeConfiguration<Pet>
    {
        public void Configure(EntityTypeBuilder<Pet> builder)
        {
            builder.ToTable("Pet");

            builder.HasKey(pet => pet.ID);
            builder.Property(pet => pet.AnimalType).IsRequired();
            builder.Property(pet => pet.Cost).IsRequired();
            builder.Property(pet => pet.Price).IsRequired();
            builder.Property(pet => pet.Breed).IsRequired();
            builder.Property(pet => pet.ObjectStatus).HasDefaultValue(Status.Active);
            builder.Property(pet => pet.HealthStatus).IsRequired();
        }
    }
}
