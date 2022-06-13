namespace Atividade_06
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.numLado1 = new System.Windows.Forms.NumericUpDown();
			this.numLado2 = new System.Windows.Forms.NumericUpDown();
			this.numLado3 = new System.Windows.Forms.NumericUpDown();
			this.lblType = new System.Windows.Forms.Label();
			this.btnAvaliar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.numLado1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numLado2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numLado3)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(69, 30);
			this.label1.TabIndex = 0;
			this.label1.Text = "Lado1";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label2.Location = new System.Drawing.Point(12, 42);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 30);
			this.label2.TabIndex = 1;
			this.label2.Text = "Lado2";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label3.Location = new System.Drawing.Point(12, 77);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(69, 30);
			this.label3.TabIndex = 2;
			this.label3.Text = "Lado3";
			// 
			// numLado1
			// 
			this.numLado1.Location = new System.Drawing.Point(88, 16);
			this.numLado1.Name = "numLado1";
			this.numLado1.Size = new System.Drawing.Size(120, 23);
			this.numLado1.TabIndex = 3;
			// 
			// numLado2
			// 
			this.numLado2.Location = new System.Drawing.Point(86, 49);
			this.numLado2.Name = "numLado2";
			this.numLado2.Size = new System.Drawing.Size(120, 23);
			this.numLado2.TabIndex = 4;
			// 
			// numLado3
			// 
			this.numLado3.Location = new System.Drawing.Point(86, 84);
			this.numLado3.Name = "numLado3";
			this.numLado3.Size = new System.Drawing.Size(120, 23);
			this.numLado3.TabIndex = 5;
			// 
			// lblType
			// 
			this.lblType.AutoSize = true;
			this.lblType.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblType.Location = new System.Drawing.Point(12, 110);
			this.lblType.Name = "lblType";
			this.lblType.Size = new System.Drawing.Size(178, 30);
			this.lblType.TabIndex = 6;
			this.lblType.Text = "Tipo de Triangulo:";
			// 
			// btnAvaliar
			// 
			this.btnAvaliar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnAvaliar.Location = new System.Drawing.Point(214, 16);
			this.btnAvaliar.Name = "btnAvaliar";
			this.btnAvaliar.Size = new System.Drawing.Size(185, 91);
			this.btnAvaliar.TabIndex = 7;
			this.btnAvaliar.Text = "Avaliar";
			this.btnAvaliar.UseVisualStyleBackColor = true;
			this.btnAvaliar.Click += new System.EventHandler(this.btnAvaliar_Click);
			// 
			// formMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(411, 158);
			this.Controls.Add(this.btnAvaliar);
			this.Controls.Add(this.lblType);
			this.Controls.Add(this.numLado3);
			this.Controls.Add(this.numLado2);
			this.Controls.Add(this.numLado1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "formMain";
			this.Text = "Avaliador de Triângulos";
			((System.ComponentModel.ISupportInitialize)(this.numLado1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numLado2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numLado3)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Label label1;
		private Label label2;
		private Label label3;
		private NumericUpDown numLado1;
		private NumericUpDown numLado2;
		private NumericUpDown numLado3;
		private Label lblType;
		private Button btnAvaliar;
	}
}