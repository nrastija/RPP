namespace Digitalna_Brava
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
            lblBrKartice = new Label();
            lblPin = new Label();
            txtBrKartice = new TextBox();
            txtPin = new TextBox();
            btnVrata501 = new Button();
            btnVrata502 = new Button();
            btnVrata503 = new Button();
            SuspendLayout();
            // 
            // lblBrKartice
            // 
            lblBrKartice.AutoSize = true;
            lblBrKartice.Location = new Point(41, 36);
            lblBrKartice.Name = "lblBrKartice";
            lblBrKartice.Size = new Size(103, 25);
            lblBrKartice.TabIndex = 0;
            lblBrKartice.Text = "Broj kartice:";
            // 
            // lblPin
            // 
            lblPin.AutoSize = true;
            lblPin.Location = new Point(41, 95);
            lblPin.Name = "lblPin";
            lblPin.Size = new Size(44, 25);
            lblPin.TabIndex = 1;
            lblPin.Text = "PIN:";
            // 
            // txtBrKartice
            // 
            txtBrKartice.Location = new Point(150, 33);
            txtBrKartice.Name = "txtBrKartice";
            txtBrKartice.Size = new Size(304, 31);
            txtBrKartice.TabIndex = 2;
            // 
            // txtPin
            // 
            txtPin.Location = new Point(150, 89);
            txtPin.Name = "txtPin";
            txtPin.Size = new Size(304, 31);
            txtPin.TabIndex = 3;
            // 
            // btnVrata501
            // 
            btnVrata501.Location = new Point(41, 176);
            btnVrata501.Name = "btnVrata501";
            btnVrata501.Size = new Size(124, 67);
            btnVrata501.TabIndex = 4;
            btnVrata501.Text = "Otvori vrata br. 501";
            btnVrata501.UseVisualStyleBackColor = true;
            btnVrata501.Click += btnVrata501_Click;
            // 
            // btnVrata502
            // 
            btnVrata502.Location = new Point(184, 176);
            btnVrata502.Name = "btnVrata502";
            btnVrata502.Size = new Size(124, 67);
            btnVrata502.TabIndex = 5;
            btnVrata502.Text = "Otvori vrata br. 502";
            btnVrata502.UseVisualStyleBackColor = true;
            btnVrata502.Click += btnVrata502_Click;
            // 
            // btnVrata503
            // 
            btnVrata503.Location = new Point(330, 176);
            btnVrata503.Name = "btnVrata503";
            btnVrata503.Size = new Size(124, 67);
            btnVrata503.TabIndex = 6;
            btnVrata503.Text = "Otvori vrata br. 503";
            btnVrata503.UseVisualStyleBackColor = true;
            btnVrata503.Click += btnVrata503_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(488, 290);
            Controls.Add(btnVrata503);
            Controls.Add(btnVrata502);
            Controls.Add(btnVrata501);
            Controls.Add(txtPin);
            Controls.Add(txtBrKartice);
            Controls.Add(lblPin);
            Controls.Add(lblBrKartice);
            Name = "FrmMain";
            Text = "Otvaranje vrata";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBrKartice;
        private Label lblPin;
        private TextBox txtBrKartice;
        private TextBox txtPin;
        private Button btnVrata501;
        private Button btnVrata502;
        private Button btnVrata503;
    }
}
