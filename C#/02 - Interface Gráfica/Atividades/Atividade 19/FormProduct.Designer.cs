namespace Atividade_19
{
	partial class FormProduct
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProduct));
			this.dgvProducts = new System.Windows.Forms.DataGridView();
			this.lblProductName = new System.Windows.Forms.Label();
			this.txtProductName = new System.Windows.Forms.TextBox();
			this.lblProductPrice = new System.Windows.Forms.Label();
			this.numProductPrice = new System.Windows.Forms.NumericUpDown();
			this.lblProductBrand = new System.Windows.Forms.Label();
			this.cbxBrands = new System.Windows.Forms.ComboBox();
			this.btnUpdateProduct = new System.Windows.Forms.Button();
			this.btnRemoveProduct = new System.Windows.Forms.Button();
			this.btnAddProduct = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numProductPrice)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvProducts
			// 
			this.dgvProducts.AllowUserToAddRows = false;
			this.dgvProducts.AllowUserToDeleteRows = false;
			this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvProducts.Location = new System.Drawing.Point(12, 12);
			this.dgvProducts.Name = "dgvProducts";
			this.dgvProducts.ReadOnly = true;
			this.dgvProducts.RowTemplate.Height = 25;
			this.dgvProducts.Size = new System.Drawing.Size(360, 178);
			this.dgvProducts.TabIndex = 0;
			this.dgvProducts.Click += new System.EventHandler(this.dgvProducts_Click);
			// 
			// lblProductName
			// 
			this.lblProductName.AutoSize = true;
			this.lblProductName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblProductName.Location = new System.Drawing.Point(12, 202);
			this.lblProductName.Name = "lblProductName";
			this.lblProductName.Size = new System.Drawing.Size(167, 25);
			this.lblProductName.TabIndex = 1;
			this.lblProductName.Text = "Nome do Produto:";
			// 
			// txtProductName
			// 
			this.txtProductName.Location = new System.Drawing.Point(187, 207);
			this.txtProductName.Name = "txtProductName";
			this.txtProductName.Size = new System.Drawing.Size(185, 23);
			this.txtProductName.TabIndex = 2;
			// 
			// lblProductPrice
			// 
			this.lblProductPrice.AutoSize = true;
			this.lblProductPrice.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblProductPrice.Location = new System.Drawing.Point(12, 236);
			this.lblProductPrice.Name = "lblProductPrice";
			this.lblProductPrice.Size = new System.Drawing.Size(160, 25);
			this.lblProductPrice.TabIndex = 3;
			this.lblProductPrice.Text = "Valor do Produto:";
			// 
			// numProductPrice
			// 
			this.numProductPrice.Location = new System.Drawing.Point(187, 242);
			this.numProductPrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
			this.numProductPrice.Name = "numProductPrice";
			this.numProductPrice.Size = new System.Drawing.Size(185, 23);
			this.numProductPrice.TabIndex = 4;
			// 
			// lblProductBrand
			// 
			this.lblProductBrand.AutoSize = true;
			this.lblProductBrand.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblProductBrand.Location = new System.Drawing.Point(12, 271);
			this.lblProductBrand.Name = "lblProductBrand";
			this.lblProductBrand.Size = new System.Drawing.Size(169, 25);
			this.lblProductBrand.TabIndex = 5;
			this.lblProductBrand.Text = "Marca do Produto:";
			// 
			// cbxBrands
			// 
			this.cbxBrands.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cbxBrands.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.cbxBrands.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cbxBrands.FormattingEnabled = true;
			this.cbxBrands.Location = new System.Drawing.Point(187, 276);
			this.cbxBrands.Name = "cbxBrands";
			this.cbxBrands.Size = new System.Drawing.Size(185, 23);
			this.cbxBrands.TabIndex = 6;
			// 
			// btnUpdateProduct
			// 
			this.btnUpdateProduct.Enabled = false;
			this.btnUpdateProduct.Location = new System.Drawing.Point(256, 316);
			this.btnUpdateProduct.Name = "btnUpdateProduct";
			this.btnUpdateProduct.Size = new System.Drawing.Size(116, 33);
			this.btnUpdateProduct.TabIndex = 9;
			this.btnUpdateProduct.Text = "Atualizar";
			this.btnUpdateProduct.UseVisualStyleBackColor = true;
			this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
			// 
			// btnRemoveProduct
			// 
			this.btnRemoveProduct.Enabled = false;
			this.btnRemoveProduct.Location = new System.Drawing.Point(134, 316);
			this.btnRemoveProduct.Name = "btnRemoveProduct";
			this.btnRemoveProduct.Size = new System.Drawing.Size(116, 33);
			this.btnRemoveProduct.TabIndex = 8;
			this.btnRemoveProduct.Text = "Remover";
			this.btnRemoveProduct.UseVisualStyleBackColor = true;
			this.btnRemoveProduct.Click += new System.EventHandler(this.btnRemoveProduct_Click);
			// 
			// btnAddProduct
			// 
			this.btnAddProduct.Location = new System.Drawing.Point(12, 316);
			this.btnAddProduct.Name = "btnAddProduct";
			this.btnAddProduct.Size = new System.Drawing.Size(116, 33);
			this.btnAddProduct.TabIndex = 7;
			this.btnAddProduct.Text = "Adicionar";
			this.btnAddProduct.UseVisualStyleBackColor = true;
			this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
			// 
			// FormProduct
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(384, 361);
			this.Controls.Add(this.btnUpdateProduct);
			this.Controls.Add(this.btnRemoveProduct);
			this.Controls.Add(this.btnAddProduct);
			this.Controls.Add(this.cbxBrands);
			this.Controls.Add(this.lblProductBrand);
			this.Controls.Add(this.numProductPrice);
			this.Controls.Add(this.lblProductPrice);
			this.Controls.Add(this.txtProductName);
			this.Controls.Add(this.lblProductName);
			this.Controls.Add(this.dgvProducts);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormProduct";
			((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numProductPrice)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DataGridView dgvProducts;
		private Label lblProductName;
		private TextBox txtProductName;
		private Label lblProductPrice;
		private NumericUpDown numProductPrice;
		private Label lblProductBrand;
		private ComboBox cbxBrands;
		private Button btnUpdateProduct;
		private Button btnRemoveProduct;
		private Button btnAddProduct;
	}
}