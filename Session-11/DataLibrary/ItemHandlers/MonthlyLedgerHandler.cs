﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.ItemHandlers
{
    public class MonthlyLedgerHandler
    {
        public MonthlyLedgerHandler()
        {

        }

        public decimal GetMonthlyIncome(DateTime dateTime, CarService carService)
        {
            return carService.Transactions.FindAll(t => t.Date.Month == dateTime.Month && t.Date.Year == dateTime.Year).Sum(x => x.TotalPrice);
        }

        public decimal GetTotal(DateTime dateTime, CarService carService)
        {
            return GetMonthlyIncome(dateTime, carService) - GetMonthlyExpenses(carService);
        }

        public decimal GetMonthlyExpenses(CarService carService)
        {
            decimal managersSalaries = carService.Managers.Sum(m => m.SallaryPerMonth);
            decimal engineersSalaries = carService.Engineers.Sum(e => e.SallaryPerMonth);

            return managersSalaries + engineersSalaries;
        }

        public void CreateMonthlyLedger(CarService carService)
        {
            var ledgerToUpdate = carService.MonthlyLedgers.Find(ml => 
                ml.DateTimeValue.Year == DateTime.Now.Year &&
                ml.DateTimeValue.Month == DateTime.Now.Month);
            
            if (ledgerToUpdate is null)
            {
                carService.MonthlyLedgers.Add(new MonthlyLedger()
                {
                    DateTimeValue = DateTime.Now,
                    Income = GetMonthlyIncome(DateTime.Now, carService),
                    Expenses = GetMonthlyExpenses(carService),
                    Total = GetTotal(DateTime.Now, carService)
                });
            }
            else
            {
                ledgerToUpdate.Income = GetMonthlyIncome(DateTime.Now, carService);
                ledgerToUpdate.Expenses = GetMonthlyExpenses(carService);
                ledgerToUpdate.Total = GetTotal(DateTime.Now, carService);
            }
        }
    }
}
