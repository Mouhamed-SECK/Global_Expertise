
namespace GlobalExpertise.views
{
    partial class CustomerCreation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.customerDataGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addBtn = new Guna.UI2.WinForms.Guna2Button();
            this.searchTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.RefreshBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.DeleteBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.SaveBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.EditBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // customerDataGrid
            // 
            this.customerDataGrid.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.customerDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.customerDataGrid.AutoGenerateColumns = false;
            this.customerDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customerDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.customerDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customerDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.customerDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customerDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.customerDataGrid.ColumnHeadersHeight = 50;
            this.customerDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.Nom,
            this.FirstName,
            this.emailDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn});
            this.customerDataGrid.DataSource = this.customerBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.customerDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.customerDataGrid.EnableHeadersVisualStyles = false;
            this.customerDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.customerDataGrid.Location = new System.Drawing.Point(45, 81);
            this.customerDataGrid.Name = "customerDataGrid";
            this.customerDataGrid.RowHeadersVisible = false;
            this.customerDataGrid.RowHeadersWidth = 51;
            this.customerDataGrid.RowTemplate.Height = 24;
            this.customerDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customerDataGrid.Size = new System.Drawing.Size(1141, 601);
            this.customerDataGrid.TabIndex = 0;
            this.customerDataGrid.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.customerDataGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.customerDataGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.customerDataGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.customerDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.customerDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.customerDataGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.customerDataGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.customerDataGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.customerDataGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.customerDataGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.customerDataGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.customerDataGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.customerDataGrid.ThemeStyle.HeaderStyle.Height = 50;
            this.customerDataGrid.ThemeStyle.ReadOnly = false;
            this.customerDataGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.customerDataGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.customerDataGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.customerDataGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.customerDataGrid.ThemeStyle.RowsStyle.Height = 24;
            this.customerDataGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.customerDataGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // Nom
            // 
            this.Nom.DataPropertyName = "Name";
            this.Nom.HeaderText = "Name";
            this.Nom.MinimumWidth = 6;
            this.Nom.Name = "Nom";
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "Prenom";
            this.FirstName.HeaderText = "FirstName";
            this.FirstName.MinimumWidth = 6;
            this.FirstName.Name = "FirstName";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(GlobalExpertise.models.Customer);
            // 
            // addBtn
            // 
            this.addBtn.Animated = true;
            this.addBtn.BackColor = System.Drawing.Color.Transparent;
            this.addBtn.BorderRadius = 6;
            this.addBtn.CheckedState.Parent = this.addBtn;
            this.addBtn.CustomImages.Parent = this.addBtn;
            this.addBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(80)))), ((int)(((byte)(157)))));
            this.addBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.addBtn.ForeColor = System.Drawing.Color.White;
            this.addBtn.HoverState.Parent = this.addBtn;
            this.addBtn.Location = new System.Drawing.Point(45, 19);
            this.addBtn.Name = "addBtn";
            this.addBtn.ShadowDecoration.Parent = this.addBtn;
            this.addBtn.Size = new System.Drawing.Size(132, 34);
            this.addBtn.TabIndex = 36;
            this.addBtn.Text = "Ajouter";
            this.addBtn.UseTransparentBackground = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Animated = true;
            this.searchTextBox.BorderRadius = 8;
            this.searchTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchTextBox.DefaultText = "";
            this.searchTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchTextBox.DisabledState.Parent = this.searchTextBox;
            this.searchTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchTextBox.FocusedState.Parent = this.searchTextBox;
            this.searchTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchTextBox.HoverState.Parent = this.searchTextBox;
            this.searchTextBox.IconLeft = global::GlobalExpertise.Properties.Resources.search_100px;
            this.searchTextBox.Location = new System.Drawing.Point(937, 10);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.PasswordChar = '\0';
            this.searchTextBox.PlaceholderText = "Search";
            this.searchTextBox.SelectedText = "";
            this.searchTextBox.ShadowDecoration.Parent = this.searchTextBox;
            this.searchTextBox.Size = new System.Drawing.Size(249, 36);
            this.searchTextBox.TabIndex = 32;
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.BackColor = System.Drawing.Color.Transparent;
            this.RefreshBtn.CheckedState.Parent = this.RefreshBtn;
            this.RefreshBtn.CustomImages.Parent = this.RefreshBtn;
            this.RefreshBtn.FillColor = System.Drawing.Color.Transparent;
            this.RefreshBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RefreshBtn.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.RefreshBtn.HoverState.Parent = this.RefreshBtn;
            this.RefreshBtn.Image = global::GlobalExpertise.Properties.Resources.refresh;
            this.RefreshBtn.Location = new System.Drawing.Point(425, 11);
            this.RefreshBtn.Margin = new System.Windows.Forms.Padding(4);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.RefreshBtn.ShadowDecoration.Parent = this.RefreshBtn;
            this.RefreshBtn.Size = new System.Drawing.Size(61, 51);
            this.RefreshBtn.TabIndex = 40;
            this.RefreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.Transparent;
            this.DeleteBtn.CheckedState.Parent = this.DeleteBtn;
            this.DeleteBtn.CustomImages.Parent = this.DeleteBtn;
            this.DeleteBtn.FillColor = System.Drawing.Color.Transparent;
            this.DeleteBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DeleteBtn.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.DeleteBtn.HoverState.Parent = this.DeleteBtn;
            this.DeleteBtn.Image = global::GlobalExpertise.Properties.Resources.supprimer_l_option_de_symbole;
            this.DeleteBtn.Location = new System.Drawing.Point(368, 10);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.DeleteBtn.ShadowDecoration.Parent = this.DeleteBtn;
            this.DeleteBtn.Size = new System.Drawing.Size(59, 52);
            this.DeleteBtn.TabIndex = 39;
            this.DeleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.Color.Transparent;
            this.SaveBtn.CheckedState.Parent = this.SaveBtn;
            this.SaveBtn.CustomImages.Parent = this.SaveBtn;
            this.SaveBtn.FillColor = System.Drawing.Color.Transparent;
            this.SaveBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SaveBtn.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.SaveBtn.HoverState.Parent = this.SaveBtn;
            this.SaveBtn.Image = global::GlobalExpertise.Properties.Resources.symbole_d_interface_de_sauvegarde_sur_disquette__2_;
            this.SaveBtn.Location = new System.Drawing.Point(294, 10);
            this.SaveBtn.Margin = new System.Windows.Forms.Padding(4);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.SaveBtn.ShadowDecoration.Parent = this.SaveBtn;
            this.SaveBtn.Size = new System.Drawing.Size(57, 51);
            this.SaveBtn.TabIndex = 38;
            this.SaveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.BackColor = System.Drawing.Color.Transparent;
            this.EditBtn.CheckedState.Parent = this.EditBtn;
            this.EditBtn.CustomImages.Parent = this.EditBtn;
            this.EditBtn.FillColor = System.Drawing.Color.Transparent;
            this.EditBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.EditBtn.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.EditBtn.HoverState.Parent = this.EditBtn;
            this.EditBtn.Image = global::GlobalExpertise.Properties.Resources.modifier_le_fichier1;
            this.EditBtn.Location = new System.Drawing.Point(222, 10);
            this.EditBtn.Margin = new System.Windows.Forms.Padding(4);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.EditBtn.ShadowDecoration.Parent = this.EditBtn;
            this.EditBtn.Size = new System.Drawing.Size(64, 52);
            this.EditBtn.TabIndex = 37;
            this.EditBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // CustomerCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1198, 707);
            this.Controls.Add(this.RefreshBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.customerDataGrid);
            this.Name = "CustomerCreation";
            this.Text = "CustomerCreation";
            this.Load += new System.EventHandler(this.CustomerCreation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView customerDataGrid;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private Guna.UI2.WinForms.Guna2Button addBtn;
        private Guna.UI2.WinForms.Guna2TextBox searchTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private Guna.UI2.WinForms.Guna2CircleButton RefreshBtn;
        private Guna.UI2.WinForms.Guna2CircleButton DeleteBtn;
        private Guna.UI2.WinForms.Guna2CircleButton SaveBtn;
        private Guna.UI2.WinForms.Guna2CircleButton EditBtn;
    }
}