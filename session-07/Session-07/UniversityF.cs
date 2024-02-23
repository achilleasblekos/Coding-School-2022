using LogicProcessing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace Session_07
{
    public partial class UniversityF : Form
    {
        University _universityItem;
        private const string FILE_NAME = "storage.json";

        public UniversityF()
        {
            InitializeComponent();
        }

        #region UI
        private void UniversityForm_Load(object sender, EventArgs e)
        {
            _universityItem = new University()
            {
                Name = "Our University",
                YearsInService = 100,
                Students = new List<Student>(),
                Courses = new List<Course>(),
                Professors = new List<Professor>(),
                Grades = new List<Grade>(),
                ScheduledCourses = new List<Schedule>()
            };

        }

        private void barButtonStudentsEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowForm(new StudentsF(_universityItem));
        }
        private void barButtonProfessorsEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowForm(new ProfessorsF()
            {
                UniversityItem = _universityItem
            });
        }
        private void UniversityForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveData();
        }
        private void barButtonCoursesEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowForm(new CoursesF()
            {
                UniversityItem = _universityItem
            });
        }
        private void barButtonSaveProgram_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveData();
        }
        private void barButtonLoadProgram_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadData();
        }

        #endregion

        private void LoadData()
        {
            try
            {
                string fileToLoad = File.ReadAllText(FILE_NAME);
                _universityItem = JsonConvert.DeserializeObject<University>(fileToLoad);
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was a problem with loading the file.");
            }
        }

        private void SaveData()
        {
            string json = JsonConvert.SerializeObject(_universityItem, Formatting.Indented);
            File.WriteAllText(FILE_NAME, json);
        }


        private void ShowForm(Form form)
        {
            form.ShowDialog();
        }

    }
}
