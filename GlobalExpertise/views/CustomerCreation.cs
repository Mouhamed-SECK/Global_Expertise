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
    public partial class CustomerCreation : Form
    {
        EnterpriseContext databaseContext; 
        public CustomerCreation()
        {
            InitializeComponent();
        }

        private async void addBtn_Click(object sender, EventArgs e)
        {
            using (CustomerForm popup = new CustomerForm(new Customer() { }))
            {
                if (popup.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        customerBindingSource.Add(popup.customer);
                        databaseContext.Customers.Add(popup.customer);
                        await databaseContext.SaveChangesAsync();
                        customerDataGrid.Refresh();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK);
                    }
                }
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            customerBindingSource.DataSource = databaseContext.Employees.ToList();
  
            Cursor.Current = Cursors.Default;
        }

        private async void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to save the changes?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //End edit data & save
                    customerBindingSource.EndEdit();
                    await databaseContext.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void deleteBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int rows = customerDataGrid.RowCount;
                for (int i = rows - 1; i >= 0; i--)
                {
                    if (customerDataGrid.Rows[i].Selected)
                    {
                        databaseContext.Customers.Remove(customerDataGrid.Rows[i].DataBoundItem as Customer);
                        customerBindingSource.RemoveAt(customerDataGrid.Rows[i].Index);
                        await databaseContext.SaveChangesAsync();
                    }
                }
            }
        }

        private async void  editBtn_Click(object sender, EventArgs e)
        {
            Customer customer = customerBindingSource.Current as Customer;
            if (customer != null)
            {
                using (CustomerForm frm = new CustomerForm(customer))
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            //End edit & save data to sql database
                            customerBindingSource.EndEdit();
                            await databaseContext.SaveChangesAsync();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void CustomerCreation_Load(object sender, EventArgs e)
        {
            this.databaseContext = new EnterpriseContext();

            customerBindingSource.DataSource = databaseContext.Customers.ToList();

        }
    }
}
