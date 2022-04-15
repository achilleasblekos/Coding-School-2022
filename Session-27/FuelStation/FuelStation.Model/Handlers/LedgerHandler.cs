using FuelStation.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Model.Handlers
{
    public class LedgerHandler
    {
        public LedgerHandler()
        {

        }

        public double GetMonthlyIncome(DateTime date, IEnumerable<Transaction> transactions)
        {
            double monthlyIncome = 0;

            foreach (var transaction in transactions.Where(transaction => transaction.Date.Year == date.Year &&
                                                           transaction.Date.Month == date.Month))
            {
                monthlyIncome += transaction.TotalValue;
            }

            return monthlyIncome;
        }

        public double GetMonthlyExpenses(DateTime date, IEnumerable<Transaction> transactions)
        {
            double monthlyExpenses = 5000;
            var monthlyTransactions = (List<Transaction>)transactions.Where(transaction => transaction.Date.Year == date.Year &&
                                           transaction.Date.Month == date.Month);
            foreach (var trans in monthlyTransactions)
            {
                monthlyExpenses += trans.TransactionLines.Sum(transactionLine => transactionLine.Item.Cost);
            }

            return monthlyExpenses;
        }
    }
}
