namespace Atividade_13
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
			this.radioKm = new System.Windows.Forms.RadioButton();
			this.radioM = new System.Windows.Forms.RadioButton();
			this.btnConvert = new System.Windows.Forms.Button();
			this.lblKm = new System.Windows.Forms.Label();
			this.lbM = new System.Windows.Forms.Label();
			this.txtM = new System.Windows.Forms.TextBox();
			this.txtKm = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// radioKm
			// 
			this.radioKm.AutoSize = true;
			this.radioKm.Location = new System.Drawing.Point(159, 50);
			this.radioKm.Name = "radioKm";
			this.radioKm.Size = new System.Drawing.Size(14, 13);
			this.radioKm.TabIndex = 13;
			this.radioKm.UseVisualStyleBackColor = true;
			// 
			// radioM
			// 
			this.radioM.AutoSize = true;
			this.radioM.Checked = true;
			this.radioM.Location = new System.Drawing.Point(159, 21);
			this.radioM.Name = "radioM";
			this.radioM.Size = new System.Drawing.Size(14, 13);
			this.radioM.TabIndex = 12;
			this.radioM.TabStop = true;
			this.radioM.UseVisualStyleBackColor = true;
			// 
			// btnConvert
			// 
			this.btnConvert.Location = new System.Drawing.Point(12, 70);
			this.btnConvert.Name = "btnConvert";
			this.btnConvert.Size = new System.Drawing.Size(161, 23);
			this.btnConvert.TabIndex = 11;
			this.btnConvert.Text = "Converter";
			this.btnConvert.UseVisualStyleBackColor = true;
			this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
			// 
			// lblKm
			// 
			this.lblKm.AutoSize = true;
			this.lblKm.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblKm.Location = new System.Drawing.Point(118, 41);
			this.lblKm.Name = "lblKm";
			this.lblKm.Size = new System.Drawing.Size(39, 25);
			this.lblKm.TabIndex = 10;
			this.lblKm.Text = "Km";
			// 
			// lbM
			// 
			this.lbM.AutoSize = true;
			this.lbM.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lbM.Location = new System.Drawing.Point(118, 12);
			this.lbM.Name = "lbM";
			this.lbM.Size = new System.Drawing.Size(28, 25);
			this.lbM.TabIndex = 9;
			this.lbM.Text = "m";
			// 
			// txtM
			// 
			this.txtM.Location = new System.Drawing.Point(12, 12);
			this.txtM.Name = "txtM";
			this.txtM.Size = new System.Drawing.Size(100, 23);
			this.txtM.TabIndex = 8;
			// 
			// txtKm
			// 
			this.txtKm.Location = new System.Drawing.Point(12, 41);
			this.txtKm.Name = "txtKm";
			this.txtKm.Size = new System.Drawing.Size(100, 23);
			this.txtKm.TabIndex = 7;
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(185, 106);
			this.Controls.Add(this.radioKm);
			this.Controls.Add(this.radioM);
			this.Controls.Add(this.btnConvert);
			this.Controls.Add(this.lblKm);
			this.Controls.Add(this.lbM);
			this.Controls.Add(this.txtM);
			this.Controls.Add(this.txtKm);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormMain";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private RadioButton radioKm;
		private RadioButton radioM;
		private Button btnConvert;
		private Label lblKm;
		private Label lbM;
		private TextBox txtM;
		private TextBox txtKm;
	}
}