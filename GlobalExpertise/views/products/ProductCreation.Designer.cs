
namespace GlobalExpertise.views
{
    partial class ProductCreation
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.labelError = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Produit = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.categoryLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.AddCategoryBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2ShadowPanel8 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.ProductDataGird = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categorie = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.guna2CircleButton16 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2CircleButton15 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.AddBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.categoryNameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.RefreshBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.DeleteBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.SaveBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.EditBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.guna2ShadowPanel1.SuspendLayout();
            this.guna2ShadowPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDataGird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Location = new System.Drawing.Point(49, 93);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(1073, 10);
            this.guna2Panel2.TabIndex = 47;
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.labelError);
            this.guna2ShadowPanel1.Controls.Add(this.Produit);
            this.guna2ShadowPanel1.Controls.Add(this.categoryLabel);
            this.guna2ShadowPanel1.Controls.Add(this.guna2Panel2);
            this.guna2ShadowPanel1.Controls.Add(this.categoryNameTextBox);
            this.guna2ShadowPanel1.Controls.Add(this.AddCategoryBtn);
            this.guna2ShadowPanel1.Controls.Add(this.guna2ShadowPanel8);
            this.guna2ShadowPanel1.Controls.Add(this.guna2CircleButton16);
            this.guna2ShadowPanel1.Controls.Add(this.guna2CircleButton15);
            this.guna2ShadowPanel1.Controls.Add(this.AddBtn);
            this.guna2ShadowPanel1.Controls.Add(this.RefreshBtn);
            this.guna2ShadowPanel1.Controls.Add(this.DeleteBtn);
            this.guna2ShadowPanel1.Controls.Add(this.SaveBtn);
            this.guna2ShadowPanel1.Controls.Add(this.EditBtn);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(28, 9);
            this.guna2ShadowPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.Radius = 5;
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Gray;
            this.guna2ShadowPanel1.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.Dropped;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(1148, 865);
            this.guna2ShadowPanel1.TabIndex = 48;
            this.guna2ShadowPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2ShadowPanel1_Paint);
            // 
            // labelError
            // 
            this.labelError.BackColor = System.Drawing.Color.Transparent;
            this.labelError.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(49, 75);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(3, 2);
            this.labelError.TabIndex = 50;
            this.labelError.Text = null;
            // 
            // Produit
            // 
            this.Produit.BackColor = System.Drawing.Color.Transparent;
            this.Produit.Location = new System.Drawing.Point(49, 132);
            this.Produit.Name = "Produit";
            this.Produit.Size = new System.Drawing.Size(45, 18);
            this.Produit.TabIndex = 49;
            this.Produit.Text = "Produit";
            // 
            // categoryLabel
            // 
            this.categoryLabel.BackColor = System.Drawing.Color.Transparent;
            this.categoryLabel.Location = new System.Drawing.Point(49, 39);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(62, 18);
            this.categoryLabel.TabIndex = 48;
            this.categoryLabel.Text = "Categorie";
            // 
            // AddCategoryBtn
            // 
            this.AddCategoryBtn.AutoRoundedCorners = true;
            this.AddCategoryBtn.BorderRadius = 20;
            this.AddCategoryBtn.CheckedState.Parent = this.AddCategoryBtn;
            this.AddCategoryBtn.CustomImages.Parent = this.AddCategoryBtn;
            this.AddCategoryBtn.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCategoryBtn.ForeColor = System.Drawing.Color.White;
            this.AddCategoryBtn.HoverState.Parent = this.AddCategoryBtn;
            this.AddCategoryBtn.Location = new System.Drawing.Point(467, 26);
            this.AddCategoryBtn.Margin = new System.Windows.Forms.Padding(4);
            this.AddCategoryBtn.Name = "AddCategoryBtn";
            this.AddCategoryBtn.ShadowDecoration.Parent = this.AddCategoryBtn;
            this.AddCategoryBtn.Size = new System.Drawing.Size(112, 42);
            this.AddCategoryBtn.TabIndex = 25;
            this.AddCategoryBtn.Text = "Ajouter";
            this.AddCategoryBtn.Click += new System.EventHandler(this.AddCategoryBtn_Click);
            // 
            // guna2ShadowPanel8
            // 
            this.guna2ShadowPanel8.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel8.Controls.Add(this.ProductDataGird);
            this.guna2ShadowPanel8.FillColor = System.Drawing.SystemColors.Control;
            this.guna2ShadowPanel8.Location = new System.Drawing.Point(58, 229);
            this.guna2ShadowPanel8.Margin = new System.Windows.Forms.Padding(4);
            this.guna2ShadowPanel8.Name = "guna2ShadowPanel8";
            this.guna2ShadowPanel8.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel8.Size = new System.Drawing.Size(1072, 597);
            this.guna2ShadowPanel8.TabIndex = 24;
            // 
            // ProductDataGird
            // 
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.ProductDataGird.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.ProductDataGird.AutoGenerateColumns = false;
            this.ProductDataGird.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProductDataGird.BackgroundColor = System.Drawing.Color.White;
            this.ProductDataGird.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductDataGird.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ProductDataGird.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductDataGird.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.ProductDataGird.ColumnHeadersHeight = 40;
            this.ProductDataGird.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductId,
            this.Price,
            this.codeDataGridViewTextBoxColumn,
            this.name,
            this.quantityDataGridViewTextBoxColumn,
            this.Categorie});
            this.ProductDataGird.DataSource = this.productBindingSource;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductDataGird.DefaultCellStyle = dataGridViewCellStyle15;
            this.ProductDataGird.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductDataGird.EnableHeadersVisualStyles = false;
            this.ProductDataGird.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.ProductDataGird.Location = new System.Drawing.Point(0, 0);
            this.ProductDataGird.Margin = new System.Windows.Forms.Padding(4);
            this.ProductDataGird.Name = "ProductDataGird";
            this.ProductDataGird.RowHeadersVisible = false;
            this.ProductDataGird.RowHeadersWidth = 51;
            this.ProductDataGird.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductDataGird.Size = new System.Drawing.Size(1072, 597);
            this.ProductDataGird.TabIndex = 0;
            this.ProductDataGird.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.ProductDataGird.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ProductDataGird.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ProductDataGird.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ProductDataGird.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ProductDataGird.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ProductDataGird.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ProductDataGird.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.ProductDataGird.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.ProductDataGird.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ProductDataGird.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.ProductDataGird.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Gray;
            this.ProductDataGird.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ProductDataGird.ThemeStyle.HeaderStyle.Height = 40;
            this.ProductDataGird.ThemeStyle.ReadOnly = false;
            this.ProductDataGird.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ProductDataGird.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ProductDataGird.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.ProductDataGird.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ProductDataGird.ThemeStyle.RowsStyle.Height = 22;
            this.ProductDataGird.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ProductDataGird.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // ProductId
            // 
            this.ProductId.DataPropertyName = "ProductId";
            this.ProductId.HeaderText = "ProductId";
            this.ProductId.MinimumWidth = 6;
            this.ProductId.Name = "ProductId";
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            // 
            // Categorie
            // 
            this.Categorie.DataPropertyName = "CategoryId";
            this.Categorie.DataSource = this.categoryBindingSource;
            this.Categorie.DisplayMember = "Name";
            this.Categorie.HeaderText = "Categorie";
            this.Categorie.MinimumWidth = 6;
            this.Categorie.Name = "Categorie";
            this.Categorie.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Categorie.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Categorie.ValueMember = "catregoryId";
            // 
            // guna2CircleButton16
            // 
            this.guna2CircleButton16.BackColor = System.Drawing.Color.Transparent;
            this.guna2CircleButton16.CheckedState.Parent = this.guna2CircleButton16;
            this.guna2CircleButton16.CustomImages.Parent = this.guna2CircleButton16;
            this.guna2CircleButton16.FillColor = System.Drawing.Color.Transparent;
            this.guna2CircleButton16.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton16.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.guna2CircleButton16.HoverState.FillColor = System.Drawing.Color.Gray;
            this.guna2CircleButton16.HoverState.Parent = this.guna2CircleButton16;
            this.guna2CircleButton16.Location = new System.Drawing.Point(357, 229);
            this.guna2CircleButton16.Margin = new System.Windows.Forms.Padding(4);
            this.guna2CircleButton16.Name = "guna2CircleButton16";
            this.guna2CircleButton16.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton16.ShadowDecoration.Parent = this.guna2CircleButton16;
            this.guna2CircleButton16.Size = new System.Drawing.Size(43, 39);
            this.guna2CircleButton16.TabIndex = 19;
            // 
            // guna2CircleButton15
            // 
            this.guna2CircleButton15.BackColor = System.Drawing.Color.Transparent;
            this.guna2CircleButton15.CheckedState.Parent = this.guna2CircleButton15;
            this.guna2CircleButton15.CustomImages.Parent = this.guna2CircleButton15;
            this.guna2CircleButton15.FillColor = System.Drawing.Color.Transparent;
            this.guna2CircleButton15.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton15.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.guna2CircleButton15.HoverState.FillColor = System.Drawing.Color.Gray;
            this.guna2CircleButton15.HoverState.Parent = this.guna2CircleButton15;
            this.guna2CircleButton15.Location = new System.Drawing.Point(103, 229);
            this.guna2CircleButton15.Margin = new System.Windows.Forms.Padding(4);
            this.guna2CircleButton15.Name = "guna2CircleButton15";
            this.guna2CircleButton15.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton15.ShadowDecoration.Parent = this.guna2CircleButton15;
            this.guna2CircleButton15.Size = new System.Drawing.Size(43, 39);
            this.guna2CircleButton15.TabIndex = 18;
            // 
            // AddBtn
            // 
            this.AddBtn.AutoRoundedCorners = true;
            this.AddBtn.BorderRadius = 20;
            this.AddBtn.CheckedState.Parent = this.AddBtn;
            this.AddBtn.CustomImages.Parent = this.AddBtn;
            this.AddBtn.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.ForeColor = System.Drawing.Color.White;
            this.AddBtn.HoverState.Parent = this.AddBtn;
            this.AddBtn.Location = new System.Drawing.Point(58, 161);
            this.AddBtn.Margin = new System.Windows.Forms.Padding(4);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.ShadowDecoration.Parent = this.AddBtn;
            this.AddBtn.Size = new System.Drawing.Size(187, 43);
            this.AddBtn.TabIndex = 11;
            this.AddBtn.Text = "Ajouter Nouveau Produit";
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // categoryNameTextBox
            // 
            this.categoryNameTextBox.Animated = true;
            this.categoryNameTextBox.BorderRadius = 8;
            this.categoryNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.categoryNameTextBox.DefaultText = "";
            this.categoryNameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.categoryNameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.categoryNameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.categoryNameTextBox.DisabledState.Parent = this.categoryNameTextBox;
            this.categoryNameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.categoryNameTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.categoryNameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.categoryNameTextBox.FocusedState.Parent = this.categoryNameTextBox;
            this.categoryNameTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.categoryNameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.categoryNameTextBox.HoverState.Parent = this.categoryNameTextBox;
            this.categoryNameTextBox.Location = new System.Drawing.Point(177, 25);
            this.categoryNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.categoryNameTextBox.Name = "categoryNameTextBox";
            this.categoryNameTextBox.PasswordChar = '\0';
            this.categoryNameTextBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.categoryNameTextBox.PlaceholderText = "Libelle Categorie";
            this.categoryNameTextBox.SelectedText = "";
            this.categoryNameTextBox.ShadowDecoration.Parent = this.categoryNameTextBox;
            this.categoryNameTextBox.Size = new System.Drawing.Size(265, 43);
            this.categoryNameTextBox.TabIndex = 26;
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
            this.RefreshBtn.Location = new System.Drawing.Point(467, 158);
            this.RefreshBtn.Margin = new System.Windows.Forms.Padding(4);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.RefreshBtn.ShadowDecoration.Parent = this.RefreshBtn;
            this.RefreshBtn.Size = new System.Drawing.Size(61, 51);
            this.RefreshBtn.TabIndex = 9;
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
            this.DeleteBtn.Location = new System.Drawing.Point(410, 157);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.DeleteBtn.ShadowDecoration.Parent = this.DeleteBtn;
            this.DeleteBtn.Size = new System.Drawing.Size(59, 52);
            this.DeleteBtn.TabIndex = 8;
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
            this.SaveBtn.Location = new System.Drawing.Point(336, 157);
            this.SaveBtn.Margin = new System.Windows.Forms.Padding(4);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.SaveBtn.ShadowDecoration.Parent = this.SaveBtn;
            this.SaveBtn.Size = new System.Drawing.Size(57, 51);
            this.SaveBtn.TabIndex = 7;
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
            this.EditBtn.Location = new System.Drawing.Point(264, 157);
            this.EditBtn.Margin = new System.Windows.Forms.Padding(4);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.EditBtn.ShadowDecoration.Parent = this.EditBtn;
            this.EditBtn.Size = new System.Drawing.Size(64, 52);
            this.EditBtn.TabIndex = 5;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "Code";
            this.codeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            // 
            // name
            // 
            this.name.DataPropertyName = "Name";
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataSource = typeof(GlobalExpertise.models.Category);
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(GlobalExpertise.models.Product);
            // 
            // ProductCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1222, 978);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Name = "ProductCreation";
            this.Text = "ProductCreation";
            this.Load += new System.EventHandler(this.ProductCreation_Load);
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            this.guna2ShadowPanel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProductDataGird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel8;
        private Guna.UI2.WinForms.Guna2DataGridView ProductDataGird;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton16;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton15;
        private Guna.UI2.WinForms.Guna2GradientButton AddBtn;
        private Guna.UI2.WinForms.Guna2CircleButton RefreshBtn;
        private Guna.UI2.WinForms.Guna2CircleButton DeleteBtn;
        private Guna.UI2.WinForms.Guna2CircleButton SaveBtn;
        private Guna.UI2.WinForms.Guna2CircleButton EditBtn;
        private Guna.UI2.WinForms.Guna2GradientButton AddCategoryBtn;
        private Guna.UI2.WinForms.Guna2TextBox categoryNameTextBox;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private System.Windows.Forms.BindingSource productBindingSource;
        private Guna.UI2.WinForms.Guna2HtmlLabel Produit;
        private Guna.UI2.WinForms.Guna2HtmlLabel categoryLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelError;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Categorie;
    }
}