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
    public partial class PetForm : Form
    {
       
        public PetShopManager _petShop;
        
       
        public PetForm(PetShopManager petShop)
        {
            InitializeComponent();
            _petShop = petShop;
            this.CenterToScreen();
        }

        private void PetForm_Load(object sender, EventArgs e)
        { 
            BindingSource bsPets = new BindingSource();
            bsPets.DataSource = _petShop.GetPets();

            grdPets.DataSource = bsPets;
            grvPets.Columns["ObjectStatus"].FilterInfo = new ColumnFilterInfo("ObjectStatus == 'Active'");
            grvPets.RefreshData();
           

        }
        

        private void btnNew_Click(object sender, EventArgs e)
        {
            
            AddNewPetF addNewPetForm = new AddNewPetF(_petShop);
            addNewPetForm.ShowDialog();
            grvPets.RefreshData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Pet pet= grvPets.GetFocusedRow() as Pet;
            if (pet == null) return;
            _petShop.Delete(pet);
            _petShop.Save();
            grvPets.RefreshData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _petShop.Save();
            MessageBox.Show("Saved");
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
