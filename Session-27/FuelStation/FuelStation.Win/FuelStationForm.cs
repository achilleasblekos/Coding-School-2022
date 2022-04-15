using FuelStation.EF.Repositories;
using FuelStation.Model.Entities;

namespace FuelStation.Win
{
    public partial class FuelStationForm : Form
    {
        private readonly IEntityRepo<Customer> _customerRepo;
        private readonly IEntityRepo<Item> _itemRepo;
        private readonly IEntityRepo<Transaction> _transactionRepo;
        public FuelStationForm(IEntityRepo<Customer> customerRepo, IEntityRepo<Item> itemRepo, IEntityRepo<Transaction> transactionRepo)
        {
            InitializeComponent();
            _customerRepo = customerRepo;
            _itemRepo = itemRepo;
            _transactionRepo = transactionRepo;
            this.CenterToScreen();
        }

        private void FuelStationForm_Load(object sender, EventArgs e)
        {
            LoginForm loginform = new LoginForm();
            loginform.ShowDialog();

        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomersForm customersform = new CustomersForm(_customerRepo);
            customersform.ShowDialog();
        }

        private void itemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItemsForm itemsform = new ItemsForm(_itemRepo);
            itemsform.ShowDialog();
        }

        private void transactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TransactionsForm transactionform = new TransactionsForm(_transactionRepo);
            transactionform.ShowDialog();
        }
    }
}