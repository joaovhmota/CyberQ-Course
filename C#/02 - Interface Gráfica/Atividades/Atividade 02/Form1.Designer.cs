namespace Atividade_02
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
			this.txtStudentName = new System.Windows.Forms.TextBox();
			this.num1 = new System.Windows.Forms.NumericUpDown();
			this.num2 = new System.Windows.Forms.NumericUpDown();
			this.num3 = new System.Windows.Forms.NumericUpDown();
			this.lblStudentName = new System.Windows.Forms.Label();
			this.lblStudentNotes = new System.Windows.Forms.Label();
			this.btnStudentInfo = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.num1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.num2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.num3)).BeginInit();
			this.SuspendLayout();
			// 
			// txtStudentName
			// 
			this.txtStudentName.Location = new System.Drawing.Point(221, 18);
			this.txtStudentName.Name = "txtStudentName";
			this.txtStudentName.Size = new System.Drawing.Size(567, 23);
			this.txtStudentName.TabIndex = 0;
			// 
			// num1
			// 
			this.num1.Location = new System.Drawing.Point(221, 54);
			this.num1.Name = "num1";
			this.num1.Size = new System.Drawing.Size(120, 23);
			this.num1.TabIndex = 1;
			// 
			// num2
			// 
			this.num2.Location = new System.Drawing.Point(347, 54);
			this.num2.Name = "num2";
			this.num2.Size = new System.Drawing.Size(120, 23);
			this.num2.TabIndex = 2;
			// 
			// num3
			// 
			this.num3.Location = new System.Drawing.Point(473, 54);
			this.num3.Name = "num3";
			this.num3.Size = new System.Drawing.Size(120, 23);
			this.num3.TabIndex = 3;
			// 
			// lblStudentName
			// 
			this.lblStudentName.AutoSize = true;
			this.lblStudentName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblStudentName.Location = new System.Drawing.Point(12, 9);
			this.lblStudentName.Name = "lblStudentName";
			this.lblStudentName.Size = new System.Drawing.Size(203, 30);
			this.lblStudentName.TabIndex = 4;
			this.lblStudentName.Text = "Nome do Estudante:";
			// 
			// lblStudentNotes
			// 
			this.lblStudentNotes.AutoSize = true;
			this.lblStudentNotes.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblStudentNotes.Location = new System.Drawing.Point(142, 47);
			this.lblStudentNotes.Name = "lblStudentNotes";
			this.lblStudentNotes.Size = new System.Drawing.Size(73, 30);
			this.lblStudentNotes.TabIndex = 5;
			this.lblStudentNotes.Text = "Notas:";
			// 
			// btnStudentInfo
			// 
			this.btnStudentInfo.Location = new System.Drawing.Point(599, 54);
			this.btnStudentInfo.Name = "btnStudentInfo";
			this.btnStudentInfo.Size = new System.Drawing.Size(189, 23);
			this.btnStudentInfo.TabIndex = 6;
			this.btnStudentInfo.Text = "Enviar";
			this.btnStudentInfo.UseVisualStyleBackColor = true;
			this.btnStudentInfo.Click += new System.EventHandler(this.btnStudentInfo_Click);
			// 
			// formMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 111);
			this.Controls.Add(this.btnStudentInfo);
			this.Controls.Add(this.lblStudentNotes);
			this.Controls.Add(this.lblStudentName);
			this.Controls.Add(this.num3);
			this.Controls.Add(this.num2);
			this.Controls.Add(this.num1);
			this.Controls.Add(this.txtStudentName);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "formMain";
			this.Text = "Avaliar Aluno";
			((System.ComponentModel.ISupportInitialize)(this.num1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.num2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.num3)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private TextBox txtStudentName;
		private NumericUpDown num1;
		private NumericUpDown num2;
		private NumericUpDown num3;
		private Label lblStudentName;
		private Label lblStudentNotes;
		private Button btnStudentInfo;
	}
}