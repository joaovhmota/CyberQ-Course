namespace Atividade_08
{
	partial class FormMain
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
			this.dgvCoins = new System.Windows.Forms.DataGridView();
			this.Moeda = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lblValorTotal = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvCoins)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvCoins
			// 
			this.dgvCoins.AllowUserToAddRows = false;
			this.dgvCoins.AllowUserToDeleteRows = false;
			this.dgvCoins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCoins.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Moeda,
            this.Quantidade});
			this.dgvCoins.Location = new System.Drawing.Point(12, 12);
			this.dgvCoins.Name = "dgvCoins";
			this.dgvCoins.RowTemplate.Height = 25;
			this.dgvCoins.Size = new System.Drawing.Size(776, 200);
			this.dgvCoins.TabIndex = 0;
			this.dgvCoins.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCoins_CellValueChanged);
			// 
			// Moeda
			// 
			this.Moeda.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Moeda.HeaderText = "Moeda";
			this.Moeda.Name = "Moeda";
			this.Moeda.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			// 
			// Quantidade
			// 
			this.Quantidade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Quantidade.HeaderText = "Quantidade";
			this.Quantidade.Name = "Quantidade";
			this.Quantidade.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			// 
			// lblValorTotal
			// 
			this.lblValorTotal.AutoSize = true;
			this.lblValorTotal.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblValorTotal.Location = new System.Drawing.Point(12, 215);
			this.lblValorTotal.Name = "lblValorTotal";
			this.lblValorTotal.Size = new System.Drawing.Size(180, 30);
			this.lblValorTotal.TabIndex = 1;
			this.lblValorTotal.Text = "Valor total: R$0.00";
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 264);
			this.Controls.Add(this.lblValorTotal);
			this.Controls.Add(this.dgvCoins);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormMain";
			this.Text = "Contador de Moedas";
			this.Load += new System.EventHandler(this.FormMain_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvCoins)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DataGridView dgvCoins;
		private DataGridViewTextBoxColumn Moeda;
		private DataGridViewTextBoxColumn Quantidade;
		private Label lblValorTotal;
	}
}