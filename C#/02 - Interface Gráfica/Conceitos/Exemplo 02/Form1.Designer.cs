namespace Exemplo_02
{
	partial class Form1
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
			this.cbxNomes = new System.Windows.Forms.ComboBox();
			this.button1 = new System.Windows.Forms.Button();
			this.txtNome = new System.Windows.Forms.TextBox();
			this.txtIdade = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// cbxNomes
			// 
			this.cbxNomes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cbxNomes.FormattingEnabled = true;
			this.cbxNomes.Location = new System.Drawing.Point(12, 12);
			this.cbxNomes.Name = "cbxNomes";
			this.cbxNomes.Size = new System.Drawing.Size(776, 23);
			this.cbxNomes.TabIndex = 0;
			this.cbxNomes.SelectedIndexChanged += new System.EventHandler(this.cbxNomes_SelectedIndexChanged);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 41);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(776, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "Clique";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// txtNome
			// 
			this.txtNome.Location = new System.Drawing.Point(12, 70);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(776, 23);
			this.txtNome.TabIndex = 2;
			// 
			// txtIdade
			// 
			this.txtIdade.Location = new System.Drawing.Point(12, 99);
			this.txtIdade.Name = "txtIdade";
			this.txtIdade.Size = new System.Drawing.Size(776, 23);
			this.txtIdade.TabIndex = 3;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.txtIdade);
			this.Controls.Add(this.txtNome);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.cbxNomes);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private ComboBox cbxNomes;
		private Button button1;
		private TextBox txtNome;
		private TextBox txtIdade;
	}
}