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
    public partial class ItemsForm : Form
    {
        private readonly IEntityRepo<Item> _itemRepo;
        private List<Item> _items = new List<Item>();
        public ItemsForm(IEntityRepo<Item> itemRepo)
        {
            InitializeComponent();
            _itemRepo = itemRepo;
            this.CenterToScreen();
        }

        private void ItemsForm_Load(object sender, EventArgs e)
        {
            RefreshItems();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            NewItemForm newItemForm = new NewItemForm();
            newItemForm.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RefreshItems()
        {
            _items = _itemRepo.GetAll();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _items;
            dataGridView1.Refresh();
            dataGridView1.Update();
        }
    }
}
