namespace Atividade_19
{
	partial class FormBrand
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBrand));
			this.dgvBrands = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.txtNomeBrand = new System.Windows.Forms.TextBox();
			this.btnAddBrand = new System.Windows.Forms.Button();
			this.btnRemoveBrand = new System.Windows.Forms.Button();
			this.btnUpdateBrand = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvBrands)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvBrands
			// 
			this.dgvBrands.AllowUserToAddRows = false;
			this.dgvBrands.AllowUserToDeleteRows = false;
			this.dgvBrands.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvBrands.Location = new System.Drawing.Point(12, 12);
			this.dgvBrands.Name = "dgvBrands";
			this.dgvBrands.ReadOnly = true;
			this.dgvBrands.RowTemplate.Height = 25;
			this.dgvBrands.Size = new System.Drawing.Size(360, 178);
			this.dgvBrands.TabIndex = 0;
			this.dgvBrands.Click += new System.EventHandler(this.dgvBrands_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(12, 207);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(155, 25);
			this.label1.TabIndex = 1;
			this.label1.Text = "Nome da marca: ";
			// 
			// txtNomeBrand
			// 
			this.txtNomeBrand.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.txtNomeBrand.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.txtNomeBrand.Location = new System.Drawing.Point(173, 212);
			this.txtNomeBrand.Name = "txtNomeBrand";
			this.txtNomeBrand.Size = new System.Drawing.Size(199, 23);
			this.txtNomeBrand.TabIndex = 2;
			// 
			// btnAddBrand
			// 
			this.btnAddBrand.Location = new System.Drawing.Point(12, 316);
			this.btnAddBrand.Name = "btnAddBrand";
			this.btnAddBrand.Size = new System.Drawing.Size(116, 33);
			this.btnAddBrand.TabIndex = 3;
			this.btnAddBrand.Text = "Adicionar";
			this.btnAddBrand.UseVisualStyleBackColor = true;
			this.btnAddBrand.Click += new System.EventHandler(this.btnAddBrand_Click);
			// 
			// btnRemoveBrand
			// 
			this.btnRemoveBrand.Enabled = false;
			this.btnRemoveBrand.Location = new System.Drawing.Point(134, 316);
			this.btnRemoveBrand.Name = "btnRemoveBrand";
			this.btnRemoveBrand.Size = new System.Drawing.Size(116, 33);
			this.btnRemoveBrand.TabIndex = 4;
			this.btnRemoveBrand.Text = "Remover";
			this.btnRemoveBrand.UseVisualStyleBackColor = true;
			this.btnRemoveBrand.Click += new System.EventHandler(this.btnRemoveBrand_Click);
			// 
			// btnUpdateBrand
			// 
			this.btnUpdateBrand.Enabled = false;
			this.btnUpdateBrand.Location = new System.Drawing.Point(256, 316);
			this.btnUpdateBrand.Name = "btnUpdateBrand";
			this.btnUpdateBrand.Size = new System.Drawing.Size(116, 33);
			this.btnUpdateBrand.TabIndex = 5;
			this.btnUpdateBrand.Text = "Atualizar";
			this.btnUpdateBrand.UseVisualStyleBackColor = true;
			this.btnUpdateBrand.Click += new System.EventHandler(this.btnUpdateBrand_Click);
			// 
			// FormBrand
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(384, 361);
			this.Controls.Add(this.btnUpdateBrand);
			this.Controls.Add(this.btnRemoveBrand);
			this.Controls.Add(this.btnAddBrand);
			this.Controls.Add(this.txtNomeBrand);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dgvBrands);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormBrand";
			this.Click += new System.EventHandler(this.FormBrand_Click);
			((System.ComponentModel.ISupportInitialize)(this.dgvBrands)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DataGridView dgvBrands;
		private Label label1;
		private TextBox txtNomeBrand;
		private Button btnAddBrand;
		private Button btnRemoveBrand;
		private Button btnUpdateBrand;
	}
}