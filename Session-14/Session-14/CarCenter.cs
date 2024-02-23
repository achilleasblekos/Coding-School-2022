using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using DevExpress.LookAndFeel;
using DevExpress.Utils;
using App.Models.Entities;
using App.Models.EntitiesHandlers;
using HelperFunctions;
using App.EF.Repository;
using Transaction = App.Models.Entities.Transaction;

namespace Session_11
{
    public partial class CarCenter : Form
    {
        private const string FILE_NAME = "storage.json";
        private CarService _carService;
        private StorageHelper _storageHelper;
        private MessagesHelper _messagesHelper;
        private MonthlyLedgerHandler _monthlyLedgerHandler;

        private readonly IEntityRepo<Car> _carRepo;
        private readonly IEntityRepo<Customer> _customerRepo;
        private readonly IEntityRepo<Manager> _managerRepo;
        private readonly IEntityRepo<Engineer> _engineerRepo;
        private readonly IEntityRepo<ServiceTask> _serviceTaskRepo;
        private readonly IEntityRepo<Transaction> _transactionRepo;

        public CarCenter(IEntityRepo<Car> carRepo, IEntityRepo<Customer> customerRepo,
                         IEntityRepo<Manager> managerRepo, IEntityRepo<Engineer> engineerRepo,
                         IEntityRepo<ServiceTask> serviceTaskRepo, IEntityRepo<Transaction> transactionRepo)
        {
            InitializeComponent();
            _carRepo = carRepo;
            _customerRepo = customerRepo;
            _managerRepo = managerRepo;
            _engineerRepo = engineerRepo;
            _serviceTaskRepo = serviceTaskRepo;
            _transactionRepo = transactionRepo;


            // Set Default Theme
            UserLookAndFeel.Default.SetSkinStyle(SkinStyle.Office2019DarkGray);
            
            _storageHelper = new StorageHelper();
            _messagesHelper = new MessagesHelper();
            _monthlyLedgerHandler = new MonthlyLedgerHandler();
            _carService = new CarService();
        }

        #region UI Controls

        private void CarCenter_Load(object sender, EventArgs e)
        {
            _carService.Cars = _carRepo.GetAll();
            _carService.Customers = _customerRepo.GetAll();
            _carService.Managers = _managerRepo.GetAll();
            _carService.Engineers = _engineerRepo.GetAll();
            _carService.ServiceTasks = _serviceTaskRepo.GetAll();
            _carService.Transactions = _transactionRepo.GetAll();
        }

        private void buttonLoad_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        }

        private void buttonSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        }

        private void buttonTransShow_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowForm(new TransactionsF(_carService, _transactionRepo));
        }
        private void buttonManagers_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowForm(new ManagersF(_carService, _managerRepo));
        }
        private void buttonServiceTask_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowForm(new ServiceTasksF(_carService, _serviceTaskRepo));
        }

        private void buttonCustomers_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowForm(new CustomersF(_carService, _customerRepo));
        }

        private void buttonEngineers_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowForm(new EngineersF(_carService, _engineerRepo));
        }

        private void buttonCars_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowForm(new CarsF(_carService, _carRepo));
        }

        private void buttonLedgersShow_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowForm(new MonthlyLedgersF(_carService));
        }

        #endregion


        private void ShowForm(Form form)
        {
            form.ShowDialog();
        }

        private void buttonLedgersCreate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _monthlyLedgerHandler.CreateMonthlyLedger(_carService);
            _messagesHelper.MessageInfo("Monthly Ledger created successfully.");
        }
    }
}
