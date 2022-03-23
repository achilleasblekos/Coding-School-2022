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
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customer");

            builder.HasKey(customer => customer.ID);
            builder.Property(customer => customer.Tin).HasMaxLength(9);
            builder.Property(customer => customer.PhoneNumber).HasMaxLength(10);
            builder.Property(customer => customer.ObjectStatus).HasDefaultValue(Status.Active);
            builder.Property(customer => customer.Name).HasMaxLength(30);
            builder.Property(customer => customer.Surname).HasMaxLength(30);

        }
    }
}

