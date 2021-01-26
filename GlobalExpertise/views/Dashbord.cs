using System;
using System.Windows.Forms;
using GlobalExpertise.models;
using GlobalExpertise.views;

namespace GlobalExpertise
{
    public partial class Dashbord : Form
    {
       
        Employee loggedEmployee;
        public Dashbord(Employee loggedEmployee)
        {
            this.loggedEmployee = loggedEmployee;        
            InitializeComponent();
        }

  

        private void Dashbord_Load(object sender, EventArgs e)
        {
            this.GetViewConfiguration("EmployeCreation");
            name.Text = loggedEmployee.Name;
            departement.Text = loggedEmployee.Departement.Name;
        }

       
        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            using(Login login = new Login())
            {
                this.Hide();
                login.ShowDialog();
            }
        }

        private void Employees_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
            GetViewConfiguration("EmployeCreation");
        }
        private void Customers_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
            GetViewConfiguration("CustomerCreation");
        }

     

        private void GetViewConfiguration(string viewName)
        {
            var viewToInstantiate = "GlobalExpertise.views." + viewName + ", GlobalExpertise";
            var objectType = Type.GetType(viewToInstantiate);
            Form view = (Form)Activator.CreateInstance(objectType);
            view.FormBorderStyle = FormBorderStyle.None;
            view.Dock = DockStyle.Fill;
            view.TopLevel = false;
            view.TopMost = true;
            panelContainer.Controls.Add(view);
            view.Show();
        }

        private void products_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
            GetViewConfiguration("ProductCreation");
        }
    }
    
}
