using FuelStation.EF.Repositories;
using FuelStation.Model.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuelStation.Win
{
    public partial class TransactionsForm : Form
    {
        private readonly IEntityRepo<Transaction> _transactionRepo;
        public TransactionsForm(IEntityRepo<Transaction> transactionRepo)
        {
            InitializeComponent();
            _transactionRepo = transactionRepo;
            this.CenterToScreen();
        }
    }
}
