namespace Sales_Management_System_for_Store_X
{
    partial class WarehouseDashboard
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
            this.Manager = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLogout_ManagerProduct = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtSearch_ManagerProduct = new System.Windows.Forms.TextBox();
            this.txtID_ManagerProduct = new System.Windows.Forms.TextBox();
            this.txtSellingPrice_ManagerProduct = new System.Windows.Forms.TextBox();
            this.txtCostPrice_ManagerProduct = new System.Windows.Forms.TextBox();
            this.txtName_ManagerProduct = new System.Windows.Forms.TextBox();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.cbSupplier_ManagerProduct = new System.Windows.Forms.ComboBox();
            this.cbCategory_ManagerProduct = new System.Windows.Forms.ComboBox();
            this.btnRefresh_ManagerProduct = new System.Windows.Forms.Button();
            this.btnDelete_ManagerProduct = new System.Windows.Forms.Button();
            this.btnUpdate_ManagerProduct = new System.Windows.Forms.Button();
            this.btnAdd_ManagerProduct = new System.Windows.Forms.Button();
            this.ManagerProduct = new System.Windows.Forms.TabControl();
            this.Manager.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.ManagerProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // Manager
            // 
            this.Manager.Controls.Add(this.button1);
            this.Manager.Controls.Add(this.btnLogout_ManagerProduct);
            this.Manager.Controls.Add(this.label8);
            this.Manager.Controls.Add(this.label9);
            this.Manager.Controls.Add(this.label10);
            this.Manager.Controls.Add(this.label11);
            this.Manager.Controls.Add(this.label12);
            this.Manager.Controls.Add(this.label13);
            this.Manager.Controls.Add(this.label14);
            this.Manager.Controls.Add(this.txtSearch_ManagerProduct);
            this.Manager.Controls.Add(this.txtID_ManagerProduct);
            this.Manager.Controls.Add(this.txtSellingPrice_ManagerProduct);
            this.Manager.Controls.Add(this.txtCostPrice_ManagerProduct);
            this.Manager.Controls.Add(this.txtName_ManagerProduct);
            this.Manager.Controls.Add(this.dgvProducts);
            this.Manager.Controls.Add(this.cbSupplier_ManagerProduct);
            this.Manager.Controls.Add(this.cbCategory_ManagerProduct);
            this.Manager.Controls.Add(this.btnRefresh_ManagerProduct);
            this.Manager.Controls.Add(this.btnDelete_ManagerProduct);
            this.Manager.Controls.Add(this.btnUpdate_ManagerProduct);
            this.Manager.Controls.Add(this.btnAdd_ManagerProduct);
            this.Manager.Location = new System.Drawing.Point(4, 25);
            this.Manager.Name = "Manager";
            this.Manager.Padding = new System.Windows.Forms.Padding(3);
            this.Manager.Size = new System.Drawing.Size(1100, 477);
            this.Manager.TabIndex = 0;
            this.Manager.Text = "ManagerProduct";
            this.Manager.UseVisualStyleBackColor = true;
            this.Manager.Click += new System.EventHandler(this.Manager_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(945, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 49);
            this.button1.TabIndex = 41;
            this.button1.Text = "Export";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLogout_ManagerProduct
            // 
            this.btnLogout_ManagerProduct.Location = new System.Drawing.Point(738, 55);
            this.btnLogout_ManagerProduct.Name = "btnLogout_ManagerProduct";
            this.btnLogout_ManagerProduct.Size = new System.Drawing.Size(75, 23);
            this.btnLogout_ManagerProduct.TabIndex = 40;
            this.btnLogout_ManagerProduct.Text = "Logout";
            this.btnLogout_ManagerProduct.UseVisualStyleBackColor = true;
            this.btnLogout_ManagerProduct.Click += new System.EventHandler(this.btnLogout_ManagerProduct_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(69, 324);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 16);
            this.label8.TabIndex = 39;
            this.label8.Text = "Selling Price";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(71, 276);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 16);
            this.label9.TabIndex = 38;
            this.label9.Text = "Cost Price";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(71, 238);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 16);
            this.label10.TabIndex = 37;
            this.label10.Text = "Supplier";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(71, 201);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 16);
            this.label11.TabIndex = 36;
            this.label11.Text = "Category";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(71, 158);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 16);
            this.label12.TabIndex = 35;
            this.label12.Text = "Name";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(71, 114);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(20, 16);
            this.label13.TabIndex = 34;
            this.label13.Text = "ID";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(332, 62);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 16);
            this.label14.TabIndex = 33;
            this.label14.Text = "Search";
            // 
            // txtSearch_ManagerProduct
            // 
            this.txtSearch_ManagerProduct.Location = new System.Drawing.Point(406, 56);
            this.txtSearch_ManagerProduct.Name = "txtSearch_ManagerProduct";
            this.txtSearch_ManagerProduct.Size = new System.Drawing.Size(269, 22);
            this.txtSearch_ManagerProduct.TabIndex = 32;
            this.txtSearch_ManagerProduct.TextChanged += new System.EventHandler(this.txtSearch_ManagerProduct_TextChanged);
            // 
            // txtID_ManagerProduct
            // 
            this.txtID_ManagerProduct.Location = new System.Drawing.Point(157, 114);
            this.txtID_ManagerProduct.Name = "txtID_ManagerProduct";
            this.txtID_ManagerProduct.Size = new System.Drawing.Size(158, 22);
            this.txtID_ManagerProduct.TabIndex = 24;
            // 
            // txtSellingPrice_ManagerProduct
            // 
            this.txtSellingPrice_ManagerProduct.Location = new System.Drawing.Point(157, 318);
            this.txtSellingPrice_ManagerProduct.Name = "txtSellingPrice_ManagerProduct";
            this.txtSellingPrice_ManagerProduct.Size = new System.Drawing.Size(158, 22);
            this.txtSellingPrice_ManagerProduct.TabIndex = 23;
            // 
            // txtCostPrice_ManagerProduct
            // 
            this.txtCostPrice_ManagerProduct.Location = new System.Drawing.Point(157, 273);
            this.txtCostPrice_ManagerProduct.Name = "txtCostPrice_ManagerProduct";
            this.txtCostPrice_ManagerProduct.Size = new System.Drawing.Size(158, 22);
            this.txtCostPrice_ManagerProduct.TabIndex = 22;
            // 
            // txtName_ManagerProduct
            // 
            this.txtName_ManagerProduct.Location = new System.Drawing.Point(157, 152);
            this.txtName_ManagerProduct.Name = "txtName_ManagerProduct";
            this.txtName_ManagerProduct.Size = new System.Drawing.Size(158, 22);
            this.txtName_ManagerProduct.TabIndex = 21;
            // 
            // dgvProducts
            // 
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(364, 96);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowHeadersWidth = 51;
            this.dgvProducts.RowTemplate.Height = 24;
            this.dgvProducts.Size = new System.Drawing.Size(449, 250);
            this.dgvProducts.TabIndex = 31;
            this.dgvProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ManagerProduct_CellContentClick);
            // 
            // cbSupplier_ManagerProduct
            // 
            this.cbSupplier_ManagerProduct.FormattingEnabled = true;
            this.cbSupplier_ManagerProduct.Location = new System.Drawing.Point(157, 235);
            this.cbSupplier_ManagerProduct.Name = "cbSupplier_ManagerProduct";
            this.cbSupplier_ManagerProduct.Size = new System.Drawing.Size(158, 24);
            this.cbSupplier_ManagerProduct.TabIndex = 30;
            // 
            // cbCategory_ManagerProduct
            // 
            this.cbCategory_ManagerProduct.FormattingEnabled = true;
            this.cbCategory_ManagerProduct.Location = new System.Drawing.Point(157, 198);
            this.cbCategory_ManagerProduct.Name = "cbCategory_ManagerProduct";
            this.cbCategory_ManagerProduct.Size = new System.Drawing.Size(158, 24);
            this.cbCategory_ManagerProduct.TabIndex = 29;
            // 
            // btnRefresh_ManagerProduct
            // 
            this.btnRefresh_ManagerProduct.Location = new System.Drawing.Point(738, 379);
            this.btnRefresh_ManagerProduct.Name = "btnRefresh_ManagerProduct";
            this.btnRefresh_ManagerProduct.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh_ManagerProduct.TabIndex = 28;
            this.btnRefresh_ManagerProduct.Text = "Refresh";
            this.btnRefresh_ManagerProduct.UseVisualStyleBackColor = true;
            // 
            // btnDelete_ManagerProduct
            // 
            this.btnDelete_ManagerProduct.Location = new System.Drawing.Point(600, 379);
            this.btnDelete_ManagerProduct.Name = "btnDelete_ManagerProduct";
            this.btnDelete_ManagerProduct.Size = new System.Drawing.Size(75, 23);
            this.btnDelete_ManagerProduct.TabIndex = 27;
            this.btnDelete_ManagerProduct.Text = "Delete";
            this.btnDelete_ManagerProduct.UseVisualStyleBackColor = true;
            this.btnDelete_ManagerProduct.Click += new System.EventHandler(this.btnDelete_ManagerProduct_Click);
            // 
            // btnUpdate_ManagerProduct
            // 
            this.btnUpdate_ManagerProduct.Location = new System.Drawing.Point(460, 379);
            this.btnUpdate_ManagerProduct.Name = "btnUpdate_ManagerProduct";
            this.btnUpdate_ManagerProduct.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate_ManagerProduct.TabIndex = 26;
            this.btnUpdate_ManagerProduct.Text = "Update";
            this.btnUpdate_ManagerProduct.UseVisualStyleBackColor = true;
            // 
            // btnAdd_ManagerProduct
            // 
            this.btnAdd_ManagerProduct.Location = new System.Drawing.Point(319, 379);
            this.btnAdd_ManagerProduct.Name = "btnAdd_ManagerProduct";
            this.btnAdd_ManagerProduct.Size = new System.Drawing.Size(75, 23);
            this.btnAdd_ManagerProduct.TabIndex = 25;
            this.btnAdd_ManagerProduct.Text = "Add";
            this.btnAdd_ManagerProduct.UseVisualStyleBackColor = true;
            // 
            // ManagerProduct
            // 
            this.ManagerProduct.Controls.Add(this.Manager);
            this.ManagerProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ManagerProduct.Location = new System.Drawing.Point(0, 0);
            this.ManagerProduct.Name = "ManagerProduct";
            this.ManagerProduct.SelectedIndex = 0;
            this.ManagerProduct.Size = new System.Drawing.Size(1108, 506);
            this.ManagerProduct.TabIndex = 1;
            // 
            // WarehouseDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 506);
            this.Controls.Add(this.ManagerProduct);
            this.Name = "WarehouseDashboard";
            this.Text = "WarehouseDashboard";
            this.Load += new System.EventHandler(this.WarehouseDashboard_Load);
            this.Manager.ResumeLayout(false);
            this.Manager.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ManagerProduct.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage Manager;
        private System.Windows.Forms.Button btnLogout_ManagerProduct;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtSearch_ManagerProduct;
        private System.Windows.Forms.TextBox txtID_ManagerProduct;
        private System.Windows.Forms.TextBox txtSellingPrice_ManagerProduct;
        private System.Windows.Forms.TextBox txtCostPrice_ManagerProduct;
        private System.Windows.Forms.TextBox txtName_ManagerProduct;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.ComboBox cbSupplier_ManagerProduct;
        private System.Windows.Forms.ComboBox cbCategory_ManagerProduct;
        private System.Windows.Forms.Button btnRefresh_ManagerProduct;
        private System.Windows.Forms.Button btnDelete_ManagerProduct;
        private System.Windows.Forms.Button btnUpdate_ManagerProduct;
        private System.Windows.Forms.Button btnAdd_ManagerProduct;
        private System.Windows.Forms.TabControl ManagerProduct;
        private System.Windows.Forms.Button button1;
    }
}