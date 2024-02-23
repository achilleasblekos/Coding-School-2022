using App.EF.Repository;
using App.Models.Entities;
using App.Models.EntitiesHandlers;
using HelperFunctions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session_11
{
    public partial class TransactionsF : Form
    {
        private CarService _carService;
        private Transaction _selectedTransaction;
        private TransactionHandler _transactionHandler;
        private ControlsHelper _controlsHelper;
        private StorageHelper _storageHelper;

        private readonly IEntityRepo<Transaction> _transactionRepo;
        
        public TransactionsF(CarService carServise, IEntityRepo<Transaction> transactionRepo)
        {
            InitializeComponent();
            _carService = carServise;
            _selectedTransaction = new Transaction();
            _transactionHandler = new TransactionHandler();
            _controlsHelper = new ControlsHelper();
            _storageHelper = new StorageHelper();
            _transactionRepo = transactionRepo;
        }

        private void TransactionsF_Load(object sender, EventArgs e)
        {
            
            PopulateTransactions();
            PopulateControls();
        }

        private void PopulateControls()
        {
            _controlsHelper.PopulateCarsColumns(CarLookUp, bsCarColumns, _carService.Cars);
            _controlsHelper.PopulateCustomersColumns(CustomerLookUp, bsCustomerColumns, _carService.Customers);
            _controlsHelper.PopulateManagersColumns(ManagerLookUp, bsManagerColumns, _carService.Managers);
            
            _controlsHelper.SetColumn(CarLookUp,gridView1, "CarID");
            _controlsHelper.SetColumn(CustomerLookUp, gridView1, "CustomerID");
            _controlsHelper.SetColumn(ManagerLookUp, gridView1, "ManagerID");

        }

        private void PopulateTransactions()
        {
           
            bsTransactions.DataSource = _carService;
            bsTransactions.DataMember = "Transactions";
            GrdTransactions.DataSource = bsTransactions;

            _controlsHelper.HideColumns("ID", gridView1);
            _controlsHelper.HideColumns("Manager", gridView1);
            _controlsHelper.HideColumns("Car", gridView1);
            _controlsHelper.HideColumns("Customer", gridView1);
        }

        private void Btnnew_Click(object sender, EventArgs e)
        {
            TransactionF transactionF = new TransactionF(_carService, _transactionRepo);
            transactionF.ShowDialog();
            gridView1.RefreshData();

        }

        //private void Btnedit_Click(object sender, EventArgs e)
        //{
        //    _selectedTransaction = bsTransactions.Current as Transaction;

        //    TransactionF transactionF = new TransactionF(_carService, _selectedTransaction);
        //    transactionF.ShowDialog();
        //    gridView1.RefreshData();
        //}

        private void Btndelete_Click(object sender, EventArgs e)
        {
            var transaction = bsTransactions.Current as Transaction;
            _transactionHandler.Delete(transaction, _carService.Transactions);
            _transactionRepo.Delete(transaction.ID);
            gridView1.RefreshData();
        }

        private void Btnclose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
