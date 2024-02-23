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
    public partial class CustomersF : Form
    {
        private CarService _carService;
        private Customer _customer;
        private CustomerHandler _customerHandler;
        private StorageHelper _storageHelper;
        private ControlsHelper _controlsHelper;

        private readonly IEntityRepo<Customer> _customerRepo;

        public CustomersF(CarService carService, IEntityRepo<Customer> customerRepo)
        {
            InitializeComponent();
            _carService = carService;
            _customerHandler = new CustomerHandler();
            _storageHelper = new StorageHelper();
            _controlsHelper = new ControlsHelper();
            _customerRepo = customerRepo;
        }

        private void CustomersF_Load(object sender, EventArgs e)
        {
            PopulateControls();
            PopulateCustomers();
        }

        private void PopulateControls()
        {
            
        }

        private void PopulateCustomers()
        {
            

            bsCustomers.DataSource = _carService;
            bsCustomers.DataMember = "Customers";

            GrdCustomers.DataSource = bsCustomers;
            _controlsHelper.HideColumns("ID", gridView1);

        }

        private void Btnnew_Click(object sender, EventArgs e)
        {

            CustomerF customerF = new CustomerF(_carService, _customerRepo);
            customerF.ShowDialog();
            gridView1.RefreshData();
        }

        private void Btnedit_Click(object sender, EventArgs e)
        {
            _customer = bsCustomers.Current as Customer;

            CustomerF customerF = new CustomerF(_carService, _customerRepo, _customer);
            customerF.ShowDialog();
            _customerRepo.Update(_customer.ID, _customer);
            gridView1.RefreshData();
        }

        private void Btndelete_Click(object sender, EventArgs e)
        {

            var customer = bsCustomers.Current as Customer;
            _customerHandler.Delete(customer, _carService.Customers);
            _customerRepo.Delete(customer.ID);
            gridView1.RefreshData();
        }

        private void Btnclose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
