namespace Atividade_09
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
			this.cbxPrimaryCurrency = new System.Windows.Forms.ComboBox();
			this.btnConvert = new System.Windows.Forms.Button();
			this.dgvConvertion = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dgvConvertion)).BeginInit();
			this.SuspendLayout();
			// 
			// cbxPrimaryCurrency
			// 
			this.cbxPrimaryCurrency.FormattingEnabled = true;
			this.cbxPrimaryCurrency.Items.AddRange(new object[] {
            "Dólar",
            "Euro",
            "Libra",
            "Peso Argentino",
            "Real"});
			this.cbxPrimaryCurrency.Location = new System.Drawing.Point(12, 12);
			this.cbxPrimaryCurrency.Name = "cbxPrimaryCurrency";
			this.cbxPrimaryCurrency.Size = new System.Drawing.Size(310, 23);
			this.cbxPrimaryCurrency.Sorted = true;
			this.cbxPrimaryCurrency.TabIndex = 0;
			// 
			// btnConvert
			// 
			this.btnConvert.Location = new System.Drawing.Point(12, 41);
			this.btnConvert.Name = "btnConvert";
			this.btnConvert.Size = new System.Drawing.Size(310, 23);
			this.btnConvert.TabIndex = 3;
			this.btnConvert.Text = "Converter";
			this.btnConvert.UseVisualStyleBackColor = true;
			this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
			// 
			// dgvConvertion
			// 
			this.dgvConvertion.AllowUserToAddRows = false;
			this.dgvConvertion.AllowUserToDeleteRows = false;
			this.dgvConvertion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvConvertion.Location = new System.Drawing.Point(12, 70);
			this.dgvConvertion.Name = "dgvConvertion";
			this.dgvConvertion.ReadOnly = true;
			this.dgvConvertion.RowTemplate.Height = 25;
			this.dgvConvertion.Size = new System.Drawing.Size(310, 229);
			this.dgvConvertion.TabIndex = 4;
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(334, 311);
			this.Controls.Add(this.dgvConvertion);
			this.Controls.Add(this.btnConvert);
			this.Controls.Add(this.cbxPrimaryCurrency);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormMain";
			this.Text = "Conversor de Moedas";
			this.Load += new System.EventHandler(this.FormMain_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvConvertion)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private ComboBox cbxPrimaryCurrency;
		private Button btnConvert;
		private DataGridView dgvConvertion;
	}
}