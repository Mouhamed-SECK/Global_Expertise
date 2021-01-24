using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GlobalExpertise.DAL;
using GlobalExpertise.models;

namespace GlobalExpertise.views
{
    public partial class CustomerForm : Form
    {

       
        public CustomerForm(Customer customer)
        {
            InitializeComponent();
            customerBindingSource.DataSource = customer;
        }

        public Customer customer { get { return customerBindingSource.Current as Customer; } }


        private  void saveBtn_Click(object sender, EventArgs e)
        {
            if (customer.IsValid)
            {
                customerBindingSource.EndEdit();
                DialogResult = DialogResult.OK;
            }
        }
    }
}
