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
    public class EngineerConfiguration : IEntityTypeConfiguration<Engineer>
    {
        public void Configure(EntityTypeBuilder<Engineer> builder)
        {
            builder.HasKey(engineer => engineer.ID);
            builder.Property(engineer => engineer.Name).HasMaxLength(50);
            builder.Property(engineer => engineer.Surname).HasMaxLength(50);

            builder.HasOne(engineer => engineer.Manager).WithMany().HasForeignKey(engineer => engineer.ManagerID).OnDelete(DeleteBehavior.NoAction).IsRequired();
        }
    }
}
