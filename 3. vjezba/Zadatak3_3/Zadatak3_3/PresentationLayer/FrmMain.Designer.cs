namespace PresentationLayer
{
    partial class FrmMain
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
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.gbInsert = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblCompany = new System.Windows.Forms.Label();
            this.lblD = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.gbInsert.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Location = new System.Drawing.Point(12, 12);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.RowHeadersWidth = 62;
            this.dgvCustomers.RowTemplate.Height = 28;
            this.dgvCustomers.Size = new System.Drawing.Size(1006, 677);
            this.dgvCustomers.TabIndex = 0;
            // 
            // gbInsert
            // 
            this.gbInsert.Controls.Add(this.btnAdd);
            this.gbInsert.Controls.Add(this.txtCity);
            this.gbInsert.Controls.Add(this.txtCountry);
            this.gbInsert.Controls.Add(this.txtCompany);
            this.gbInsert.Controls.Add(this.txtID);
            this.gbInsert.Controls.Add(this.lblCity);
            this.gbInsert.Controls.Add(this.lblCountry);
            this.gbInsert.Controls.Add(this.lblCompany);
            this.gbInsert.Controls.Add(this.lblD);
            this.gbInsert.Location = new System.Drawing.Point(1039, 78);
            this.gbInsert.Name = "gbInsert";
            this.gbInsert.Size = new System.Drawing.Size(455, 317);
            this.gbInsert.TabIndex = 1;
            this.gbInsert.TabStop = false;
            this.gbInsert.Text = "New customer:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(252, 262);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(169, 38);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add customer";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(149, 211);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(272, 26);
            this.txtCity.TabIndex = 8;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(149, 160);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(272, 26);
            this.txtCountry.TabIndex = 7;
            // 
            // txtCompany
            // 
            this.txtCompany.Location = new System.Drawing.Point(149, 106);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(272, 26);
            this.txtCompany.TabIndex = 6;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(149, 54);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(148, 26);
            this.txtID.TabIndex = 5;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(19, 211);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(39, 20);
            this.lblCity.TabIndex = 4;
            this.lblCity.Text = "City:";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(19, 160);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(68, 20);
            this.lblCountry.TabIndex = 3;
            this.lblCountry.Text = "Country:";
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Location = new System.Drawing.Point(19, 106);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(124, 20);
            this.lblCompany.TabIndex = 2;
            this.lblCompany.Text = "Company name:";
            // 
            // lblD
            // 
            this.lblD.AutoSize = true;
            this.lblD.Location = new System.Drawing.Point(19, 57);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(99, 20);
            this.lblD.TabIndex = 0;
            this.lblD.Text = "CustomerID:";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1523, 701);
            this.Controls.Add(this.gbInsert);
            this.Controls.Add(this.dgvCustomers);
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.gbInsert.ResumeLayout(false);
            this.gbInsert.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.GroupBox gbInsert;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Label lblD;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.TextBox txtID;
    }
}

