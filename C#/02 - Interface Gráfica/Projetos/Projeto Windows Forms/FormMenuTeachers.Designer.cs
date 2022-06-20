namespace Projeto_Windows_Forms
{
	partial class FormMenuTeachers
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
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuTeachers));
               this.tbControlMenu = new System.Windows.Forms.TabControl();
               this.tabTeacher = new System.Windows.Forms.TabPage();
               this.panelTeacher = new System.Windows.Forms.Panel();
               this.gbxForms = new System.Windows.Forms.GroupBox();
               this.btnBlockedAccounts = new System.Windows.Forms.Button();
               this.btnFormTests = new System.Windows.Forms.Button();
               this.btnFormClasses = new System.Windows.Forms.Button();
               this.btnFormStudent = new System.Windows.Forms.Button();
               this.gbxDashBoard = new System.Windows.Forms.GroupBox();
               this.btnSchoolStats = new System.Windows.Forms.Button();
               this.lblFilterBy = new System.Windows.Forms.Label();
               this.dgvDashboard = new System.Windows.Forms.DataGridView();
               this.btnDashTests = new System.Windows.Forms.Button();
               this.btnDashStudents = new System.Windows.Forms.Button();
               this.btnDashClasses = new System.Windows.Forms.Button();
               this.btnTeLogoff = new System.Windows.Forms.Button();
               this.tbControlMenu.SuspendLayout();
               this.tabTeacher.SuspendLayout();
               this.panelTeacher.SuspendLayout();
               this.gbxForms.SuspendLayout();
               this.gbxDashBoard.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.dgvDashboard)).BeginInit();
               this.SuspendLayout();
               // 
               // tbControlMenu
               // 
               this.tbControlMenu.Controls.Add(this.tabTeacher);
               this.tbControlMenu.Location = new System.Drawing.Point(12, 12);
               this.tbControlMenu.Name = "tbControlMenu";
               this.tbControlMenu.SelectedIndex = 0;
               this.tbControlMenu.Size = new System.Drawing.Size(460, 437);
               this.tbControlMenu.TabIndex = 0;
               // 
               // tabTeacher
               // 
               this.tabTeacher.Controls.Add(this.panelTeacher);
               this.tabTeacher.Location = new System.Drawing.Point(4, 24);
               this.tabTeacher.Name = "tabTeacher";
               this.tabTeacher.Padding = new System.Windows.Forms.Padding(3);
               this.tabTeacher.Size = new System.Drawing.Size(452, 409);
               this.tabTeacher.TabIndex = 0;
               this.tabTeacher.Text = "Professor";
               this.tabTeacher.UseVisualStyleBackColor = true;
               // 
               // panelTeacher
               // 
               this.panelTeacher.Controls.Add(this.gbxForms);
               this.panelTeacher.Controls.Add(this.gbxDashBoard);
               this.panelTeacher.Controls.Add(this.btnTeLogoff);
               this.panelTeacher.Location = new System.Drawing.Point(6, 6);
               this.panelTeacher.Name = "panelTeacher";
               this.panelTeacher.Size = new System.Drawing.Size(440, 397);
               this.panelTeacher.TabIndex = 1;
               // 
               // gbxForms
               // 
               this.gbxForms.Controls.Add(this.btnBlockedAccounts);
               this.gbxForms.Controls.Add(this.btnFormTests);
               this.gbxForms.Controls.Add(this.btnFormClasses);
               this.gbxForms.Controls.Add(this.btnFormStudent);
               this.gbxForms.Location = new System.Drawing.Point(3, 276);
               this.gbxForms.Name = "gbxForms";
               this.gbxForms.Size = new System.Drawing.Size(434, 118);
               this.gbxForms.TabIndex = 6;
               this.gbxForms.TabStop = false;
               this.gbxForms.Text = "Seções";
               // 
               // btnBlockedAccounts
               // 
               this.btnBlockedAccounts.Location = new System.Drawing.Point(303, 22);
               this.btnBlockedAccounts.Name = "btnBlockedAccounts";
               this.btnBlockedAccounts.Size = new System.Drawing.Size(125, 23);
               this.btnBlockedAccounts.TabIndex = 3;
               this.btnBlockedAccounts.Text = "Contas Bloqueadas";
               this.btnBlockedAccounts.UseVisualStyleBackColor = true;
               this.btnBlockedAccounts.Click += new System.EventHandler(this.btnBlockedAccounts_Click);
               // 
               // btnFormTests
               // 
               this.btnFormTests.Location = new System.Drawing.Point(222, 22);
               this.btnFormTests.Name = "btnFormTests";
               this.btnFormTests.Size = new System.Drawing.Size(75, 23);
               this.btnFormTests.TabIndex = 2;
               this.btnFormTests.Text = "Provas";
               this.btnFormTests.UseVisualStyleBackColor = true;
               this.btnFormTests.Click += new System.EventHandler(this.btnFormTests_Click);
               // 
               // btnFormClasses
               // 
               this.btnFormClasses.Location = new System.Drawing.Point(141, 22);
               this.btnFormClasses.Name = "btnFormClasses";
               this.btnFormClasses.Size = new System.Drawing.Size(75, 23);
               this.btnFormClasses.TabIndex = 1;
               this.btnFormClasses.Text = "Turmas";
               this.btnFormClasses.UseVisualStyleBackColor = true;
               this.btnFormClasses.Click += new System.EventHandler(this.btnFormClasses_Click);
               // 
               // btnFormStudent
               // 
               this.btnFormStudent.Location = new System.Drawing.Point(6, 22);
               this.btnFormStudent.Name = "btnFormStudent";
               this.btnFormStudent.Size = new System.Drawing.Size(129, 23);
               this.btnFormStudent.TabIndex = 0;
               this.btnFormStudent.Text = "Cadastrar Estudantes";
               this.btnFormStudent.UseVisualStyleBackColor = true;
               this.btnFormStudent.Click += new System.EventHandler(this.btnFormStudent_Click);
               // 
               // gbxDashBoard
               // 
               this.gbxDashBoard.Controls.Add(this.btnSchoolStats);
               this.gbxDashBoard.Controls.Add(this.lblFilterBy);
               this.gbxDashBoard.Controls.Add(this.dgvDashboard);
               this.gbxDashBoard.Controls.Add(this.btnDashTests);
               this.gbxDashBoard.Controls.Add(this.btnDashStudents);
               this.gbxDashBoard.Controls.Add(this.btnDashClasses);
               this.gbxDashBoard.Location = new System.Drawing.Point(3, 32);
               this.gbxDashBoard.Name = "gbxDashBoard";
               this.gbxDashBoard.Size = new System.Drawing.Size(434, 238);
               this.gbxDashBoard.TabIndex = 5;
               this.gbxDashBoard.TabStop = false;
               this.gbxDashBoard.Text = "Estatísticas";
               // 
               // btnSchoolStats
               // 
               this.btnSchoolStats.Location = new System.Drawing.Point(6, 207);
               this.btnSchoolStats.Name = "btnSchoolStats";
               this.btnSchoolStats.Size = new System.Drawing.Size(116, 23);
               this.btnSchoolStats.TabIndex = 6;
               this.btnSchoolStats.Text = "Estatísticas";
               this.btnSchoolStats.UseVisualStyleBackColor = true;
               this.btnSchoolStats.Click += new System.EventHandler(this.btnSchoolStats_Click);
               // 
               // lblFilterBy
               // 
               this.lblFilterBy.AutoSize = true;
               this.lblFilterBy.Location = new System.Drawing.Point(128, 211);
               this.lblFilterBy.Name = "lblFilterBy";
               this.lblFilterBy.Size = new System.Drawing.Size(57, 15);
               this.lblFilterBy.TabIndex = 5;
               this.lblFilterBy.Text = "Filtar por:";
               // 
               // dgvDashboard
               // 
               this.dgvDashboard.AllowUserToAddRows = false;
               this.dgvDashboard.AllowUserToDeleteRows = false;
               this.dgvDashboard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               this.dgvDashboard.Location = new System.Drawing.Point(6, 22);
               this.dgvDashboard.Name = "dgvDashboard";
               this.dgvDashboard.ReadOnly = true;
               this.dgvDashboard.RowTemplate.Height = 25;
               this.dgvDashboard.Size = new System.Drawing.Size(422, 179);
               this.dgvDashboard.TabIndex = 1;
               // 
               // btnDashTests
               // 
               this.btnDashTests.Location = new System.Drawing.Point(353, 207);
               this.btnDashTests.Name = "btnDashTests";
               this.btnDashTests.Size = new System.Drawing.Size(75, 23);
               this.btnDashTests.TabIndex = 4;
               this.btnDashTests.Text = "Provas";
               this.btnDashTests.UseVisualStyleBackColor = true;
               this.btnDashTests.Click += new System.EventHandler(this.btnDashTests_Click);
               // 
               // btnDashStudents
               // 
               this.btnDashStudents.Location = new System.Drawing.Point(191, 207);
               this.btnDashStudents.Name = "btnDashStudents";
               this.btnDashStudents.Size = new System.Drawing.Size(75, 23);
               this.btnDashStudents.TabIndex = 2;
               this.btnDashStudents.Text = "Estudantes";
               this.btnDashStudents.UseVisualStyleBackColor = true;
               this.btnDashStudents.Click += new System.EventHandler(this.btnDashStudents_Click);
               // 
               // btnDashClasses
               // 
               this.btnDashClasses.Location = new System.Drawing.Point(272, 207);
               this.btnDashClasses.Name = "btnDashClasses";
               this.btnDashClasses.Size = new System.Drawing.Size(75, 23);
               this.btnDashClasses.TabIndex = 3;
               this.btnDashClasses.Text = "Turmas";
               this.btnDashClasses.UseVisualStyleBackColor = true;
               this.btnDashClasses.Click += new System.EventHandler(this.btnDashClasses_Click);
               // 
               // btnTeLogoff
               // 
               this.btnTeLogoff.Location = new System.Drawing.Point(362, 3);
               this.btnTeLogoff.Name = "btnTeLogoff";
               this.btnTeLogoff.Size = new System.Drawing.Size(75, 23);
               this.btnTeLogoff.TabIndex = 0;
               this.btnTeLogoff.Text = "Sair";
               this.btnTeLogoff.UseVisualStyleBackColor = true;
               this.btnTeLogoff.Click += new System.EventHandler(this.Logoff);
               // 
               // FormMenuTeachers
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(484, 461);
               this.Controls.Add(this.tbControlMenu);
               this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
               this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
               this.MaximizeBox = false;
               this.MinimizeBox = false;
               this.Name = "FormMenuTeachers";
               this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
               this.Load += new System.EventHandler(this.FormMenu_Load);
               this.tbControlMenu.ResumeLayout(false);
               this.tabTeacher.ResumeLayout(false);
               this.panelTeacher.ResumeLayout(false);
               this.gbxForms.ResumeLayout(false);
               this.gbxDashBoard.ResumeLayout(false);
               this.gbxDashBoard.PerformLayout();
               ((System.ComponentModel.ISupportInitialize)(this.dgvDashboard)).EndInit();
               this.ResumeLayout(false);

		}

		#endregion

		private TabControl tbControlMenu;
		private TabPage tabTeacher;
		private Button btnTeLogoff;
		private Panel panelTeacher;
		private Button btnDashTests;
		private Button btnDashClasses;
		private Button btnDashStudents;
		private DataGridView dgvDashboard;
		private GroupBox gbxDashBoard;
		private Label lblFilterBy;
		private GroupBox gbxForms;
		private Button btnFormTests;
		private Button btnFormClasses;
		private Button btnFormStudent;
		private Button btnBlockedAccounts;
		private Button btnSchoolStats;
	}
}