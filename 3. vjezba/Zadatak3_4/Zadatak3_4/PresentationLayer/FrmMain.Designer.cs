namespace PresentationLayer
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvCustomers = new DataGridView();
            groupBox1 = new GroupBox();
            btnAdd = new Button();
            txtCity = new TextBox();
            lblCity = new Label();
            txtCountry = new TextBox();
            lblCountry = new Label();
            txtCompany = new TextBox();
            lblCompany = new Label();
            txtID = new TextBox();
            lblID = new Label();
            btnRemove = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvCustomers
            // 
            dgvCustomers.BackgroundColor = SystemColors.AppWorkspace;
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomers.GridColor = SystemColors.InactiveCaptionText;
            dgvCustomers.Location = new Point(12, 12);
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.RowHeadersWidth = 62;
            dgvCustomers.Size = new Size(1382, 585);
            dgvCustomers.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(txtCity);
            groupBox1.Controls.Add(lblCity);
            groupBox1.Controls.Add(txtCountry);
            groupBox1.Controls.Add(lblCountry);
            groupBox1.Controls.Add(txtCompany);
            groupBox1.Controls.Add(lblCompany);
            groupBox1.Controls.Add(txtID);
            groupBox1.Controls.Add(lblID);
            groupBox1.Location = new Point(12, 603);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1199, 135);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "New customer:";
            // 
            // btnAdd
            // 
            btnAdd.ForeColor = SystemColors.ActiveCaptionText;
            btnAdd.Location = new Point(1021, 69);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(161, 31);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add customer";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(772, 69);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(224, 31);
            txtCity.TabIndex = 7;
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.ForeColor = SystemColors.ActiveCaptionText;
            lblCity.Location = new Point(772, 41);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(46, 25);
            lblCity.TabIndex = 6;
            lblCity.Text = "City:";
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(526, 69);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(224, 31);
            txtCountry.TabIndex = 5;
            // 
            // lblCountry
            // 
            lblCountry.AutoSize = true;
            lblCountry.ForeColor = SystemColors.ActiveCaptionText;
            lblCountry.Location = new Point(526, 41);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(79, 25);
            lblCountry.TabIndex = 4;
            lblCountry.Text = "Country:";
            // 
            // txtCompany
            // 
            txtCompany.Location = new Point(280, 69);
            txtCompany.Name = "txtCompany";
            txtCompany.Size = new Size(224, 31);
            txtCompany.TabIndex = 3;
            // 
            // lblCompany
            // 
            lblCompany.AutoSize = true;
            lblCompany.ForeColor = SystemColors.ActiveCaptionText;
            lblCompany.Location = new Point(280, 41);
            lblCompany.Name = "lblCompany";
            lblCompany.Size = new Size(142, 25);
            lblCompany.TabIndex = 2;
            lblCompany.Text = "Company name:";
            // 
            // txtID
            // 
            txtID.Location = new Point(32, 69);
            txtID.Name = "txtID";
            txtID.Size = new Size(224, 31);
            txtID.TabIndex = 1;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.ForeColor = SystemColors.ActiveCaptionText;
            lblID.Location = new Point(32, 41);
            lblID.Name = "lblID";
            lblID.Size = new Size(111, 25);
            lblID.TabIndex = 0;
            lblID.Text = "CustomerID:";
            // 
            // btnRemove
            // 
            btnRemove.ForeColor = SystemColors.ActiveCaptionText;
            btnRemove.Location = new Point(1237, 651);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(157, 73);
            btnRemove.TabIndex = 9;
            btnRemove.Text = "Remove customer";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1416, 750);
            Controls.Add(btnRemove);
            Controls.Add(groupBox1);
            Controls.Add(dgvCustomers);
            ForeColor = SystemColors.ControlLight;
            Name = "FrmMain";
            Text = "Customers";
            Load += FrmMain_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvCustomers;
        private GroupBox groupBox1;
        private Label lblID;
        private TextBox txtID;
        private TextBox txtCity;
        private Label lblCity;
        private TextBox txtCountry;
        private Label lblCountry;
        private TextBox txtCompany;
        private Label lblCompany;
        private Button btnAdd;
        private Button btnRemove;
    }
}
