namespace Atividade_07
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
			this.lblNum = new System.Windows.Forms.Label();
			this.num1 = new System.Windows.Forms.NumericUpDown();
			this.dgvTabuada = new System.Windows.Forms.DataGridView();
			this.btnCalcular = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.num1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvTabuada)).BeginInit();
			this.SuspendLayout();
			// 
			// lblNum
			// 
			this.lblNum.AutoSize = true;
			this.lblNum.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblNum.Location = new System.Drawing.Point(12, 9);
			this.lblNum.Name = "lblNum";
			this.lblNum.Size = new System.Drawing.Size(85, 25);
			this.lblNum.TabIndex = 0;
			this.lblNum.Text = "Número:";
			// 
			// num1
			// 
			this.num1.InterceptArrowKeys = false;
			this.num1.Location = new System.Drawing.Point(103, 12);
			this.num1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.num1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.num1.Name = "num1";
			this.num1.Size = new System.Drawing.Size(169, 23);
			this.num1.TabIndex = 1;
			this.num1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// dgvTabuada
			// 
			this.dgvTabuada.AllowUserToAddRows = false;
			this.dgvTabuada.AllowUserToDeleteRows = false;
			this.dgvTabuada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvTabuada.Location = new System.Drawing.Point(12, 70);
			this.dgvTabuada.Name = "dgvTabuada";
			this.dgvTabuada.ReadOnly = true;
			this.dgvTabuada.RowTemplate.Height = 25;
			this.dgvTabuada.Size = new System.Drawing.Size(260, 479);
			this.dgvTabuada.TabIndex = 2;
			// 
			// btnCalcular
			// 
			this.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCalcular.Location = new System.Drawing.Point(12, 41);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(260, 23);
			this.btnCalcular.TabIndex = 3;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = true;
			this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 561);
			this.Controls.Add(this.btnCalcular);
			this.Controls.Add(this.dgvTabuada);
			this.Controls.Add(this.num1);
			this.Controls.Add(this.lblNum);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormMain";
			this.Text = "Tabuada";
			((System.ComponentModel.ISupportInitialize)(this.num1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvTabuada)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Label lblNum;
		private NumericUpDown num1;
		private DataGridView dgvTabuada;
		private Button btnCalcular;
	}
}