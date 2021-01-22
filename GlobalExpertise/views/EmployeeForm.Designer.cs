
namespace GlobalExpertise.views
{
    partial class EmployeeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeForm));
            this.addPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.departementComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.bindingSourceEmployee = new System.Windows.Forms.BindingSource(this.components);
            this.nameText = new Guna.UI2.WinForms.Guna2TextBox();
            this.firstNameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.emailTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.saveBtn = new Guna.UI2.WinForms.Guna2Button();
            this.addPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // addPanel
            // 
            this.addPanel.Controls.Add(this.guna2CirclePictureBox1);
            this.addPanel.Controls.Add(this.departementComboBox);
            this.addPanel.Controls.Add(this.nameText);
            this.addPanel.Controls.Add(this.firstNameTextBox);
            this.addPanel.Controls.Add(this.emailTextBox);
            this.addPanel.Location = new System.Drawing.Point(74, 12);
            this.addPanel.Name = "addPanel";
            this.addPanel.ShadowDecoration.Parent = this.addPanel;
            this.addPanel.Size = new System.Drawing.Size(477, 534);
            this.addPanel.TabIndex = 23;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(153, 34);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.ShadowDecoration.Parent = this.guna2CirclePictureBox1;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(176, 144);
            this.guna2CirclePictureBox1.TabIndex = 17;
            this.guna2CirclePictureBox1.TabStop = false;
            this.guna2CirclePictureBox1.Click += new System.EventHandler(this.guna2CirclePictureBox1_Click);
            // 
            // departementComboBox
            // 
            this.departementComboBox.BackColor = System.Drawing.Color.Transparent;
            this.departementComboBox.BorderRadius = 8;
            this.departementComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bindingSourceEmployee, "DepartementId", true));
            this.departementComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.departementComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.departementComboBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.departementComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.departementComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.departementComboBox.FocusedState.Parent = this.departementComboBox;
            this.departementComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.departementComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.departementComboBox.HoverState.Parent = this.departementComboBox;
            this.departementComboBox.ItemHeight = 30;
            this.departementComboBox.ItemsAppearance.Parent = this.departementComboBox;
            this.departementComboBox.Location = new System.Drawing.Point(65, 472);
            this.departementComboBox.Name = "departementComboBox";
            this.departementComboBox.ShadowDecoration.Parent = this.departementComboBox;
            this.departementComboBox.Size = new System.Drawing.Size(350, 36);
            this.departementComboBox.TabIndex = 21;
            this.departementComboBox.ValueMember = "departementId";
            // 
            // bindingSourceEmployee
            // 
            this.bindingSourceEmployee.DataSource = typeof(GlobalExpertise.models.Employee);
            // 
            // nameText
            // 
            this.nameText.Animated = true;
            this.nameText.BorderRadius = 8;
            this.nameText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameText.DataBindings.Add(new System.Windows.Forms.Binding("DefaultText", this.bindingSourceEmployee, "Name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
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
            this.nameText.IconLeft = ((System.Drawing.Image)(resources.GetObject("nameText.IconLeft")));
            this.nameText.Location = new System.Drawing.Point(60, 249);
            this.nameText.Margin = new System.Windows.Forms.Padding(4);
            this.nameText.Name = "nameText";
            this.nameText.PasswordChar = '\0';
            this.nameText.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.nameText.PlaceholderText = "Nom";
            this.nameText.SelectedText = "";
            this.nameText.ShadowDecoration.Parent = this.nameText;
            this.nameText.Size = new System.Drawing.Size(355, 44);
            this.nameText.TabIndex = 10;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Animated = true;
            this.firstNameTextBox.BorderRadius = 8;
            this.firstNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("DefaultText", this.bindingSourceEmployee, "FirstName", true));
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
            this.firstNameTextBox.IconLeft = ((System.Drawing.Image)(resources.GetObject("firstNameTextBox.IconLeft")));
            this.firstNameTextBox.Location = new System.Drawing.Point(60, 320);
            this.firstNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.PasswordChar = '\0';
            this.firstNameTextBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.firstNameTextBox.PlaceholderText = "Prenom";
            this.firstNameTextBox.SelectedText = "";
            this.firstNameTextBox.ShadowDecoration.Parent = this.firstNameTextBox;
            this.firstNameTextBox.Size = new System.Drawing.Size(355, 44);
            this.firstNameTextBox.TabIndex = 11;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Animated = true;
            this.emailTextBox.BorderRadius = 8;
            this.emailTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("DefaultText", this.bindingSourceEmployee, "Email", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
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
            this.emailTextBox.IconLeft = ((System.Drawing.Image)(resources.GetObject("emailTextBox.IconLeft")));
            this.emailTextBox.Location = new System.Drawing.Point(60, 395);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.PasswordChar = '\0';
            this.emailTextBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.emailTextBox.PlaceholderText = "Email";
            this.emailTextBox.SelectedText = "";
            this.emailTextBox.ShadowDecoration.Parent = this.emailTextBox;
            this.emailTextBox.Size = new System.Drawing.Size(355, 44);
            this.emailTextBox.TabIndex = 12;
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
            this.saveBtn.Location = new System.Drawing.Point(399, 562);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.ShadowDecoration.Parent = this.saveBtn;
            this.saveBtn.Size = new System.Drawing.Size(152, 36);
            this.saveBtn.TabIndex = 9;
            this.saveBtn.Text = "Sauvegarder";
            this.saveBtn.UseTransparentBackground = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 627);
            this.Controls.Add(this.addPanel);
            this.Controls.Add(this.saveBtn);
            this.Name = "EmployeeForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            this.addPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEmployee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel addPanel;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2ComboBox departementComboBox;
        private Guna.UI2.WinForms.Guna2Button saveBtn;
        private Guna.UI2.WinForms.Guna2TextBox nameText;
        private Guna.UI2.WinForms.Guna2TextBox firstNameTextBox;
        private Guna.UI2.WinForms.Guna2TextBox emailTextBox;
        private System.Windows.Forms.BindingSource bindingSourceEmployee;
    }
}