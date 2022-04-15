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
    public class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.ToTable("Transaction");
            builder.HasKey(transaction => transaction.ID);
            builder.Property(transaction => transaction.ID).ValueGeneratedOnAdd();
            builder.HasOne(transaction => transaction.Customer).WithMany(customer => customer.Transactions).HasForeignKey(transaction => transaction.CustomerID).IsRequired(true);
            builder.HasOne(transaction => transaction.Employee).WithMany(employee => employee.Transactions).HasForeignKey(transaction => transaction.EmployeeID).IsRequired(true);
            builder.HasMany(transaction => transaction.TransactionLines).WithOne(transactionline => transactionline.Transaction).HasForeignKey(transactionLine => transactionLine.TransactionID).IsRequired(true);

        }
    }
}
