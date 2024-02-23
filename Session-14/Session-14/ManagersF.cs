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
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session_11
{
    public partial class ManagersF : Form
    {

        private CarService _carService;
        private Manager _manager;
        private ManagerHandler _managerHandler;
        private StorageHelper _storageHelper;
        private ControlsHelper _controlsHelper;

        private readonly IEntityRepo<Manager> _managerRepo;

        public ManagersF(CarService carService, IEntityRepo<Manager> managerRepo)
        {
            InitializeComponent();
            _carService = carService;
            _managerHandler = new ManagerHandler();
            _storageHelper = new StorageHelper();
            _controlsHelper = new ControlsHelper();
            _managerRepo = managerRepo;
        }

        private void ManagersF_Load(object sender, EventArgs e)
        {
            
            PopulateCars();
            PopulateControls();
        }

        private void PopulateControls()
        {

        }

        private void PopulateCars()
        {


            bsManagers.DataSource = _carService;
            bsManagers.DataMember = "Managers";

            GrdManagers.DataSource = bsManagers;
            _controlsHelper.HideColumns("ID", gridView1);

        }

        private void Btnnew_Click(object sender, EventArgs e)
        {
            ManagerF managerF = new ManagerF(_carService, _managerRepo);
            managerF.ShowDialog();
            gridView1.RefreshData();
        }

        private void Btnedit_Click(object sender, EventArgs e)
        {
            _manager = bsManagers.Current as Manager;

            ManagerF managerF = new ManagerF(_carService, _managerRepo, _manager);
            managerF.ShowDialog();
            _managerRepo.Update(_manager.ID, _manager);
            gridView1.RefreshData();
        }

        private void Btndelete_Click(object sender, EventArgs e)
        {

            var manager = bsManagers.Current as Manager;
            _managerHandler.Delete(manager, _carService.Managers, _carService);
            _managerRepo.Delete(manager.ID);
            gridView1.RefreshData();
        }

        private void Btnclose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
