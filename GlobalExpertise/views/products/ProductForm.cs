using GlobalExpertise.DAL;
using GlobalExpertise.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlobalExpertise.views
{
    public partial class ProductForm : Form
    {
        public ProductForm(models.Product product)
        {
            InitializeComponent();
            productBindingSource.DataSource = product;
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            productComboBox.DisplayMember = "Name";
            productComboBox.ValueMember = "catregoryId";

            using (EnterpriseContext db = new EnterpriseContext())
            {
                productComboBox.DataSource = db.Categories.ToList();
            }
        }

        public Product product { get { return productBindingSource.Current as Product; } }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (product.IsValid)
            {
                productBindingSource.EndEdit();
                DialogResult = DialogResult.OK;
            }
        }
    }
}
