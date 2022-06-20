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
               this.dgvAllTests = new System.Windows.Forms.DataGridView();
               this.gbxAllTests = new System.Windows.Forms.GroupBox();
               this.gbxStats = new System.Windows.Forms.GroupBox();
               this.lblBelow7 = new System.Windows.Forms.Label();
               this.lblAbove7 = new System.Windows.Forms.Label();
               this.lblGirls = new System.Windows.Forms.Label();
               this.lblBoys = new System.Windows.Forms.Label();
               this.gbxTestResult = new System.Windows.Forms.GroupBox();
               this.dgvResult = new System.Windows.Forms.DataGridView();
               ((System.ComponentModel.ISupportInitialize)(this.dgvAllTests)).BeginInit();
               this.gbxAllTests.SuspendLayout();
               this.gbxStats.SuspendLayout();
               this.gbxTestResult.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
               this.SuspendLayout();
               // 
               // dgvAllTests
               // 
               this.dgvAllTests.AllowUserToAddRows = false;
               this.dgvAllTests.AllowUserToDeleteRows = false;
               this.dgvAllTests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               this.dgvAllTests.Location = new System.Drawing.Point(6, 22);
               this.dgvAllTests.Name = "dgvAllTests";
               this.dgvAllTests.ReadOnly = true;
               this.dgvAllTests.RowTemplate.Height = 25;
               this.dgvAllTests.Size = new System.Drawing.Size(448, 212);
               this.dgvAllTests.TabIndex = 0;
               this.dgvAllTests.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAllTests_CellContentClick);
               // 
               // gbxAllTests
               // 
               this.gbxAllTests.Controls.Add(this.dgvAllTests);
               this.gbxAllTests.Location = new System.Drawing.Point(12, 12);
               this.gbxAllTests.Name = "gbxAllTests";
               this.gbxAllTests.Size = new System.Drawing.Size(460, 240);
               this.gbxAllTests.TabIndex = 1;
               this.gbxAllTests.TabStop = false;
               this.gbxAllTests.Text = "Lista de Provas";
               // 
               // gbxStats
               // 
               this.gbxStats.Controls.Add(this.lblBelow7);
               this.gbxStats.Controls.Add(this.lblAbove7);
               this.gbxStats.Controls.Add(this.lblGirls);
               this.gbxStats.Controls.Add(this.lblBoys);
               this.gbxStats.Location = new System.Drawing.Point(12, 521);
               this.gbxStats.Name = "gbxStats";
               this.gbxStats.Size = new System.Drawing.Size(460, 128);
               this.gbxStats.TabIndex = 2;
               this.gbxStats.TabStop = false;
               this.gbxStats.Text = "Estatísticas";
               // 
               // lblBelow7
               // 
               this.lblBelow7.AutoSize = true;
               this.lblBelow7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
               this.lblBelow7.Location = new System.Drawing.Point(0, 94);
               this.lblBelow7.Name = "lblBelow7";
               this.lblBelow7.Size = new System.Drawing.Size(310, 25);
               this.lblBelow7.TabIndex = 3;
               this.lblBelow7.Text = "Alunos com média abaixo de 7:  0%";
               // 
               // lblAbove7
               // 
               this.lblAbove7.AutoSize = true;
               this.lblAbove7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
               this.lblAbove7.Location = new System.Drawing.Point(0, 69);
               this.lblAbove7.Name = "lblAbove7";
               this.lblAbove7.Size = new System.Drawing.Size(304, 25);
               this.lblAbove7.TabIndex = 2;
               this.lblAbove7.Text = "Alunos com média acima de 7:  0%";
               // 
               // lblGirls
               // 
               this.lblGirls.AutoSize = true;
               this.lblGirls.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
               this.lblGirls.Location = new System.Drawing.Point(0, 44);
               this.lblGirls.Name = "lblGirls";
               this.lblGirls.Size = new System.Drawing.Size(232, 25);
               this.lblGirls.TabIndex = 1;
               this.lblGirls.Text = "Quantidade de meninas: 0";
               // 
               // lblBoys
               // 
               this.lblBoys.AutoSize = true;
               this.lblBoys.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
               this.lblBoys.Location = new System.Drawing.Point(0, 19);
               this.lblBoys.Name = "lblBoys";
               this.lblBoys.Size = new System.Drawing.Size(233, 25);
               this.lblBoys.TabIndex = 0;
               this.lblBoys.Text = "Quantidade de meninos: 0";
               // 
               // gbxTestResult
               // 
               this.gbxTestResult.Controls.Add(this.dgvResult);
               this.gbxTestResult.Location = new System.Drawing.Point(12, 258);
               this.gbxTestResult.Name = "gbxTestResult";
               this.gbxTestResult.Size = new System.Drawing.Size(460, 257);
               this.gbxTestResult.TabIndex = 3;
               this.gbxTestResult.TabStop = false;
               this.gbxTestResult.Text = "Média das turmas";
               // 
               // dgvResult
               // 
               this.dgvResult.AllowUserToAddRows = false;
               this.dgvResult.AllowUserToDeleteRows = false;
               this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               this.dgvResult.Location = new System.Drawing.Point(6, 22);
               this.dgvResult.Name = "dgvResult";
               this.dgvResult.ReadOnly = true;
               this.dgvResult.RowTemplate.Height = 25;
               this.dgvResult.Size = new System.Drawing.Size(448, 229);
               this.dgvResult.TabIndex = 0;
               // 
               // FormStatsTeacher
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(484, 661);
               this.Controls.Add(this.gbxTestResult);
               this.Controls.Add(this.gbxStats);
               this.Controls.Add(this.gbxAllTests);
               this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
               this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
               this.MaximizeBox = false;
               this.MinimizeBox = false;
               this.Name = "FormStatsTeacher";
               this.Load += new System.EventHandler(this.FormStatsTeacher_Load);
               ((System.ComponentModel.ISupportInitialize)(this.dgvAllTests)).EndInit();
               this.gbxAllTests.ResumeLayout(false);
               this.gbxStats.ResumeLayout(false);
               this.gbxStats.PerformLayout();
               this.gbxTestResult.ResumeLayout(false);
               ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
               this.ResumeLayout(false);

		}

		#endregion

		private DataGridView dgvAllTests;
		private GroupBox gbxAllTests;
          private GroupBox gbxStats;
          private Label lblBelow7;
          private Label lblAbove7;
          private Label lblGirls;
          private Label lblBoys;
          private GroupBox gbxTestResult;
          private DataGridView dgvResult;
     }
}