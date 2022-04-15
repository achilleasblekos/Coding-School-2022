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
    public class TransactionLineConfiguration : IEntityTypeConfiguration<TransactionLine>
    {
        public void Configure(EntityTypeBuilder<TransactionLine> builder)
        {
            builder.ToTable("TransactionLine");
            builder.HasKey(transactionLine => transactionLine.ID);
            builder.Property(transactionLine => transactionLine.ID).ValueGeneratedOnAdd();
            builder.HasOne(transactionLine => transactionLine.Item).WithMany(item => item.TransactionLines).HasForeignKey(transactionLine => transactionLine.ItemID);
        }
    }
}
