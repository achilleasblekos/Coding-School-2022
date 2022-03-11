using System.Text.Json;
using University;

namespace session_07
{
    public partial class University : Form
    {
        private const string FILE_NAME = "storage.json";
        private University.Professor professor;

       
        public University()
        {
            InitializeComponent();
        }

        #region UI Controls

        private void loadToolStripMenuItemFile_Click_1(object sender, EventArgs e)
        {
            LoadData();
        }

        private void saveToolStripMenuItemFile_Click_1(object sender, EventArgs e)
        {
            SaveData();
        }


        private void loadToolStripMenuItemProfessor_Click_1(object sender, EventArgs e)
        {
            //professor = new Professor();
            //string json = JsonSerializer.Serialize(professor);
            //File.WriteAllText(FILE_NAME, json);
            LoadData();
        }

        private void saveToolStripMenuItemProfessor_Click_1(object sender, EventArgs e)
        {
            //string s = File.ReadAllText(FILE_NAME);
            //textBox1.Text = s;
            SaveData();
        }

        private void editToolStripMenuItemProfessor_Click(object sender, EventArgs e)
        {
            ProfessorForm _professorForm = new ProfessorForm();
            LoadData();

            _professorForm.ShowDialog();

        }

        private void loadToolStripMenuItemStudent_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void saveToolStripMenuItemStudent_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void editToolStripMenuItemStudent_Click(object sender, EventArgs e)
        {
            StudentForm _studentForm = new StudentForm();
            _studentForm.ShowDialog();
        }

        private void loadToolStripMenuItemGrade_Click(object sender, EventArgs e)
        {
            LoadData();

        }

        private void saveToolStripMenuItemGrade_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void editToolStripMenuItemGrade_Click(object sender, EventArgs e)
        {

        }

        private void loadToolStripMenuItemCourse_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void saveToolStripMenuItemCourse_Click(object sender, EventArgs e)
        {
            SaveData();
        }
        private void editToolStripMenuItemCourse_Click(object sender, EventArgs e)
        {

        }

        private void loadToolStripMenuItemSchedule_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void saveToolStripMenuItemSchedule_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void editToolStripMenuItemSchedule_Click(object sender, EventArgs e)
        {

        }

        #endregion

        private class Professor
        {
        }




        private void LoadData()
        {

            string s = File.ReadAllText(FILE_NAME);

            textBox1.Text = s;
            Professor professor1 = new Professor();
            professor1.GetType().GetProperty(Name);

            professor = (University.Professor)JsonSerializer.Deserialize(s, typeof(University.Professor));

        }

        private void SaveData()
        {
            File.WriteAllText(FILE_NAME, textBox1.Text);
            string json = JsonSerializer.Serialize(professor);
            MessageBox.Show("File Saved!");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}