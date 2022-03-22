using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using University_new;

namespace session08_new07
{
    public partial class ProfessorsForm : Form
    {
        private const string FILE_NAME = "storage.json";
        private University_new.University1 _university1;

        public string Name { get; set; }
        public int Age { get; set; }

        public ProfessorsForm()
        {
            InitializeComponent();
        }

        private void ProfessorsForm_Load(object sender, EventArgs e, List<University1.Professor> professors)
        {
            _university1 = new University_new.University1();
            _university1.Professors = professors;
            

        }

        private void newButton_Click(object sender, EventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {

        }

        private void listBoxControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
