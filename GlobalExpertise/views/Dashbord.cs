using GlobalExpertise.views;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using GlobalExpertise.models;
using GlobalExpertise.DAL;


namespace GlobalExpertise
{
    public partial class Dashbord : Form
    {
         EnterpriseContext databaseContext;

        public Dashbord()
        {
            InitializeComponent();
          
        }


        private void Dashbord_Load(object sender, EventArgs e)
        {
            this.databaseContext = new EnterpriseContext();
            employeeBindingSource.DataSource = databaseContext.Employees.ToList();
            departementBindingSource.DataSource = databaseContext.Departements.ToList();

        }

        private void browseBtn_click(object sender, EventArgs e)
        {
            using(OpenFileDialog ofd = new OpenFileDialog() { Filter ="JPEG|*.jpg"})
            {
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    guna2PictureBox1.Image = Image.FromFile(ofd.FileName);
                    Employee employee = employeeBindingSource.Current as Employee;
                    if (employee != null)
                    {
                        // set url image
                    }
                }
            }
        }



        private async void saveBtn_Click(object sender, EventArgs e)
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
            using (EmployeeForm popup = new EmployeeForm(new Employee() { Password ="passer" }))
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
        private async void editBtn_Click(object sender, EventArgs e)
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


        private async void deleteBtn_Click(object sender, EventArgs e)
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

        private void refreshBtn_Click(object sender, EventArgs e)
        {

            
            Cursor.Current = Cursors.WaitCursor;
            employeeBindingSource.DataSource = databaseContext.Employees.ToList();
            departementBindingSource.DataSource = databaseContext.Departements.ToList();
            Cursor.Current = Cursors.Default; 
        }
    }
}
