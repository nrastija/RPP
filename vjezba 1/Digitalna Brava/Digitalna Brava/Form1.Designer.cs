namespace Digitalna_Brava
{
    partial class frmMain
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
            lblKartica = new Label();
            lblPIN = new Label();
            btnVrata501 = new Button();
            btnVrata502 = new Button();
            btnVrata503 = new Button();
            txtKartica = new TextBox();
            txtPIN = new TextBox();
            SuspendLayout();
            // 
            // lblKartica
            // 
            lblKartica.AutoSize = true;
            lblKartica.Location = new Point(59, 66);
            lblKartica.Name = "lblKartica";
            lblKartica.Size = new Size(103, 25);
            lblKartica.TabIndex = 0;
            lblKartica.Text = "Broj kartice:";
            // 
            // lblPIN
            // 
            lblPIN.AutoSize = true;
            lblPIN.Location = new Point(59, 121);
            lblPIN.Name = "lblPIN";
            lblPIN.Size = new Size(44, 25);
            lblPIN.TabIndex = 1;
            lblPIN.Text = "PIN:";
            // 
            // btnVrata501
            // 
            btnVrata501.BackColor = SystemColors.ActiveBorder;
            btnVrata501.Location = new Point(59, 184);
            btnVrata501.Name = "btnVrata501";
            btnVrata501.Size = new Size(139, 80);
            btnVrata501.TabIndex = 2;
            btnVrata501.Text = "Otvori Vrata br. 501";
            btnVrata501.UseVisualStyleBackColor = false;
            btnVrata501.Click += btnVrata501_Click;
            // 
            // btnVrata502
            // 
            btnVrata502.BackColor = SystemColors.ActiveBorder;
            btnVrata502.Location = new Point(215, 184);
            btnVrata502.Name = "btnVrata502";
            btnVrata502.Size = new Size(139, 80);
            btnVrata502.TabIndex = 3;
            btnVrata502.Text = "Otvori Vrata br. 502";
            btnVrata502.UseVisualStyleBackColor = false;
            btnVrata502.Click += btnVrata502_Click;
            // 
            // btnVrata503
            // 
            btnVrata503.BackColor = SystemColors.ActiveBorder;
            btnVrata503.Location = new Point(370, 184);
            btnVrata503.Name = "btnVrata503";
            btnVrata503.Size = new Size(139, 80);
            btnVrata503.TabIndex = 4;
            btnVrata503.Text = "Otvori Vrata br. 503";
            btnVrata503.UseVisualStyleBackColor = false;
            btnVrata503.Click += btnVrata503_Click;
            // 
            // txtKartica
            // 
            txtKartica.BorderStyle = BorderStyle.FixedSingle;
            txtKartica.Location = new Point(215, 60);
            txtKartica.Name = "txtKartica";
            txtKartica.Size = new Size(294, 31);
            txtKartica.TabIndex = 5;
            // 
            // txtPIN
            // 
            txtPIN.BorderStyle = BorderStyle.FixedSingle;
            txtPIN.Location = new Point(215, 115);
            txtPIN.Name = "txtPIN";
            txtPIN.Size = new Size(294, 31);
            txtPIN.TabIndex = 6;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(545, 304);
            Controls.Add(txtPIN);
            Controls.Add(txtKartica);
            Controls.Add(btnVrata503);
            Controls.Add(btnVrata502);
            Controls.Add(btnVrata501);
            Controls.Add(lblPIN);
            Controls.Add(lblKartica);
            Name = "frmMain";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Otvaranje vrata";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblKartica;
        private Label lblPIN;
        private Button btnVrata501;
        private Button btnVrata502;
        private Button btnVrata503;
        private TextBox txtKartica;
        private TextBox txtPIN;
    }
}
