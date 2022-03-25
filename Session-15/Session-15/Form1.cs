using Session_15.EF.Repositories;

namespace Session_15
{
    public partial class Form1 : Form
    {
        private PetShopManager _petShop;
        public Form1(PetShopManager petShop)
        {
            InitializeComponent();
            _petShop = petShop;
            this.CenterToScreen();
        }

        private void petsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PetsForm petsForm = new PetsForm(_petShop);
            petsForm.ShowDialog();
        }
    }
}