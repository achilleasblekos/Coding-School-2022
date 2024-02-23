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
    internal class TransactionLineConfiguration : IEntityTypeConfiguration<TransactionLine>
    {
        public void Configure(EntityTypeBuilder<TransactionLine> builder)
        {
            builder.HasKey(transactionLine => transactionLine.ID);

            builder.HasOne(transactionLine => transactionLine.Engineer).WithMany().HasForeignKey(transactionLine => transactionLine.EngineerID).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(transactionLine => transactionLine.ServiceTask).WithMany().HasForeignKey(transactionLine => transactionLine.ServiceTaskID).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
