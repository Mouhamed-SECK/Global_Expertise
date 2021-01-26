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
using GlobalExpertise.DAL;

namespace GlobalExpertise.views
{
    public partial class EmployeeForm : Form
    {
        public EmployeeForm(Employee employee)
        {
            InitializeComponent();
            bindingSourceEmployee.DataSource = employee;
           
        }

        public Employee employee { get { return bindingSourceEmployee.Current as Employee; } }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            departementComboBox.DisplayMember = "Name";
            departementComboBox.ValueMember = "departementId";

            using (EnterpriseContext db = new EnterpriseContext())
            {
                departementComboBox.DataSource = db.Departements.ToList();
            }
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if(employee.IsValid)
            {
                bindingSourceEmployee.EndEdit();
                DialogResult = DialogResult.OK;
            }
        }
    }
}
