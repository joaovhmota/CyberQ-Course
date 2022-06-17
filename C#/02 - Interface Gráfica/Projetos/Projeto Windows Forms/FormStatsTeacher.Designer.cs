namespace Projeto_Windows_Forms
{
	partial class FormStatsTeacher
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStatsTeacher));
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.gbxAllClasses = new System.Windows.Forms.GroupBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.gbxAllClasses.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(6, 22);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowTemplate.Height = 25;
			this.dataGridView1.Size = new System.Drawing.Size(448, 165);
			this.dataGridView1.TabIndex = 0;
			// 
			// gbxAllClasses
			// 
			this.gbxAllClasses.Controls.Add(this.dataGridView1);
			this.gbxAllClasses.Location = new System.Drawing.Point(12, 12);
			this.gbxAllClasses.Name = "gbxAllClasses";
			this.gbxAllClasses.Size = new System.Drawing.Size(460, 193);
			this.gbxAllClasses.TabIndex = 1;
			this.gbxAllClasses.TabStop = false;
			this.gbxAllClasses.Text = "Lista de Turmas";
			// 
			// FormStatsTeacher
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(484, 461);
			this.Controls.Add(this.gbxAllClasses);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormStatsTeacher";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.gbxAllClasses.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private DataGridView dataGridView1;
		private GroupBox gbxAllClasses;
	}
}