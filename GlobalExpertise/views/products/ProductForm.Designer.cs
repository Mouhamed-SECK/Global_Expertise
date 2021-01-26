
namespace GlobalExpertise.views
{
    partial class ProductForm
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
            this.productComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saveBtn = new Guna.UI2.WinForms.Guna2Button();
            this.ChooseBtn = new Guna.UI2.WinForms.Guna2Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.nameText = new Guna.UI2.WinForms.Guna2TextBox();
            this.firstNameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.emailTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // productComboBox
            // 
            this.productComboBox.BackColor = System.Drawing.Color.Transparent;
            this.productComboBox.BorderRadius = 8;
            this.productComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productBindingSource, "CategoryId", true));
            this.productComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.productComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productComboBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.productComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.productComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.productComboBox.FocusedState.Parent = this.productComboBox;
            this.productComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.productComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.productComboBox.HoverState.Parent = this.productComboBox;
            this.productComboBox.ItemHeight = 30;
            this.productComboBox.ItemsAppearance.Parent = this.productComboBox;
            this.productComboBox.Location = new System.Drawing.Point(109, 443);
            this.productComboBox.Name = "productComboBox";
            this.productComboBox.ShadowDecoration.Parent = this.productComboBox;
            this.productComboBox.Size = new System.Drawing.Size(355, 36);
            this.productComboBox.TabIndex = 30;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(GlobalExpertise.models.Product);
            // 
            // saveBtn
            // 
            this.saveBtn.Animated = true;
            this.saveBtn.BackColor = System.Drawing.Color.Transparent;
            this.saveBtn.BorderRadius = 6;
            this.saveBtn.CheckedState.Parent = this.saveBtn;
            this.saveBtn.CustomImages.Parent = this.saveBtn;
            this.saveBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(80)))), ((int)(((byte)(157)))));
            this.saveBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.HoverState.Parent = this.saveBtn;
            this.saveBtn.Location = new System.Drawing.Point(312, 498);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.ShadowDecoration.Parent = this.saveBtn;
            this.saveBtn.Size = new System.Drawing.Size(152, 36);
            this.saveBtn.TabIndex = 26;
            this.saveBtn.Text = "Sauvegarder";
            this.saveBtn.UseTransparentBackground = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // ChooseBtn
            // 
            this.ChooseBtn.Animated = true;
            this.ChooseBtn.BackColor = System.Drawing.Color.Transparent;
            this.ChooseBtn.BorderRadius = 6;
            this.ChooseBtn.CheckedState.Parent = this.ChooseBtn;
            this.ChooseBtn.CustomImages.Parent = this.ChooseBtn;
            this.ChooseBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(80)))), ((int)(((byte)(157)))));
            this.ChooseBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ChooseBtn.ForeColor = System.Drawing.Color.White;
            this.ChooseBtn.HoverState.Parent = this.ChooseBtn;
            this.ChooseBtn.Location = new System.Drawing.Point(202, 183);
            this.ChooseBtn.Name = "ChooseBtn";
            this.ChooseBtn.ShadowDecoration.Parent = this.ChooseBtn;
            this.ChooseBtn.Size = new System.Drawing.Size(188, 36);
            this.ChooseBtn.TabIndex = 32;
            this.ChooseBtn.Text = "Chosir une image";
            this.ChooseBtn.UseTransparentBackground = true;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.DataSource = this.productBindingSource;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(190, 12);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.ShadowDecoration.Parent = this.guna2CirclePictureBox1;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(183, 143);
            this.guna2CirclePictureBox1.TabIndex = 31;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // nameText
            // 
            this.nameText.Animated = true;
            this.nameText.BorderRadius = 8;
            this.nameText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameText.DataBindings.Add(new System.Windows.Forms.Binding("DefaultText", this.productBindingSource, "Name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.nameText.DefaultText = "";
            this.nameText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nameText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nameText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nameText.DisabledState.Parent = this.nameText;
            this.nameText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nameText.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.nameText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nameText.FocusedState.Parent = this.nameText;
            this.nameText.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nameText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nameText.HoverState.Parent = this.nameText;
            this.nameText.Location = new System.Drawing.Point(109, 243);
            this.nameText.Margin = new System.Windows.Forms.Padding(4);
            this.nameText.Name = "nameText";
            this.nameText.PasswordChar = '\0';
            this.nameText.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.nameText.PlaceholderText = "Libelle";
            this.nameText.SelectedText = "";
            this.nameText.ShadowDecoration.Parent = this.nameText;
            this.nameText.Size = new System.Drawing.Size(355, 44);
            this.nameText.TabIndex = 27;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Animated = true;
            this.firstNameTextBox.BorderRadius = 8;
            this.firstNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("DefaultText", this.productBindingSource, "Price", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "C2"));
            this.firstNameTextBox.DefaultText = "";
            this.firstNameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.firstNameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.firstNameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.firstNameTextBox.DisabledState.Parent = this.firstNameTextBox;
            this.firstNameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.firstNameTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.firstNameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.firstNameTextBox.FocusedState.Parent = this.firstNameTextBox;
            this.firstNameTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.firstNameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.firstNameTextBox.HoverState.Parent = this.firstNameTextBox;
            this.firstNameTextBox.Location = new System.Drawing.Point(109, 307);
            this.firstNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.PasswordChar = '\0';
            this.firstNameTextBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.firstNameTextBox.PlaceholderText = "Prix";
            this.firstNameTextBox.SelectedText = "";
            this.firstNameTextBox.ShadowDecoration.Parent = this.firstNameTextBox;
            this.firstNameTextBox.Size = new System.Drawing.Size(355, 44);
            this.firstNameTextBox.TabIndex = 28;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Animated = true;
            this.emailTextBox.BorderRadius = 8;
            this.emailTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("DefaultText", this.productBindingSource, "Quantity", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N2"));
            this.emailTextBox.DefaultText = "";
            this.emailTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.emailTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.emailTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailTextBox.DisabledState.Parent = this.emailTextBox;
            this.emailTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.emailTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailTextBox.FocusedState.Parent = this.emailTextBox;
            this.emailTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.emailTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailTextBox.HoverState.Parent = this.emailTextBox;
            this.emailTextBox.Location = new System.Drawing.Point(109, 379);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.PasswordChar = '\0';
            this.emailTextBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.emailTextBox.PlaceholderText = "Quantité";
            this.emailTextBox.SelectedText = "";
            this.emailTextBox.ShadowDecoration.Parent = this.emailTextBox;
            this.emailTextBox.Size = new System.Drawing.Size(355, 44);
            this.emailTextBox.TabIndex = 29;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(564, 564);
            this.Controls.Add(this.ChooseBtn);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Controls.Add(this.productComboBox);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.saveBtn);
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox productComboBox;
        private Guna.UI2.WinForms.Guna2TextBox nameText;
        private Guna.UI2.WinForms.Guna2TextBox firstNameTextBox;
        private Guna.UI2.WinForms.Guna2TextBox emailTextBox;
        private Guna.UI2.WinForms.Guna2Button saveBtn;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2Button ChooseBtn;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}