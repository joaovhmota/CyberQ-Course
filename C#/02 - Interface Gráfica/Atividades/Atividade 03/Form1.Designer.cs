namespace Atividade_03
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
			this.lblNumbers = new System.Windows.Forms.Label();
			this.txtNums = new System.Windows.Forms.TextBox();
			this.btnNums = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblNumbers
			// 
			this.lblNumbers.AutoSize = true;
			this.lblNumbers.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblNumbers.Location = new System.Drawing.Point(12, 9);
			this.lblNumbers.Name = "lblNumbers";
			this.lblNumbers.Size = new System.Drawing.Size(182, 30);
			this.lblNumbers.TabIndex = 0;
			this.lblNumbers.Text = "Insira os números:";
			// 
			// txtNums
			// 
			this.txtNums.Location = new System.Drawing.Point(200, 16);
			this.txtNums.Name = "txtNums";
			this.txtNums.Size = new System.Drawing.Size(372, 23);
			this.txtNums.TabIndex = 1;
			// 
			// btnNums
			// 
			this.btnNums.Location = new System.Drawing.Point(12, 45);
			this.btnNums.Name = "btnNums";
			this.btnNums.Size = new System.Drawing.Size(560, 23);
			this.btnNums.TabIndex = 2;
			this.btnNums.Text = "Avaliar";
			this.btnNums.UseVisualStyleBackColor = true;
			this.btnNums.Click += new System.EventHandler(this.btnNums_Click);
			// 
			// formMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 80);
			this.Controls.Add(this.btnNums);
			this.Controls.Add(this.txtNums);
			this.Controls.Add(this.lblNumbers);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "formMain";
			this.Text = "Numeros";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Label lblNumbers;
		private TextBox txtNums;
		private Button btnNums;
	}
}