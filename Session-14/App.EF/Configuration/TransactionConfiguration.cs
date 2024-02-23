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
    internal class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.HasKey(transaction => transaction.ID);

            builder.HasMany(transaction => transaction.TransactionLines).WithOne().HasForeignKey(transactionLine => transactionLine.ID).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(transaction => transaction.Manager).WithMany().HasForeignKey(transaction => transaction.ManagerID).OnDelete(DeleteBehavior.NoAction).IsRequired();
            builder.HasOne(transaction => transaction.Customer).WithMany().HasForeignKey(transaction => transaction.CustomerID).OnDelete(DeleteBehavior.NoAction).IsRequired();
            builder.HasOne(transaction => transaction.Car).WithMany().HasForeignKey(transaction => transaction.CarID).OnDelete(DeleteBehavior.NoAction).IsRequired();
        }
    }
}
