using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GlobalExpertise.models;
using GlobalExpertise.services;

namespace GlobalExpertise
{
    public partial class Login : Form
    {
        Users usersService;
        public Login()
        {
            usersService = new Users();
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string userNmame = userNameTextBox.Text;
            string password = passwordTextBox.Text;
            if (string.IsNullOrEmpty(userNmame) || string.IsNullOrEmpty(password))
            {
                labelError.Text = "Ces champs ne peuvent être vide";
                userNameTextBox.Focus();
                return;
            }
            Employee employee = usersService.getEmployee(userNmame, password);

            if (employee !=null){
                using (Dashbord dashbord = new Dashbord(employee) )
                {
                    this.Hide();
                    dashbord.ShowDialog();
                }
            } else
            {
                labelError.Text = "Login ou password incorect";
            }

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
