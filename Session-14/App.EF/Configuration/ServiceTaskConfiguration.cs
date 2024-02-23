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
    public class ServiceTaskConfiguration : IEntityTypeConfiguration<ServiceTask>
    {
        public void Configure(EntityTypeBuilder<ServiceTask> builder)
        {
            builder.HasKey(serviceTask => serviceTask.ID);
            builder.Property(serviceTask => serviceTask.Code).HasMaxLength(10);
            builder.Property(serviceTask => serviceTask.Description).HasMaxLength(200);
        }
    }
}
