using PetShopLibrary;

namespace Session_11
{
    public partial class PetShopForm : Form
    {
        private PetShopManager _petShop;
        public PetShopForm(PetShopManager petShop)
        {
            InitializeComponent();
            _petShop = petShop;
            this.CenterToScreen();
        }
        public PetShopForm()
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
                   
        }


        private void petsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PetForm petForm = new PetForm(_petShop);
            petForm.ShowDialog();
        }

        private void transactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TransactionForm transactionForm = new TransactionForm(_petShop);
            transactionForm.ShowDialog();
        }

        private void petFoodsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PetFoodsForm form = new PetFoodsForm(_petShop);
            form.ShowDialog();
        }

        private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeesForm employeesForm = new EmployeesForm(_petShop);
            employeesForm.ShowDialog();
        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCustomer form = new FormCustomer(_petShop);
            form.ShowDialog();
        }

        private void PetShopForm_Load(object sender, EventArgs e)
        {
            
            LoginForm loginform = new LoginForm();
            loginform.ShowDialog();
        }

      
      

        private void petReportToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormPetReport form = new FormPetReport() { petShopManager = _petShop };
            form.ShowDialog();

        }

        private void monthlyLedgerToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            FormMonthlyLedger form = new FormMonthlyLedger() { _petShopManager = _petShop };
            form.ShowDialog();
        }
    }
}