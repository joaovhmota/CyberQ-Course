namespace Atividade_11
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
			this.txtF = new System.Windows.Forms.TextBox();
			this.txtC = new System.Windows.Forms.TextBox();
			this.lblC = new System.Windows.Forms.Label();
			this.lblF = new System.Windows.Forms.Label();
			this.btnConvert = new System.Windows.Forms.Button();
			this.radioC = new System.Windows.Forms.RadioButton();
			this.radioF = new System.Windows.Forms.RadioButton();
			this.SuspendLayout();
			// 
			// txtF
			// 
			this.txtF.Location = new System.Drawing.Point(12, 41);
			this.txtF.Name = "txtF";
			this.txtF.Size = new System.Drawing.Size(100, 23);
			this.txtF.TabIndex = 0;
			// 
			// txtC
			// 
			this.txtC.Location = new System.Drawing.Point(12, 12);
			this.txtC.Name = "txtC";
			this.txtC.Size = new System.Drawing.Size(100, 23);
			this.txtC.TabIndex = 1;
			// 
			// lblC
			// 
			this.lblC.AutoSize = true;
			this.lblC.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblC.Location = new System.Drawing.Point(118, 12);
			this.lblC.Name = "lblC";
			this.lblC.Size = new System.Drawing.Size(31, 25);
			this.lblC.TabIndex = 2;
			this.lblC.Text = "°C";
			// 
			// lblF
			// 
			this.lblF.AutoSize = true;
			this.lblF.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblF.Location = new System.Drawing.Point(118, 41);
			this.lblF.Name = "lblF";
			this.lblF.Size = new System.Drawing.Size(28, 25);
			this.lblF.TabIndex = 3;
			this.lblF.Text = "°F";
			// 
			// btnConvert
			// 
			this.btnConvert.Location = new System.Drawing.Point(12, 70);
			this.btnConvert.Name = "btnConvert";
			this.btnConvert.Size = new System.Drawing.Size(134, 23);
			this.btnConvert.TabIndex = 4;
			this.btnConvert.Text = "Converter";
			this.btnConvert.UseVisualStyleBackColor = true;
			this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
			// 
			// radioC
			// 
			this.radioC.AutoSize = true;
			this.radioC.Checked = true;
			this.radioC.Location = new System.Drawing.Point(152, 21);
			this.radioC.Name = "radioC";
			this.radioC.Size = new System.Drawing.Size(14, 13);
			this.radioC.TabIndex = 5;
			this.radioC.TabStop = true;
			this.radioC.UseVisualStyleBackColor = true;
			// 
			// radioF
			// 
			this.radioF.AutoSize = true;
			this.radioF.Location = new System.Drawing.Point(152, 50);
			this.radioF.Name = "radioF";
			this.radioF.Size = new System.Drawing.Size(14, 13);
			this.radioF.TabIndex = 6;
			this.radioF.UseVisualStyleBackColor = true;
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(192, 104);
			this.Controls.Add(this.radioF);
			this.Controls.Add(this.radioC);
			this.Controls.Add(this.btnConvert);
			this.Controls.Add(this.lblF);
			this.Controls.Add(this.lblC);
			this.Controls.Add(this.txtC);
			this.Controls.Add(this.txtF);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormMain";
			this.Text = "Temperatura";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private TextBox txtF;
		private TextBox txtC;
		private Label lblC;
		private Label lblF;
		private Button btnConvert;
		private RadioButton radioC;
		private RadioButton radioF;
	}
}