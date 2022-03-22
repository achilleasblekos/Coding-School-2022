using PetShopLibrary;
using PetShopLibrary.DataObjects;
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
    public partial class FormPetReport : Form
    {
        private List<Transaction> _listOfTransactions;

        private List<string> _months = new List<string> {
                                                        "January",
                                                        "February",
                                                        "March",
                                                        "April",
                                                        "May",
                                                        "June",
                                                        "July",
                                                        "August",
                                                        "September",
                                                        "October",
                                                        "November",
                                                        "December" 
                                                                };


        private List<Pet> _listOfPet;
        public PetShopManager petShopManager;
        private int _month;
        private int _year;

        private CustomerPolicies _customerPolicies = new CustomerPolicies();



        public FormPetReport()
        {
            InitializeComponent();
            this.CenterToScreen();
        }
        #region FormPetReport_UI
        private void FormPetReport_Load(object sender, EventArgs e)
        {
            GetInitial();

            DisplayQualities();
            






        }
        private void btnEnter_Click(object sender, EventArgs e)
        {
            
            _month = GetMonth();
            List<PetReport> petReports = new List<PetReport>();

            if (ValidMonthAndYear(_month, ctrlYear.Text))
            {
                foreach(AnimalType type in Enum.GetValues(typeof(AnimalType)))
                {
                    PetReport petReport = IncomeExpensesTotal(_month, ctrlYear.Text, type);
                    petReports.Add(petReport);
                }

                BindingSource bsPetReports = new BindingSource();
                bsPetReports.DataSource = petReports;
                gridPetReport.DataSource = bsPetReports;
                gridPetReport.Refresh();
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion
        private void GetInitial()
        {
            comboBoxMonth.Properties.Items.AddRange(_months);

            _listOfTransactions = petShopManager.GetTransactions();
            
            _listOfPet = petShopManager.GetPets();
        }

        private void DisplayQualities()
        {
            comboBoxMonth.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
        
            gridView1.OptionsBehavior.Editable = false;

        }

        private int GetMonth()
        {

            return comboBoxMonth.SelectedIndex + 1;
        }
        private bool ValidMonth(int month)
        {

            if (month == 0)
            {
                MessageBox.Show("You have not selected a month");
                return false;
            }
            return true;

        }
        private bool ValidDate(string year, int month)
        {
            if (_customerPolicies.CheckIFNumber(year))
            {
                _year = Int32.Parse(year);

                if (_year > DateTime.Now.Year || (_year == DateTime.Now.Year && month > DateTime.Now.Month))
                {
                    MessageBox.Show("We can not predict your future  yet, please enter a valid date");
                    return false;

                }
                else if (_year < 1945)
                {
                    MessageBox.Show("The Petshop was founded in 1946, please enter a valid year");
                    return false;
                }
                else
                {
                    return true;
                }

            }
            else
            {
                MessageBox.Show("Year must be a number, try again");
                return false;
            }
        }

        private bool ValidMonthAndYear(int month, string year)
        {
            if (ValidMonth(month))
            {
                return (ValidDate(year, month));
            }
            return false;
        }

         
        private bool CheckAnimalType(int animalType)
        {
            if (animalType == -1){
                MessageBox.Show("You need to select an animal type");

            }
            return !(animalType == -1); 
        }
        

        public PetReport IncomeExpensesTotal(int month, string year, AnimalType animalType)
        {
            
            decimal? _totalSold = 0;


            var _listOfMonthYearTransactions = _listOfTransactions.Where(x => (x.Date.Month == month) && x.Date.Year == Int32.Parse(year));

            //_animalType = (AnimalType)comboBoxAnimalType.SelectedIndex;

            foreach (Transaction transaction in _listOfMonthYearTransactions)
            {


                var _petID = transaction.PetID;

                
                var _specificPet = _listOfPet.FirstOrDefault(y => y.ID == _petID);
                

                if (_specificPet.AnimalType == animalType && _specificPet != null) 
                {
                    _totalSold++;
                   
                }
               


            }

            //Defined an object and bind it to the grid. We can just show the results it to the text boxes but I think it was asked to be done like this.
            //Enum.TryParse(comboBoxAnimalType.Text,out AnimalType type);


            PetReport petReport = new PetReport()
            {
                Year = Convert.ToInt32(ctrlYear.Text),
                Month = _months[comboBoxMonth.SelectedIndex],
                Type = animalType,
                TotalSold = Convert.ToInt32(_totalSold)
            };

            return petReport;
            
        }

       
    }
}
