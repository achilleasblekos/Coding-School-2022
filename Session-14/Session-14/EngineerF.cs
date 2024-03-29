﻿using App.EF.Repository;
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
    public partial class EngineerF : Form
    {
        private const string FILE_NAME = "storage.json";
        private CarService _carService;
        private Engineer _engineer;
        private EngineerHandler _engineerHandler;
        private StorageHelper _storageHelper;

        private readonly IEntityRepo<Engineer> _engineerRepo;

        public EngineerF(CarService carService, IEntityRepo<Engineer> engineerRepo)
        {
            InitializeComponent();
            _carService = carService;
            _engineerHandler = new EngineerHandler();
            _storageHelper = new StorageHelper();
            _engineerRepo = engineerRepo;
        }

        public EngineerF(CarService carService, IEntityRepo<Engineer> engineerRepo, Engineer engineer) : this(carService, engineerRepo)
        {
            _engineer = engineer;
        }

        private void SetDataBindings()
        {
            Ctrlname.DataBindings.Add(new Binding("EditValue", bsEngineer, "Name", true));
            Ctrlsurname.DataBindings.Add(new Binding("EditValue", bsEngineer, "Surname", true));
            Ctrlsallarypermonth.DataBindings.Add(new Binding("EditValue", bsEngineer, "SallaryPerMonth", true));
            CtrlmanagerID.DataBindings.Add(new Binding("EditValue", bsEngineer, "ManagerID", true));
            
        }
        private void PopulateControls()
        {
            var controlHelper = new ControlsHelper();
            controlHelper.PopulateManagers(CtrlmanagerID.Properties, _carService.Managers);
        }

        private void SaveEngineer()
        {
            if (_carService.Engineers.FindAll(c => c.ID == _engineer.ID).Count() <= 0)
            {
                _carService.Engineers.Add(_engineer);
                _engineerRepo.Create(_engineer);
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void CarF_Load(object sender, EventArgs e)
        {
            PopulateControls();

            if (_engineer == null)
            {
                _engineer = (Engineer)_engineerHandler.Create();
            }
            bsEngineer.DataSource = _engineer;

            SetDataBindings();
        }

        private void Btnsave_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show("Please fill the empty fields", "Warning");
                return;
            }
            if (Convert.ToDecimal(Ctrlsallarypermonth.EditValue.ToString()) < Ctrlsallarypermonth.Properties.MinValue)
            {
                MessageBox.Show("Sallary can't be a negative number", "Warning");
                return;
            }
            SaveEngineer();
        }

        private void Btnexit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void Ctrlname_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Ctrlname.Text))
            {
                e.Cancel = true;
                Ctrlname.Focus();
                errorProvider1.SetError(Ctrlname, "Name should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(Ctrlname, "");
            }
        }

        private void Ctrlsurname_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Ctrlsurname.Text))
            {
                e.Cancel = true;
                Ctrlsurname.Focus();
                errorProvider1.SetError(Ctrlsurname, "Surname should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(Ctrlsurname, "");
            }
        }

        private void CtrlmanagerID_Validating(object sender, CancelEventArgs e)
        {
            if (_carService.Managers.FirstOrDefault(m => m.ID.ToString() == CtrlmanagerID.EditValue.ToString()) == null)
            {
                e.Cancel = true;
                CtrlmanagerID.Focus();
                errorProvider1.SetError(CtrlmanagerID, "Manager should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(CtrlmanagerID, "");
            }
        }
    }
}
