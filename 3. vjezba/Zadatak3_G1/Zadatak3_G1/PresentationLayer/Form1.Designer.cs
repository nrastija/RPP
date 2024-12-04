namespace PresentationLayer
{
    partial class Form1
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
            dgvProducts = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            txtPriceFrom = new TextBox();
            txtPriceTo = new TextBox();
            btnApply = new Button();
            bntClear = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // dgvProducts
            // 
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(12, 80);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersWidth = 62;
            dgvProducts.Size = new Size(1075, 578);
            dgvProducts.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 29);
            label1.Name = "label1";
            label1.Size = new Size(97, 25);
            label1.TabIndex = 1;
            label1.Text = "Price from:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(356, 29);
            label2.Name = "label2";
            label2.Size = new Size(75, 25);
            label2.TabIndex = 2;
            label2.Text = "Price to:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtPriceFrom
            // 
            txtPriceFrom.Location = new Point(157, 26);
            txtPriceFrom.Name = "txtPriceFrom";
            txtPriceFrom.Size = new Size(174, 31);
            txtPriceFrom.TabIndex = 3;
            // 
            // txtPriceTo
            // 
            txtPriceTo.Location = new Point(437, 26);
            txtPriceTo.Name = "txtPriceTo";
            txtPriceTo.Size = new Size(174, 31);
            txtPriceTo.TabIndex = 4;
            // 
            // btnApply
            // 
            btnApply.Location = new Point(647, 18);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(132, 46);
            btnApply.TabIndex = 5;
            btnApply.Text = "Apply";
            btnApply.UseVisualStyleBackColor = true;
            // 
            // bntClear
            // 
            bntClear.Location = new Point(801, 18);
            bntClear.Name = "bntClear";
            bntClear.Size = new Size(132, 46);
            bntClear.TabIndex = 6;
            bntClear.Text = "Clear";
            bntClear.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1099, 685);
            Controls.Add(bntClear);
            Controls.Add(btnApply);
            Controls.Add(txtPriceTo);
            Controls.Add(txtPriceFrom);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvProducts);
            Name = "Form1";
            Text = "Products";
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProducts;
        private Label label1;
        private Label label2;
        private TextBox txtPriceFrom;
        private TextBox txtPriceTo;
        private Button btnApply;
        private Button bntClear;
    }
}
