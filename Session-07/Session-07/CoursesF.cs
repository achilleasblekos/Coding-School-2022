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

namespace Session_07
{
    public partial class CoursesF : Form
    {
        public University UniversityItem { get; set; }
        private Course _selectedCourse;


        public CoursesF()
        {
            InitializeComponent();
        }
        #region UI Controls

        private void CoursesForm_Load(object sender, EventArgs e)
        {
            ShowList();
        }

        private void listBoxCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectCourse();

            DisplayCourse();
        }

        private void buttonCancelForm_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void buttonSaveForm_Click(object sender, EventArgs e)
        {
            SaveCourse();

            ShowList();
        }

        private void buttonDeleteCourse_Click(object sender, EventArgs e)
        {
            DeleteCourse();

            ShowList();
        }

        private void buttonAddCourse_Click(object sender, EventArgs e)
        {
            ShowList();

        }

        #endregion

        private void ShowList()
        {
            listBoxCourses.Items.Clear();

            foreach (Course item in UniversityItem.Courses)
            {
                listBoxCourses.Items.Add(item.Code);
            }
        }

        private void DisplayCourse()
        {
            if (_selectedCourse != null)
            {
                textEditCode.Text = _selectedCourse.Code;
                textEditSubject.Text = _selectedCourse.Subject;
            }
            else
            {
                textEditCode.Text = string.Empty;
                textEditSubject.Text = string.Empty;
            }
        }
        private void SaveCourse()
        {
            if (_selectedCourse != null)
            {
                _selectedCourse.Code = textEditCode.Text;
                _selectedCourse.Subject = textEditSubject.Text;
            }
        }
      

        private void SelectCourse()
        {
            if (UniversityItem.Courses.Count > 0)
            {
                if (listBoxCourses.SelectedIndex != -1)
                {
                    _selectedCourse = UniversityItem.Courses[listBoxCourses.SelectedIndex];
                }
                else
                {
                    _selectedCourse = UniversityItem.Courses[0];
                }
            }
        }
        private void DeleteCourse()
        {
            _selectedCourse = null;

        }
    }
}
