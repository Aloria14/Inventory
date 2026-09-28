namespace Inventory
{
    partial class frmAddProduct
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
            label1 = new Label();
            gridViewProductList = new DataGridView();
            cbCategory = new ComboBox();
            txtSellPrice = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            dtPickerMfgDate = new DateTimePicker();
            dtPickerExpDate = new DateTimePicker();
            txtQuantity = new TextBox();
            txtProductName = new TextBox();
            richTextBox2 = new RichTextBox();
            btnAddProduct = new Button();
            ((System.ComponentModel.ISupportInitialize)gridViewProductList).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 33);
            label1.Name = "label1";
            label1.Size = new Size(126, 25);
            label1.TabIndex = 0;
            label1.Text = "Add Product";
            // 
            // gridViewProductList
            // 
            gridViewProductList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridViewProductList.Location = new Point(12, 243);
            gridViewProductList.Name = "gridViewProductList";
            gridViewProductList.Size = new Size(607, 150);
            gridViewProductList.TabIndex = 4;
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(87, 98);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(232, 23);
            cbCategory.TabIndex = 5;
            // 
            // txtSellPrice
            // 
            txtSellPrice.Location = new Point(87, 214);
            txtSellPrice.Name = "txtSellPrice";
            txtSellPrice.Size = new Size(232, 23);
            txtSellPrice.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 72);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 0;
            label2.Text = "Product";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 101);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 0;
            label3.Text = "Category";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 133);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 0;
            label4.Text = "Mfg. Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 162);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 0;
            label5.Text = "Exp. Date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 188);
            label6.Name = "label6";
            label6.Size = new Size(53, 15);
            label6.TabIndex = 0;
            label6.Text = "Quantity";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(19, 217);
            label7.Name = "label7";
            label7.Size = new Size(54, 15);
            label7.TabIndex = 0;
            label7.Text = "Sell Price";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(351, 67);
            label8.Name = "label8";
            label8.Size = new Size(67, 15);
            label8.TabIndex = 0;
            label8.Text = "Description";
            // 
            // dtPickerMfgDate
            // 
            dtPickerMfgDate.Location = new Point(87, 127);
            dtPickerMfgDate.Name = "dtPickerMfgDate";
            dtPickerMfgDate.Size = new Size(232, 23);
            dtPickerMfgDate.TabIndex = 6;
            // 
            // dtPickerExpDate
            // 
            dtPickerExpDate.Location = new Point(87, 156);
            dtPickerExpDate.Name = "dtPickerExpDate";
            dtPickerExpDate.Size = new Size(232, 23);
            dtPickerExpDate.TabIndex = 6;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(87, 185);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(232, 23);
            txtQuantity.TabIndex = 3;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(87, 69);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(232, 23);
            txtProductName.TabIndex = 3;
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(351, 85);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(268, 123);
            richTextBox2.TabIndex = 7;
            richTextBox2.Text = "";
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(525, 213);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(94, 23);
            btnAddProduct.TabIndex = 8;
            btnAddProduct.Text = "Add Product";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // frmAddProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(637, 405);
            Controls.Add(btnAddProduct);
            Controls.Add(richTextBox2);
            Controls.Add(dtPickerExpDate);
            Controls.Add(dtPickerMfgDate);
            Controls.Add(cbCategory);
            Controls.Add(gridViewProductList);
            Controls.Add(txtProductName);
            Controls.Add(txtQuantity);
            Controls.Add(txtSellPrice);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label8);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmAddProduct";
            Text = "Inventory";
            Load += frmAddProduct_Load;
            ((System.ComponentModel.ISupportInitialize)gridViewProductList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView gridViewProductList;
        private ComboBox cbCategory;
        private TextBox txtSellPrice;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private DateTimePicker dtPickerMfgDate;
        private DateTimePicker dtPickerExpDate;
        private TextBox txtQuantity;
        private TextBox txtProductName;
        private RichTextBox richTextBox2;
        private Button btnAddProduct;
    }
}
