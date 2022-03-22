using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid.Columns;
using PetShopLibrary;

namespace Session_11
{
    public partial class EmployeesForm : Form
    {
        private List<Employee> _employees;
        public PetShopManager petShopManager;
        //private Employee _employee;
        public EmployeesForm(PetShopManager petShop)
        {
            petShopManager = petShop;
            InitializeComponent();
            this.CenterToScreen();
        }


        private void EmployeesF_Load(object sender, EventArgs e)
        {
            BindingSource bsEmployees = new BindingSource();
            bsEmployees.DataSource = petShopManager.GetEmployees();
            grdEmployees.DataSource = bsEmployees;

            grvEmployees.Columns["ObjectStatus"].FilterInfo = new ColumnFilterInfo("ObjectStatus == 'Active'");

        }

        private void EmployeesF_Load_1(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            NewEmployeeForm form = new NewEmployeeForm(petShopManager);
            form.ShowDialog();
            grvEmployees.RefreshData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Employee employee = grvEmployees.GetFocusedRow() as Employee;
            if (employee == null || employee.EmpType.Equals(EmployeeType.Manager) || employee.EmpType.Equals(EmployeeType.CEO)) return;
            petShopManager.Delete(employee);
            petShopManager.Save();
            grvEmployees.RefreshData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            petShopManager.Save();
            MessageBox.Show("Saved");
        }
    }
}
