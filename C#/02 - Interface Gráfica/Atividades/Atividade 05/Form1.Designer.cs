namespace Atividade_05
{
	partial class formMain
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
			this.txtProductName = new System.Windows.Forms.TextBox();
			this.lblProductName = new System.Windows.Forms.Label();
			this.numProductPrice = new System.Windows.Forms.NumericUpDown();
			this.lblProductPrice = new System.Windows.Forms.Label();
			this.radioPrazo = new System.Windows.Forms.RadioButton();
			this.radioVista = new System.Windows.Forms.RadioButton();
			this.btnSubmit = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.numProductPrice)).BeginInit();
			this.SuspendLayout();
			// 
			// txtProductName
			// 
			this.txtProductName.Location = new System.Drawing.Point(185, 11);
			this.txtProductName.Name = "txtProductName";
			this.txtProductName.Size = new System.Drawing.Size(387, 23);
			this.txtProductName.TabIndex = 0;
			// 
			// lblProductName
			// 
			this.lblProductName.AutoSize = true;
			this.lblProductName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblProductName.Location = new System.Drawing.Point(12, 9);
			this.lblProductName.Name = "lblProductName";
			this.lblProductName.Size = new System.Drawing.Size(167, 25);
			this.lblProductName.TabIndex = 1;
			this.lblProductName.Text = "Nome do Produto:";
			// 
			// numProductPrice
			// 
			this.numProductPrice.Location = new System.Drawing.Point(185, 40);
			this.numProductPrice.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
			this.numProductPrice.Name = "numProductPrice";
			this.numProductPrice.Size = new System.Drawing.Size(387, 23);
			this.numProductPrice.TabIndex = 2;
			// 
			// lblProductPrice
			// 
			this.lblProductPrice.AutoSize = true;
			this.lblProductPrice.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblProductPrice.Location = new System.Drawing.Point(115, 38);
			this.lblProductPrice.Name = "lblProductPrice";
			this.lblProductPrice.Size = new System.Drawing.Size(64, 25);
			this.lblProductPrice.TabIndex = 3;
			this.lblProductPrice.Text = "Preço:";
			// 
			// radioPrazo
			// 
			this.radioPrazo.AutoSize = true;
			this.radioPrazo.Checked = true;
			this.radioPrazo.Location = new System.Drawing.Point(185, 69);
			this.radioPrazo.Name = "radioPrazo";
			this.radioPrazo.Size = new System.Drawing.Size(65, 19);
			this.radioPrazo.TabIndex = 4;
			this.radioPrazo.TabStop = true;
			this.radioPrazo.Text = "A prazo";
			this.radioPrazo.UseVisualStyleBackColor = true;
			// 
			// radioVista
			// 
			this.radioVista.AutoSize = true;
			this.radioVista.Location = new System.Drawing.Point(256, 69);
			this.radioVista.Name = "radioVista";
			this.radioVista.Size = new System.Drawing.Size(60, 19);
			this.radioVista.TabIndex = 5;
			this.radioVista.Text = "À vista";
			this.radioVista.UseVisualStyleBackColor = true;
			// 
			// btnSubmit
			// 
			this.btnSubmit.Location = new System.Drawing.Point(322, 69);
			this.btnSubmit.Name = "btnSubmit";
			this.btnSubmit.Size = new System.Drawing.Size(250, 23);
			this.btnSubmit.TabIndex = 6;
			this.btnSubmit.Text = "Enviar";
			this.btnSubmit.UseVisualStyleBackColor = true;
			this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
			// 
			// formMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 107);
			this.Controls.Add(this.btnSubmit);
			this.Controls.Add(this.radioVista);
			this.Controls.Add(this.radioPrazo);
			this.Controls.Add(this.lblProductPrice);
			this.Controls.Add(this.numProductPrice);
			this.Controls.Add(this.lblProductName);
			this.Controls.Add(this.txtProductName);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "formMain";
			this.Text = "Store";
			((System.ComponentModel.ISupportInitialize)(this.numProductPrice)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private TextBox txtProductName;
		private Label lblProductName;
		private NumericUpDown numProductPrice;
		private Label lblProductPrice;
		private RadioButton radioPrazo;
		private RadioButton radioVista;
		private Button btnSubmit;
	}
}