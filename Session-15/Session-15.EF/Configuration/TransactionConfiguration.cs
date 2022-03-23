using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using Session_15.Model;
using Transaction = Session_15.Model.Transaction;

namespace Session_15.EF.Configuration
{
    public class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.ToTable("Transaction");

            builder.HasKey(transaction => transaction.ID);
            builder.Property(transaction => transaction.PetFoodQty).IsRequired();
            builder.Property(transaction => transaction.PetFoodPrice).IsRequired();
            builder.Property(transaction => transaction.PetPrice).IsRequired();
            builder.Property(transaction => transaction.PetFoodID).IsRequired();
            builder.Property(transaction => transaction.TotalPrice).IsRequired();
            builder.Property(transaction => transaction.CustomerID).IsRequired();
            builder.Property(transaction => transaction.EmployeeID).IsRequired();
            builder.Property(transaction => transaction.Date).IsRequired();

        }
    }
}
