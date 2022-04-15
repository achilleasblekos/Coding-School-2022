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
    public partial class CustomersForm : Form
    {
        private readonly IEntityRepo<Customer> _customerRepo;
        private List<Customer> _customers = new List<Customer>();
        public CustomersForm(IEntityRepo<Customer> customerRepo)
        {
            InitializeComponent();
            _customerRepo = customerRepo;
            this.CenterToScreen();

        }

        private void CustomersForm_Load(object sender, EventArgs e)
        {
            RefreshCustomers();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var customerName = txtName.Text;
            var customerSurname = txtSurname.Text;
            var customerCardNumber = txtCardNumber.Text;
            if (string.IsNullOrEmpty(customerName) || string.IsNullOrEmpty(customerSurname) || string.IsNullOrEmpty(customerCardNumber))
                return;
            var customer = new Customer();
            customer.Name = customerName;
            customer.Surname = customerSurname;
            customer.CardNumber = customerCardNumber;
            _customerRepo.Create(customer);
            txtName.Text = String.Empty;
            txtSurname.Text = String.Empty;
            txtCardNumber.Text = String.Empty;
            RefreshCustomers();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                var selectedCustomer = selectedRow.DataBoundItem as Customer;
                if (selectedCustomer is not null)
                {
                    _customerRepo.Delete(selectedCustomer.ID);
                    RefreshCustomers();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void RefreshCustomers()
        {
            _customers = _customerRepo.GetAll();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _customers;
            dataGridView1.Refresh();
            dataGridView1.Update();
        }
    }
}
