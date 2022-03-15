using System.IO;
using System.Text.Json;
using University_new;

namespace session08_new07;

public partial class University : Form
{
    private const string FILE_NAME = "storage.json";
    private University_new.University1 _university1;
    

    public University()
    {
        InitializeComponent();
    }
    #region UI Controls
    private void University_Load(object sender, EventArgs e)
    {

    }

    private void loadUniversity_Click(object sender, EventArgs e)
    {

    }

    private void saveUniversity_Click(object sender, EventArgs e)
    {

    }

    private void editUniversity_Click(object sender, EventArgs e)
    {

    }

    private void loadProfessors_Click(object sender, EventArgs e)
    {
        LoadData();
    }

    private void saveProfessors_Click(object sender, EventArgs e)
    {
        SaveData();
    }

    private void editProfessors_Click(object sender, EventArgs e)
    {
        LoadData();
        _university1 = new University_new.University1();
        _university1.Professors = new List<University1.Professor>();

        ProfessorsForm professorform = new ProfessorsForm();

       
        professorform.ShowDialog();
    }

    private void loadStudents_Click(object sender, EventArgs e)
    {

    }

    private void saveStudents_Click(object sender, EventArgs e)
    {

    }

    private void editStudents_Click(object sender, EventArgs e)
    {
        StudentsForm studentsForm = new StudentsForm();
        studentsForm.ShowDialog();
    }

    private void loadGrades_Click(object sender, EventArgs e)
    {

    }

    private void saveGrades_Click(object sender, EventArgs e)
    {

    }

    private void editGrades_Click(object sender, EventArgs e)
    {
        GradesForm gradesForm = new GradesForm();
        gradesForm.ShowDialog();
    }

    private void loadCourses_Click(object sender, EventArgs e)
    {

    }

    private void saveCourses_Click(object sender, EventArgs e)
    {

    }

    private void editCourses_Click(object sender, EventArgs e)
    {
        CoursesForm coursesForm = new CoursesForm();
        coursesForm.ShowDialog();
    }

    private void loadSchedules_Click(object sender, EventArgs e)
    {

    }

    private void saveSchedules_Click(object sender, EventArgs e)
    {

    }

    private void editSchedules_Click(object sender, EventArgs e)
    {
        SchedulesForm schedulesForm = new SchedulesForm();
        schedulesForm.ShowDialog();
    }
    #endregion


    private void LoadData()
    {

        string s = File.ReadAllText(FILE_NAME);

        //textBox1.Text = s;

        _university1 = (University_new.University1)JsonSerializer.Deserialize(s, typeof(University_new.University1));

        MessageBox.Show("Loaded OK!");
    }


    private void SaveData()
    {
        string json = JsonSerializer.Serialize(_university1);

        File.WriteAllText(FILE_NAME, json);

        MessageBox.Show("File Saved!");
    }
}

