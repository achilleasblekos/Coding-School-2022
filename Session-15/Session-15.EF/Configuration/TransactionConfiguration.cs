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
            builder.Property(transaction => transaction.PetFoodQty).HasMaxLength(100);
            builder.Property(transaction => transaction.PetFoodPrice).HasMaxLength(100);
            builder.Property(transaction => transaction.PetPrice).HasMaxLength(100);
            builder.Property(transaction => transaction.PetFoodID).HasMaxLength(100);
            builder.Property(transaction => transaction.TotalPrice).HasMaxLength(100);
            builder.Property(transaction => transaction.CustomerID).HasMaxLength(100);
            builder.Property(transaction => transaction.EmployeeID).HasMaxLength(100);
            builder.Property(transaction => transaction.Date).HasMaxLength(100);
            builder.Property(transaction => transaction.PetID).HasMaxLength(100);    



        }
    }
}
