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
    public partial class ProductCreation : Form
    {
        public ProductCreation()
        {
            InitializeComponent();
        }

        EnterpriseContext databaseContext;

  


        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {


        }

        private async void AddBtn_Click(object sender, EventArgs e)
        {
            using (ProductForm popup = new ProductForm(new Product() {  }))
            {
                if (popup.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        productBindingSource.Add(popup.product);
                        databaseContext.Products.Add(popup.product);
                        await databaseContext.SaveChangesAsync();
                        ProductDataGird.Refresh();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK);
                    }
                }

            }
            
        }

        private  void AddCategoryBtn_Click(object sender, EventArgs e)
        {
            string name = categoryNameTextBox.Text;
            if (!string.IsNullOrEmpty(name))
            {

                databaseContext.Categories.Add(new Category() { Name =name });
                databaseContext.SaveChanges();
                labelError.Text = "";
                MessageBox.Show("La catégorie " + name , "Creation avec succés", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                labelError.Text = "Ce champ est obligatoire";
            }
        }

        private void ProductCreation_Load(object sender, EventArgs e)
        {
            databaseContext = new EnterpriseContext();
            productBindingSource.DataSource = databaseContext.Products.ToList();
            categoryBindingSource.DataSource = databaseContext.Categories.ToList();
        }

        private async void EditBtn_Click(object sender, EventArgs e)
        {
            Product  product = productBindingSource.Current as Product;
            if (product != null)
            {
                using (ProductForm frm = new ProductForm(product))
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            //End edit & save data to sql database
                            productBindingSource.EndEdit();
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

        private async void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to save the changes?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //End edit data & save
                    productBindingSource.EndEdit();
                    await databaseContext.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int rows = ProductDataGird.RowCount;
                for (int i = rows - 1; i >= 0; i--)
                {
                    if (ProductDataGird.Rows[i].Selected)
                    {
                        databaseContext.Customers.Remove(ProductDataGird.Rows[i].DataBoundItem as Customer);
                        productBindingSource.RemoveAt(ProductDataGird.Rows[i].Index);
                        await databaseContext.SaveChangesAsync();
                    }
                }
            }
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            productBindingSource.DataSource = databaseContext.Products.ToList();
            Cursor.Current = Cursors.Default;
        }
    }
}

   
