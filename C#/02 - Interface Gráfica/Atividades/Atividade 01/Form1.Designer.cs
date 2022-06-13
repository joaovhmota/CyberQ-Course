namespace Atividade_01
{
	partial class formSystem
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formSystem));
			this.lblProductName = new System.Windows.Forms.Label();
			this.txtProduct = new System.Windows.Forms.TextBox();
			this.lblProductPrice = new System.Windows.Forms.Label();
			this.numProductPrice = new System.Windows.Forms.NumericUpDown();
			this.btnSendProduct = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.numProductPrice)).BeginInit();
			this.SuspendLayout();
			// 
			// lblProductName
			// 
			this.lblProductName.AutoSize = true;
			this.lblProductName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblProductName.Location = new System.Drawing.Point(12, 11);
			this.lblProductName.Name = "lblProductName";
			this.lblProductName.Size = new System.Drawing.Size(191, 30);
			this.lblProductName.TabIndex = 0;
			this.lblProductName.Text = "Nome do Produto: ";
			// 
			// txtProduct
			// 
			this.txtProduct.Location = new System.Drawing.Point(209, 18);
			this.txtProduct.Name = "txtProduct";
			this.txtProduct.Size = new System.Drawing.Size(579, 23);
			this.txtProduct.TabIndex = 1;
			// 
			// lblProductPrice
			// 
			this.lblProductPrice.AutoSize = true;
			this.lblProductPrice.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblProductPrice.Location = new System.Drawing.Point(53, 53);
			this.lblProductPrice.Name = "lblProductPrice";
			this.lblProductPrice.Size = new System.Drawing.Size(150, 30);
			this.lblProductPrice.TabIndex = 2;
			this.lblProductPrice.Text = "Valor Produto: ";
			// 
			// numProductPrice
			// 
			this.numProductPrice.Location = new System.Drawing.Point(209, 60);
			this.numProductPrice.Name = "numProductPrice";
			this.numProductPrice.Size = new System.Drawing.Size(579, 23);
			this.numProductPrice.TabIndex = 3;
			// 
			// btnSendProduct
			// 
			this.btnSendProduct.Location = new System.Drawing.Point(12, 89);
			this.btnSendProduct.Name = "btnSendProduct";
			this.btnSendProduct.Size = new System.Drawing.Size(776, 23);
			this.btnSendProduct.TabIndex = 5;
			this.btnSendProduct.Text = "Enviar";
			this.btnSendProduct.UseVisualStyleBackColor = true;
			this.btnSendProduct.Click += new System.EventHandler(this.btnSendProduct_Click);
			// 
			// formSystem
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnSendProduct);
			this.Controls.Add(this.numProductPrice);
			this.Controls.Add(this.lblProductPrice);
			this.Controls.Add(this.txtProduct);
			this.Controls.Add(this.lblProductName);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "formSystem";
			this.Text = "Cadastrar Produtos";
			((System.ComponentModel.ISupportInitialize)(this.numProductPrice)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Label lblProductName;
		private TextBox txtProduct;
		private Label lblProductPrice;
		private NumericUpDown numProductPrice;
		private Button btnSendProduct;
	}
}