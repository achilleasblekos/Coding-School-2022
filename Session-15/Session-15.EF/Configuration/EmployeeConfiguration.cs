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
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employee");

            builder.HasKey(employee => employee.ID);
            builder.Property(employee => employee.ObjectStatus).HasDefaultValue(Status.Active);
            builder.Property(employee => employee.Name).HasMaxLength(30);
            builder.Property(employee => employee.Surname).HasMaxLength(30);
           
        }
    }
}
