using PetShopLibrary;
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
    public partial class NewEmployeeForm : Form
    {
        private PetShopManager _petShopManager;
        public NewEmployeeForm(PetShopManager petShopManager)
        {
            InitializeComponent();
            _petShopManager = petShopManager;
            this.CenterToScreen();
        }

        private void NewEmployeeForm_Load(object sender, EventArgs e)
        {
            txtSalary.Properties.MaxLength = 5;
            cmbType.DataSource = Enum.GetValues(typeof(EmployeeType));
            cmbType.SelectedIndex = -1;
            cmbType.Text = "Please choose a type..";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            int cmbIndex = cmbType.SelectedIndex;
            string name = txtName.Text;
            string surname = txtSurname.Text;
            string salary = txtSalary.Text;
            if (cmbIndex >= 0 && name != "" && surname != "" && salary != "")
            {

                EmployeeType type = (EmployeeType)cmbIndex;
                if (type.Equals(EmployeeType.Manager))
                {
                    MessageBox.Show("There is already a Manager!");
                    return;
                }
                Employee emp = new Employee()
                {
                    Name = name,
                    Surname = surname,
                    Salary = Convert.ToDecimal(salary.Split()[0]),
                    EmpType = type
                };
                
                _petShopManager.Add(emp);
                _petShopManager.Save();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please fill all the fields");
            }
                
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
