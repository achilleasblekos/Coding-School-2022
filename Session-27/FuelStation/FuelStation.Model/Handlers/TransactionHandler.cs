using FuelStation.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Model.Handlers
{
    public class TransactionHandler
    {
        public TransactionHandler()
        {

        }
        public double GetTotalPrice(Transaction transaction)
        {
            return transaction.TransactionLines.Sum(x => x.TotalValue);
        }

        public double GetNetValue(uint quantity, double price)
        {
            if (quantity <= 0) throw new ArgumentException("Quantity must be a non zero positive number");
            if (price <= 0) throw new ArgumentException("Price must be a non zero positive number");
            return quantity * price;
        }

        public double GetDiscountValue(double netValue, double discountPercent)
        {
            if (netValue <= 0) throw new ArgumentException("Net Value must be a non zero positive value");
            if (discountPercent < 0) throw new ArgumentException("Discount Percent must not be a negative value");
            return netValue * discountPercent;
        }

        public double GetTotalValue(double discountValue, double netValue)
        {
            if (discountValue < 0) throw new ArgumentException("Discount value must not be a negative value");
            if (netValue <= 0) throw new ArgumentException("Net Value must be a non zero positive value");
            return netValue - discountValue;
        }

        public double ApplyDiscount(double netValue, double totalValue)
        {
            if (netValue <= 0) throw new ArgumentException("Net Value must be a non zero positive value");
            if (totalValue < 0) throw new ArgumentException("Total Value must be a positive number");
            if (netValue > 20)
            {
                return totalValue - totalValue * 0.10;
            }
            return totalValue;
        }

        public bool CheckFuelExist(List<TransactionLine> transactionLines)
        {
            foreach (var line in transactionLines)
            {
                if (line.Item?.ItemType == ItemTypeEnum.Fuel)
                {
                    return true;
                }
            }
            return false;
        }

        public bool CheckCardPaymentAvail(double totalValue)
        {
            if (totalValue < 0) throw new ArgumentException("Total Value must be a positive number");
            if (totalValue > 50)
                return false;
            return true;
        }
    }
}
