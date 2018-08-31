namespace EntityFrameworkDemo
{
    partial class Form1
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
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStockAmountUpdate = new System.Windows.Forms.TextBox();
            this.txtUnitePriceUpdate = new System.Windows.Forms.TextBox();
            this.txtNameUpdate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.gbProduct = new System.Windows.Forms.GroupBox();
            this.lblstockamount = new System.Windows.Forms.Label();
            this.lblUnitePrice = new System.Windows.Forms.Label();
            this.txtStockAmount = new System.Windows.Forms.TextBox();
            this.txtUnitePrice = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgwProducts = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnGetByID = new System.Windows.Forms.Button();
            this.txtGetById = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.gbProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(351, -51);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 10;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(18, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Remove";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtStockAmountUpdate);
            this.groupBox1.Controls.Add(this.txtUnitePriceUpdate);
            this.groupBox1.Controls.Add(this.txtNameUpdate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(319, 232);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 137);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add a Product";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Stock Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Unite Price";
            // 
            // txtStockAmountUpdate
            // 
            this.txtStockAmountUpdate.Location = new System.Drawing.Point(74, 84);
            this.txtStockAmountUpdate.Name = "txtStockAmountUpdate";
            this.txtStockAmountUpdate.Size = new System.Drawing.Size(100, 20);
            this.txtStockAmountUpdate.TabIndex = 4;
            // 
            // txtUnitePriceUpdate
            // 
            this.txtUnitePriceUpdate.Location = new System.Drawing.Point(74, 58);
            this.txtUnitePriceUpdate.Name = "txtUnitePriceUpdate";
            this.txtUnitePriceUpdate.Size = new System.Drawing.Size(100, 20);
            this.txtUnitePriceUpdate.TabIndex = 3;
            // 
            // txtNameUpdate
            // 
            this.txtNameUpdate.Location = new System.Drawing.Point(75, 30);
            this.txtNameUpdate.Name = "txtNameUpdate";
            this.txtNameUpdate.Size = new System.Drawing.Size(100, 20);
            this.txtNameUpdate.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Name";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(151, 108);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // gbProduct
            // 
            this.gbProduct.Controls.Add(this.lblstockamount);
            this.gbProduct.Controls.Add(this.lblUnitePrice);
            this.gbProduct.Controls.Add(this.txtStockAmount);
            this.gbProduct.Controls.Add(this.txtUnitePrice);
            this.gbProduct.Controls.Add(this.txtName);
            this.gbProduct.Controls.Add(this.lblName);
            this.gbProduct.Controls.Add(this.btnAdd);
            this.gbProduct.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbProduct.Location = new System.Drawing.Point(18, 232);
            this.gbProduct.Name = "gbProduct";
            this.gbProduct.Size = new System.Drawing.Size(248, 137);
            this.gbProduct.TabIndex = 12;
            this.gbProduct.TabStop = false;
            this.gbProduct.Text = "Add a Product";
            // 
            // lblstockamount
            // 
            this.lblstockamount.AutoSize = true;
            this.lblstockamount.Location = new System.Drawing.Point(4, 87);
            this.lblstockamount.Name = "lblstockamount";
            this.lblstockamount.Size = new System.Drawing.Size(64, 15);
            this.lblstockamount.TabIndex = 6;
            this.lblstockamount.Text = "Stock Amount";
            // 
            // lblUnitePrice
            // 
            this.lblUnitePrice.AutoSize = true;
            this.lblUnitePrice.Location = new System.Drawing.Point(16, 63);
            this.lblUnitePrice.Name = "lblUnitePrice";
            this.lblUnitePrice.Size = new System.Drawing.Size(52, 15);
            this.lblUnitePrice.TabIndex = 5;
            this.lblUnitePrice.Text = "Unite Price";
            // 
            // txtStockAmount
            // 
            this.txtStockAmount.Location = new System.Drawing.Point(74, 84);
            this.txtStockAmount.Name = "txtStockAmount";
            this.txtStockAmount.Size = new System.Drawing.Size(100, 20);
            this.txtStockAmount.TabIndex = 4;
            // 
            // txtUnitePrice
            // 
            this.txtUnitePrice.Location = new System.Drawing.Point(74, 58);
            this.txtUnitePrice.Name = "txtUnitePrice";
            this.txtUnitePrice.Size = new System.Drawing.Size(100, 20);
            this.txtUnitePrice.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(75, 30);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(16, 30);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(32, 15);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(151, 108);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgwProducts
            // 
            this.dgwProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProducts.Location = new System.Drawing.Point(18, 35);
            this.dgwProducts.Name = "dgwProducts";
            this.dgwProducts.Size = new System.Drawing.Size(598, 179);
            this.dgwProducts.TabIndex = 11;
            this.dgwProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProducts_CellClick);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(430, 11);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(511, 13);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 20);
            this.txtSearch.TabIndex = 16;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnGetByID
            // 
            this.btnGetByID.Location = new System.Drawing.Point(169, 12);
            this.btnGetByID.Name = "btnGetByID";
            this.btnGetByID.Size = new System.Drawing.Size(75, 23);
            this.btnGetByID.TabIndex = 17;
            this.btnGetByID.Text = "GetById";
            this.btnGetByID.UseVisualStyleBackColor = true;
            this.btnGetByID.Click += new System.EventHandler(this.btnGetByID_Click);
            // 
            // txtGetById
            // 
            this.txtGetById.Location = new System.Drawing.Point(250, 14);
            this.txtGetById.Name = "txtGetById";
            this.txtGetById.Size = new System.Drawing.Size(100, 20);
            this.txtGetById.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 391);
            this.Controls.Add(this.txtGetById);
            this.Controls.Add(this.btnGetByID);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbProduct);
            this.Controls.Add(this.dgwProducts);
            this.Controls.Add(this.btnRemove);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbProduct.ResumeLayout(false);
            this.gbProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStockAmountUpdate;
        private System.Windows.Forms.TextBox txtUnitePriceUpdate;
        private System.Windows.Forms.TextBox txtNameUpdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox gbProduct;
        private System.Windows.Forms.Label lblstockamount;
        private System.Windows.Forms.Label lblUnitePrice;
        private System.Windows.Forms.TextBox txtStockAmount;
        private System.Windows.Forms.TextBox txtUnitePrice;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgwProducts;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnGetByID;
        private System.Windows.Forms.TextBox txtGetById;
    }
}

