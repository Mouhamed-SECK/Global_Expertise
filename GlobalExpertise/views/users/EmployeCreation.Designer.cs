
namespace GlobalExpertise.views
{
    partial class EmployeCreation
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
            this.addBtn = new Guna.UI2.WinForms.Guna2Button();
            this.employeeDataGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartementId = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.departementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.RefreshBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.DeleteBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.SaveBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.EditBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.addBtn.Location = new System.Drawing.Point(22, 19);
            this.addBtn.Name = "addBtn";
            this.addBtn.ShadowDecoration.Parent = this.addBtn;
            this.addBtn.Size = new System.Drawing.Size(132, 34);
            this.addBtn.TabIndex = 30;
            this.addBtn.Text = "Ajouter";
            this.addBtn.UseTransparentBackground = true;
            this.addBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // employeeDataGrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.employeeDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.employeeDataGrid.AutoGenerateColumns = false;
            this.employeeDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.employeeDataGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.employeeDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.employeeDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.employeeDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.employeeDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.employeeDataGrid.ColumnHeadersHeight = 50;
            this.employeeDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nameDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.DepartementId});
            this.employeeDataGrid.DataSource = this.employeeBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.employeeDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.employeeDataGrid.EnableHeadersVisualStyles = false;
            this.employeeDataGrid.GridColor = System.Drawing.Color.White;
            this.employeeDataGrid.Location = new System.Drawing.Point(22, 83);
            this.employeeDataGrid.Name = "employeeDataGrid";
            this.employeeDataGrid.RowHeadersVisible = false;
            this.employeeDataGrid.RowHeadersWidth = 51;
            this.employeeDataGrid.RowTemplate.Height = 24;
            this.employeeDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.employeeDataGrid.Size = new System.Drawing.Size(1127, 654);
            this.employeeDataGrid.TabIndex = 27;
            this.employeeDataGrid.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.employeeDataGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.employeeDataGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.employeeDataGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.employeeDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.employeeDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.employeeDataGrid.ThemeStyle.BackColor = System.Drawing.SystemColors.Window;
            this.employeeDataGrid.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.employeeDataGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.employeeDataGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.employeeDataGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeDataGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.employeeDataGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.employeeDataGrid.ThemeStyle.HeaderStyle.Height = 50;
            this.employeeDataGrid.ThemeStyle.ReadOnly = false;
            this.employeeDataGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.employeeDataGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.employeeDataGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeDataGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.employeeDataGrid.ThemeStyle.RowsStyle.Height = 24;
            this.employeeDataGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.employeeDataGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // id
            // 
            this.id.DataPropertyName = "Id";
            this.id.HeaderText = "Id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // DepartementId
            // 
            this.DepartementId.DataPropertyName = "DepartementId";
            this.DepartementId.DataSource = this.departementBindingSource;
            this.DepartementId.DisplayMember = "Name";
            this.DepartementId.HeaderText = "Departement";
            this.DepartementId.MinimumWidth = 6;
            this.DepartementId.Name = "DepartementId";
            this.DepartementId.ValueMember = "departementId";
            // 
            // departementBindingSource
            // 
            this.departementBindingSource.DataSource = typeof(GlobalExpertise.models.Departement);
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataSource = typeof(GlobalExpertise.models.Employee);
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
            this.searchTextBox.Location = new System.Drawing.Point(900, 19);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.PasswordChar = '\0';
            this.searchTextBox.PlaceholderText = "Search";
            this.searchTextBox.SelectedText = "";
            this.searchTextBox.ShadowDecoration.Parent = this.searchTextBox;
            this.searchTextBox.Size = new System.Drawing.Size(249, 36);
            this.searchTextBox.TabIndex = 25;
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
            this.RefreshBtn.Location = new System.Drawing.Point(398, 14);
            this.RefreshBtn.Margin = new System.Windows.Forms.Padding(4);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.RefreshBtn.ShadowDecoration.Parent = this.RefreshBtn;
            this.RefreshBtn.Size = new System.Drawing.Size(61, 51);
            this.RefreshBtn.TabIndex = 44;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
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
            this.DeleteBtn.Location = new System.Drawing.Point(341, 13);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.DeleteBtn.ShadowDecoration.Parent = this.DeleteBtn;
            this.DeleteBtn.Size = new System.Drawing.Size(59, 52);
            this.DeleteBtn.TabIndex = 43;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
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
            this.SaveBtn.Location = new System.Drawing.Point(267, 13);
            this.SaveBtn.Margin = new System.Windows.Forms.Padding(4);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.SaveBtn.ShadowDecoration.Parent = this.SaveBtn;
            this.SaveBtn.Size = new System.Drawing.Size(57, 51);
            this.SaveBtn.TabIndex = 42;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
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
            this.EditBtn.Location = new System.Drawing.Point(195, 13);
            this.EditBtn.Margin = new System.Windows.Forms.Padding(4);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.EditBtn.ShadowDecoration.Parent = this.EditBtn;
            this.EditBtn.Size = new System.Drawing.Size(64, 52);
            this.EditBtn.TabIndex = 41;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // EmployeCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1172, 749);
            this.Controls.Add(this.RefreshBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.employeeDataGrid);
            this.Controls.Add(this.searchTextBox);
            this.Name = "EmployeCreation";
            this.Text = "EmployeCreation";
            this.Load += new System.EventHandler(this.EmployeCreation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button addBtn;
        private Guna.UI2.WinForms.Guna2DataGridView employeeDataGrid;
        private Guna.UI2.WinForms.Guna2TextBox searchTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn DepartementId;
        private System.Windows.Forms.BindingSource departementBindingSource;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private Guna.UI2.WinForms.Guna2CircleButton RefreshBtn;
        private Guna.UI2.WinForms.Guna2CircleButton DeleteBtn;
        private Guna.UI2.WinForms.Guna2CircleButton SaveBtn;
        private Guna.UI2.WinForms.Guna2CircleButton EditBtn;
    }
}