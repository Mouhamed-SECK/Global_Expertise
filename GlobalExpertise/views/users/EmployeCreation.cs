using System;

using System.Linq;
using System.Windows.Forms;
using GlobalExpertise.DAL;
using GlobalExpertise.models;
namespace GlobalExpertise.views
{
    public partial class EmployeCreation : Form
    {
        public EmployeCreation()
        {
            InitializeComponent();
        }


        EnterpriseContext databaseContext;


        private async void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to save the changes?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //End edit data & save
                    employeeBindingSource.EndEdit();
                    await databaseContext.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void AddBtn_Click(object sender, EventArgs e)
        {
            using (EmployeeForm popup = new EmployeeForm(new Employee() { Password = "passer" }))
            {
                if (popup.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        employeeBindingSource.Add(popup.employee);
                        databaseContext.Employees.Add(popup.employee);
                        await databaseContext.SaveChangesAsync();
                        employeeDataGrid.Refresh();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK);
                    }
                }

            }
        }
        private async void EditBtn_Click(object sender, EventArgs e)
        {
            Employee employee = employeeBindingSource.Current as Employee;
            if (employee != null)
            {
                using (EmployeeForm frm = new EmployeeForm(employee))
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            //End edit & save data to sql database
                            employeeBindingSource.EndEdit();
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


        private async void DeleteBtn_Click(object sender, EventArgs e)
        {
            //Delete data from binding source, then save to sql database
            if (MessageBox.Show("Are you sure want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int rows = employeeDataGrid.RowCount;
                for (int i = rows - 1; i >= 0; i--)
                {
                    if (employeeDataGrid.Rows[i].Selected)
                    {
                        databaseContext.Employees.Remove(employeeDataGrid.Rows[i].DataBoundItem as Employee);
                        employeeBindingSource.RemoveAt(employeeDataGrid.Rows[i].Index);
                        await databaseContext.SaveChangesAsync();
                    }
                }
            }
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            employeeBindingSource.DataSource = databaseContext.Employees.ToList();
            departementBindingSource.DataSource = databaseContext.Departements.ToList();
            Cursor.Current = Cursors.Default;
        }

        private void searchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {

                employeeBindingSource.Filter = employeeDataGrid.Columns[3].HeaderText.ToString() + " LIKE '%" + searchTextBox.Text.Trim() + "";
                employeeDataGrid.DataSource = employeeBindingSource;
            }
        }

        private void EmployeCreation_Load(object sender, EventArgs e)
        {
            this.databaseContext = new EnterpriseContext();
            employeeBindingSource.DataSource = databaseContext.Employees.ToList();
            departementBindingSource.DataSource = databaseContext.Departements.ToList();
        }

    }
}
