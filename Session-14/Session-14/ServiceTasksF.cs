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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session_11
{
    public partial class ServiceTasksF : Form
    {
        private CarService _carService;
        private ServiceTask _selectedServiceTask;
        private ServiceTaskHandler _serviceTaskHandler;
        private StorageHelper _storageHelper;
        private ControlsHelper _controlsHelper;

        private readonly IEntityRepo<ServiceTask> _serviceTaskRepo;

        public ServiceTasksF(CarService carService, IEntityRepo<ServiceTask> serviceTaskRepo)
        {
            InitializeComponent();
            _carService = carService;
            _selectedServiceTask = new ServiceTask();
            _serviceTaskHandler = new ServiceTaskHandler();
            _storageHelper = new StorageHelper();
            _controlsHelper = new ControlsHelper();
            _serviceTaskRepo = serviceTaskRepo;
        }

        private void ServiceTaskF_Load(object sender, EventArgs e)
        {
            
            PopulateServiceTask();
        }

        private void PopulateServiceTask()
        {
            bsServiceTasks.DataSource = _carService;
            bsServiceTasks.DataMember = "ServiceTasks";

            GrdServiceTasks.DataSource = bsServiceTasks;

            _controlsHelper.HideColumns("ID", gridView1);
        }

        private void Btnnew_Click(object sender, EventArgs e)
        {
            ServiceTaskF serviceTaskF = new ServiceTaskF(_carService, _serviceTaskRepo);
            serviceTaskF.ShowDialog();
            gridView1.RefreshData();

        }

        private void Btnedit_Click(object sender, EventArgs e)
        {
            _selectedServiceTask = bsServiceTasks.Current as ServiceTask;

            ServiceTaskF serviceTaskF = new ServiceTaskF(_carService, _serviceTaskRepo, _selectedServiceTask);
            _serviceTaskRepo.Update(_selectedServiceTask.ID, _selectedServiceTask);
            serviceTaskF.ShowDialog();
            gridView1.RefreshData();
        }

        private void Btndelete_Click(object sender, EventArgs e)
        {
            var serviceTask = bsServiceTasks.Current as ServiceTask;
            _serviceTaskHandler.Delete(serviceTask, _carService.ServiceTasks);
            _serviceTaskRepo.Delete(serviceTask.ID);
            gridView1.RefreshData();
        }

        private void Btnclose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
