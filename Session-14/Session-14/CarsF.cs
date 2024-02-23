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
    public partial class CarsF : Form
    {
        private CarService _carService;
        private Car _car;
        private CarHandler _carHandler;
        private StorageHelper _storageHelper;
        private ControlsHelper _controlsHelper;

        private readonly IEntityRepo<Car> _carRepo;

        public CarsF(CarService carService, IEntityRepo<Car> carRepo)
        {
            InitializeComponent();
            _carService = carService;
            _carHandler = new CarHandler();
            _storageHelper = new StorageHelper();
            _controlsHelper = new ControlsHelper();
            _carRepo = carRepo;
        }

        private void CarsF_Load(object sender, EventArgs e)
        {
            
            PopulateCars();
        }

       

        private void PopulateCars()
        {
            

            bsCars.DataSource = _carService;
            bsCars.DataMember = "Cars";

            grdCars.DataSource = bsCars;
            _controlsHelper.HideColumns("ID", grvCars);

        }

        private void Btnnew_Click(object sender, EventArgs e)
        {
            CarF carF = new CarF(_carService, _carRepo);
            carF.ShowDialog();
            grvCars.RefreshData();

        }

        private void Btnedit_Click(object sender, EventArgs e)
        {
            _car = bsCars.Current as Car;

            CarF carF = new CarF(_carService, _carRepo, _car);
            carF.ShowDialog();
            _carRepo.Update(_car.ID, _car);
            grvCars.RefreshData();
        }

        private void Btndelete_Click(object sender, EventArgs e)
        {

            var car = bsCars.Current as Car;
            _carHandler.Delete(car, _carService.Cars);
            _carRepo.Delete(car.ID);
            grvCars.RefreshData();
        }

        private void Btnclose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
    

