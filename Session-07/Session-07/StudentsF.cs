using LogicProcessing;
using LogicProcessing.Implementations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session_07
{
    public partial class StudentsF : Form
    {
        private University _university;
        private OperationsHandler<Student> _studentOperationsHandler;

        public StudentsF(University university)
        {
            InitializeComponent();
            _university = university;
            _studentOperationsHandler = new OperationsHandler<Student>(new CreateObjectOperation<Student>(), new DeleteObjectOperation<Student>());
        }

        private void StudentsForm_Load(object sender, EventArgs e)
        {
            ShowList();

            PopulateControls();
            PopulateStudents();
            SetDataBindings();
        }

        #region UI Controls
        private void ctrlStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ctrlStudents.SelectedIndex != -1)
                bsStudents.Position = ctrlStudents.SelectedIndex;
        }

        private void buttonCancelForm_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void buttonSaveForm_Click(object sender, EventArgs e)
        {
            ShowList();
        }

        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            var student = NewStudent();
            bsStudents.Add(student);
            ShowList();

        }
        private void buttonDeleteStudent_Click(object sender, EventArgs e)
        {
            DeleteStudent();

            ShowList();
        }

        #endregion
        private void PopulateControls()
        {

        }

        private void PopulateStudents()
        {
            bsUniversity.DataSource = _university;

            bsStudents.DataSource = bsUniversity;
            bsStudents.DataMember = "Students";

            bsCourses.DataSource = bsStudents;
            bsCourses.DataMember = "Courses";

            grdCourses.DataSource = bsCourses;
            
            ctrlStudents.DisplayMember = "Name";
            ctrlStudents.ValueMember = "ID";
        }

        private void SetDataBindings()
        {
            ctrlName.DataBindings.Add(new Binding("EditValue", bsStudents, "Name", true));
            ctrlAge.DataBindings.Add(new Binding("EditValue", bsStudents, "Age", true));
            ctrlRegNumber.DataBindings.Add(new Binding("EditValue", bsStudents, "RegistrationNumber", true));
        }


        private void ShowList()
        {
            ctrlStudents.Items.Clear();
            if (bsStudents.Count > 0)
            {
                foreach (Student student in bsStudents)
                {
                    ctrlStudents.Items.Add(student);
                }
            }
        }

        private Student NewStudent()
        {
            return _studentOperationsHandler.CreateObject();
        }

        private void DeleteStudent()
        {
            //_studentOperationsHandler.DeleteObject((Student)bsStudents[ctrlStudents.SelectedIndex], (List<Student>)bsStudents.List);
        }

    }
}
