namespace Atividade_04
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
			this.num1 = new System.Windows.Forms.NumericUpDown();
			this.num2 = new System.Windows.Forms.NumericUpDown();
			this.btnAvaliar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.num1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.num2)).BeginInit();
			this.SuspendLayout();
			// 
			// num1
			// 
			this.num1.Location = new System.Drawing.Point(12, 12);
			this.num1.Name = "num1";
			this.num1.Size = new System.Drawing.Size(174, 23);
			this.num1.TabIndex = 0;
			// 
			// num2
			// 
			this.num2.Location = new System.Drawing.Point(201, 12);
			this.num2.Name = "num2";
			this.num2.Size = new System.Drawing.Size(171, 23);
			this.num2.TabIndex = 1;
			// 
			// btnAvaliar
			// 
			this.btnAvaliar.Location = new System.Drawing.Point(12, 41);
			this.btnAvaliar.Name = "btnAvaliar";
			this.btnAvaliar.Size = new System.Drawing.Size(360, 32);
			this.btnAvaliar.TabIndex = 2;
			this.btnAvaliar.Text = "Clique";
			this.btnAvaliar.UseVisualStyleBackColor = true;
			this.btnAvaliar.Click += new System.EventHandler(this.btnAvaliar_Click);
			// 
			// formMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(384, 88);
			this.Controls.Add(this.btnAvaliar);
			this.Controls.Add(this.num2);
			this.Controls.Add(this.num1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "formMain";
			this.Text = "Numeros";
			((System.ComponentModel.ISupportInitialize)(this.num1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.num2)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private NumericUpDown num1;
		private NumericUpDown num2;
		private Button btnAvaliar;
	}
}