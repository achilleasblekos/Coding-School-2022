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
    public partial class ProfessorsF : Form
    {
        public University UniversityItem { get; set; }
        private Professor _selectedProfessor;

        public ProfessorsF()
        {
            InitializeComponent();
        }

        #region UI Controls

        private void buttonAddProfessor_Click(object sender, EventArgs e)
        {
            ShowList();

        }

        private void buttonDeleteProfessor_Click(object sender, EventArgs e)
        {
            DeleteProfessor();

            ShowList();
        }

        private void buttonSaveForm_Click(object sender, EventArgs e)
        {
            SaveProfessor();

            ShowList();
        }

        private void buttonCancelForm_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void ProfessorForm_Load(object sender, EventArgs e)
        {
            ShowList();
        }

        private void listBoxProfessors_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectProfessor();

            DisplayProfessor();
        }

        #endregion

        private void ShowList()
        {
            listBoxProfessors.Items.Clear();

            foreach (Professor item in UniversityItem.Professors)
            {
                listBoxProfessors.Items.Add(item.Name);
            }
        }

        private void DisplayProfessor()
        {
            if (_selectedProfessor != null)
            {
                textEditName.Text = _selectedProfessor.Name;
                spinEditAge.Text = _selectedProfessor.Age.ToString();
                comboEditRank.Text = _selectedProfessor.Rank;

                listBoxCourses.Items.Clear();
                if (_selectedProfessor.Courses != null)
                {
                    foreach (Course item in _selectedProfessor.Courses)
                    {
                        listBoxCourses.Items.Add(item.Code);
                    }
                }
            }
            else
            {
                textEditName.Text = string.Empty;
                spinEditAge.Text = "0";
                comboEditRank.Text = "";
                listBoxCourses.Items.Clear();
            }
        }

        private void SaveProfessor()
        {
            if (_selectedProfessor != null)
            {
                _selectedProfessor.Name = textEditName.Text;
                _selectedProfessor.Age = Convert.ToInt32(spinEditAge.Text);
                _selectedProfessor.Rank = comboEditRank.Text;
            }
        }


        private void SelectProfessor()
        {
            if (UniversityItem.Professors.Count > 0)
            {
                if (listBoxProfessors.SelectedIndex != -1)
                {
                    _selectedProfessor = UniversityItem.Professors[listBoxProfessors.SelectedIndex];
                }
                else
                {
                    _selectedProfessor = UniversityItem.Professors[0];
                }
            }
        }

        private void DeleteProfessor()
        {
            _selectedProfessor = null;

        }
    }
}
