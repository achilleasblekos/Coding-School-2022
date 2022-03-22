using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PetShopLibrary;
using PetShopLibrary.DataObjects;

namespace Session_11
{
    public partial class LoginForm : Form
    {
        
        public LoginForm()
        {
            InitializeComponent();
            this.CenterToParent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            PasswordCover();
            txtPassWord.KeyPress += LoginForm_KeyPress;
        }

        private void LoginForm_KeyPress(object? sender, KeyPressEventArgs e)
        {

            if (e.KeyChar != 13) return;
            Authenticate();

            
        }

        private void Authenticate()
        {
            User user = new User();
            user.Username = txtUserName.Text;
            user.Password = txtPassWord.Text;

            if (user.Auth())
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password, please try again.", "Try Again");
            }
        }


        //private void txtPassWord_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (e.KeyChar == (char)Keys.Enter)
        //    {
        //        Authenticate();
        //    }
        //}

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            
            Authenticate();
            

        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            User user = new User();
            user.Username = txtUserName.Text;
            user.Password = txtPassWord.Text;
            if (user.Auth() == false)
            {
                Application.Exit();
            }
            else
            {
                this.Close();
            }
        }

        private void PasswordCover()
        {
            txtPassWord.Text = "";
            txtPassWord.Properties.PasswordChar = '*';
            txtPassWord.Properties.MaxLength = 10;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //private void CancelButtonManager_Click(object sender, EventArgs e)
        //{
        //    MessageBox.Show("This window will close now", "Cancel");
        //    this.Close();
        //}
    }


}
