namespace Projeto_Windows_Forms
{
	partial class FormMenuStudent
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuStudent));
               this.dgvStudentResults = new System.Windows.Forms.DataGridView();
               this.btnLogoff = new System.Windows.Forms.Button();
               this.btnUpdate = new System.Windows.Forms.Button();
               ((System.ComponentModel.ISupportInitialize)(this.dgvStudentResults)).BeginInit();
               this.SuspendLayout();
               // 
               // dgvStudentResults
               // 
               this.dgvStudentResults.AllowUserToAddRows = false;
               this.dgvStudentResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               this.dgvStudentResults.Location = new System.Drawing.Point(12, 41);
               this.dgvStudentResults.Name = "dgvStudentResults";
               this.dgvStudentResults.RowTemplate.Height = 25;
               this.dgvStudentResults.Size = new System.Drawing.Size(460, 408);
               this.dgvStudentResults.TabIndex = 0;
               // 
               // btnLogoff
               // 
               this.btnLogoff.Location = new System.Drawing.Point(242, 12);
               this.btnLogoff.Name = "btnLogoff";
               this.btnLogoff.Size = new System.Drawing.Size(227, 23);
               this.btnLogoff.TabIndex = 1;
               this.btnLogoff.Text = "Sair";
               this.btnLogoff.UseVisualStyleBackColor = true;
               this.btnLogoff.Click += new System.EventHandler(this.btnLogoff_Click);
               // 
               // btnUpdate
               // 
               this.btnUpdate.Location = new System.Drawing.Point(12, 12);
               this.btnUpdate.Name = "btnUpdate";
               this.btnUpdate.Size = new System.Drawing.Size(227, 23);
               this.btnUpdate.TabIndex = 2;
               this.btnUpdate.Text = "Atualizar Página";
               this.btnUpdate.UseVisualStyleBackColor = true;
               this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
               // 
               // FormMenuStudent
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(484, 461);
               this.Controls.Add(this.btnUpdate);
               this.Controls.Add(this.btnLogoff);
               this.Controls.Add(this.dgvStudentResults);
               this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
               this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
               this.MaximizeBox = false;
               this.MinimizeBox = false;
               this.Name = "FormMenuStudent";
               this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
               this.Load += new System.EventHandler(this.FormMenuStudent_Load);
               ((System.ComponentModel.ISupportInitialize)(this.dgvStudentResults)).EndInit();
               this.ResumeLayout(false);

		}

		#endregion

		private DataGridView dgvStudentResults;
		private Button btnLogoff;
		private Button btnUpdate;
	}
}