using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace session_07
{
    public partial class ProfessorForm : Form
    {
        public List<ProfessorForm> ProfessorForms { get; set; }
        public ProfessorForm professor { get; set; }
        public int Age { get; set; }

        public ProfessorForm()
        {
            InitializeComponent();
        }

        #region UI Controls

        private void ProfessorForm_Load(object sender, EventArgs e)
        {
            professor = new ProfessorForm();
            professor.ShowList();

        }

        private void buttonNew_Click(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();

            this.DialogResult = DialogResult.OK;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowList();
        }

        #endregion





        private void ShowList()
        {

            listView1.Items.Clear();

            foreach (ProfessorForm item in ProfessorForms)
            {

                if (item != null)
                    listView1.Items.Add(string.Format("{0}", item.Name));
            }
        }
    }
}

