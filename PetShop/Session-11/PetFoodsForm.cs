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
    public partial class PetFoodsForm : Form
    {
       
        private PetShopManager _petShop;
        public PetFoodsForm(PetShopManager petShop)
        {
            InitializeComponent();
            _petShop = petShop;
            this.CenterToScreen();
        }

        private void PetFoodsForm_Load(object sender, EventArgs e)
        {

            BindingSource bsPetFood = new BindingSource();
            bsPetFood.DataSource = _petShop.GetPetFoods();
            grdPetFoods.DataSource = bsPetFood;
            grvPetFoods.Columns["ObjectStatus"].FilterInfo = new ColumnFilterInfo("ObjectStatus == 'Active'");
            grvPetFoods.RefreshData();

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            AddNewPetFoodForm addNeewPetFoodForm = new AddNewPetFoodForm(_petShop);
            addNeewPetFoodForm.ShowDialog();
            grvPetFoods.RefreshData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _petShop.Save();
            MessageBox.Show("Saved");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            PetFood petFood = grvPetFoods.GetFocusedRow() as PetFood;
            if (petFood == null) return;
            _petShop.Delete(petFood);
            _petShop.Save();
            grvPetFoods.RefreshData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
