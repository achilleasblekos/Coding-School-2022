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
    public partial class AddNewPetFoodForm : Form
    {
        private PetShopManager _petShop;
        public AddNewPetFoodForm(PetShopManager petShopManager)
        {
            InitializeComponent();
            _petShop = petShopManager;
            this.CenterToScreen();

        }

        private void AddNewPetFoodForm_Load(object sender, EventArgs e)
        {
            
            cmbType.DataSource = Enum.GetValues(typeof(AnimalType));
            cmbType.SelectedIndex = -1;
            spinQty.Properties.MaxValue = 100;
            spinQty.Properties.MinValue = 1;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbType.SelectedIndex < 0 || cmbBrand.Text == String.Empty || txtCost.Text == String.Empty || txtPrice.Text == String.Empty)
            {
                MessageBox.Show("Please fill all the fields");
                return;
            }


            decimal cost = 0;
            decimal price = 0;
            var animalType = (AnimalType)cmbType.SelectedItem;
            var brand = cmbBrand.Text;
            var validCost = decimal.TryParse(txtCost.Text.Split()[0], out cost);
            var validPrice = decimal.TryParse(txtPrice.Text.Split()[0], out price);

            if(validCost && validPrice && (int)animalType != -1 && brand != String.Empty && price >= cost)
            {
                
                int qty = (int)spinQty.Value;
                for(int i = 0; i < qty; i++)
                {
                    var food = new PetFood()
                    {
                        Brand = brand,
                        Price = price,
                        Cost = cost,
                        Type = _petShop.GetFoodType(animalType)
                    };
                    _petShop.Add(food);
                }                
                _petShop.Save();
                this.Close();
            }
            else
            {
                MessageBox.Show("Wrong or empty values!");
            }

        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            AnimalType type = (AnimalType)cmbType.SelectedIndex;
            List<string> brands = _petShop.GetFoodBrand(type);
            cmbBrand.DataSource = brands;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
