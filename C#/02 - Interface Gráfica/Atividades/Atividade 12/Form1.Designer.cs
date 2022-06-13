namespace Atividade_12
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
			this.lblBirthday = new System.Windows.Forms.Label();
			this.dtpDate = new System.Windows.Forms.DateTimePicker();
			this.btnSigno = new System.Windows.Forms.Button();
			this.txtSigno = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// lblBirthday
			// 
			this.lblBirthday.AutoSize = true;
			this.lblBirthday.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblBirthday.Location = new System.Drawing.Point(12, 9);
			this.lblBirthday.Name = "lblBirthday";
			this.lblBirthday.Size = new System.Drawing.Size(153, 21);
			this.lblBirthday.TabIndex = 0;
			this.lblBirthday.Text = "Data de Nascimento:";
			// 
			// dtpDate
			// 
			this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpDate.Location = new System.Drawing.Point(171, 9);
			this.dtpDate.Name = "dtpDate";
			this.dtpDate.Size = new System.Drawing.Size(243, 23);
			this.dtpDate.TabIndex = 1;
			// 
			// btnSigno
			// 
			this.btnSigno.Location = new System.Drawing.Point(12, 38);
			this.btnSigno.Name = "btnSigno";
			this.btnSigno.Size = new System.Drawing.Size(402, 23);
			this.btnSigno.TabIndex = 2;
			this.btnSigno.Text = "Saber";
			this.btnSigno.UseVisualStyleBackColor = true;
			this.btnSigno.Click += new System.EventHandler(this.btnSigno_Click);
			// 
			// txtSigno
			// 
			this.txtSigno.Enabled = false;
			this.txtSigno.Location = new System.Drawing.Point(12, 67);
			this.txtSigno.Name = "txtSigno";
			this.txtSigno.Size = new System.Drawing.Size(402, 23);
			this.txtSigno.TabIndex = 3;
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(426, 99);
			this.Controls.Add(this.txtSigno);
			this.Controls.Add(this.btnSigno);
			this.Controls.Add(this.dtpDate);
			this.Controls.Add(this.lblBirthday);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormMain";
			this.Text = "Conversor";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Label lblBirthday;
		private DateTimePicker dtpDate;
		private Button btnSigno;
		private TextBox txtSigno;
	}
}