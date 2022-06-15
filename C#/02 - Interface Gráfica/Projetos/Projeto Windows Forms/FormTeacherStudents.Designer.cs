namespace Projeto_Windows_Forms
{
	partial class FormTeacherStudents
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTeacherStudents));
			this.gbxRegisterStudent = new System.Windows.Forms.GroupBox();
			this.btnUpdateStudent = new System.Windows.Forms.Button();
			this.btnRemoveStudent = new System.Windows.Forms.Button();
			this.btnAddStudent = new System.Windows.Forms.Button();
			this.gbxStudenGender = new System.Windows.Forms.GroupBox();
			this.radioGenderF = new System.Windows.Forms.RadioButton();
			this.radioGenderM = new System.Windows.Forms.RadioButton();
			this.numStudentAge = new System.Windows.Forms.NumericUpDown();
			this.lblStudentAge = new System.Windows.Forms.Label();
			this.txtStudentName = new System.Windows.Forms.TextBox();
			this.lblStudentName = new System.Windows.Forms.Label();
			this.gbxAllStudents = new System.Windows.Forms.GroupBox();
			this.dgvAllStudents = new System.Windows.Forms.DataGridView();
			this.gbxRegisterStudent.SuspendLayout();
			this.gbxStudenGender.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numStudentAge)).BeginInit();
			this.gbxAllStudents.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvAllStudents)).BeginInit();
			this.SuspendLayout();
			// 
			// gbxRegisterStudent
			// 
			this.gbxRegisterStudent.Controls.Add(this.btnUpdateStudent);
			this.gbxRegisterStudent.Controls.Add(this.btnRemoveStudent);
			this.gbxRegisterStudent.Controls.Add(this.btnAddStudent);
			this.gbxRegisterStudent.Controls.Add(this.gbxStudenGender);
			this.gbxRegisterStudent.Controls.Add(this.numStudentAge);
			this.gbxRegisterStudent.Controls.Add(this.lblStudentAge);
			this.gbxRegisterStudent.Controls.Add(this.txtStudentName);
			this.gbxRegisterStudent.Controls.Add(this.lblStudentName);
			this.gbxRegisterStudent.Controls.Add(this.gbxAllStudents);
			this.gbxRegisterStudent.Location = new System.Drawing.Point(12, 12);
			this.gbxRegisterStudent.Name = "gbxRegisterStudent";
			this.gbxRegisterStudent.Size = new System.Drawing.Size(360, 437);
			this.gbxRegisterStudent.TabIndex = 0;
			this.gbxRegisterStudent.TabStop = false;
			this.gbxRegisterStudent.Text = "Alunos";
			// 
			// btnUpdateStudent
			// 
			this.btnUpdateStudent.Location = new System.Drawing.Point(174, 408);
			this.btnUpdateStudent.Name = "btnUpdateStudent";
			this.btnUpdateStudent.Size = new System.Drawing.Size(75, 23);
			this.btnUpdateStudent.TabIndex = 8;
			this.btnUpdateStudent.Text = "Atualizar";
			this.btnUpdateStudent.UseVisualStyleBackColor = true;
			this.btnUpdateStudent.Click += new System.EventHandler(this.btnUpdateStudent_Click);
			// 
			// btnRemoveStudent
			// 
			this.btnRemoveStudent.Location = new System.Drawing.Point(93, 408);
			this.btnRemoveStudent.Name = "btnRemoveStudent";
			this.btnRemoveStudent.Size = new System.Drawing.Size(75, 23);
			this.btnRemoveStudent.TabIndex = 7;
			this.btnRemoveStudent.Text = "Remover";
			this.btnRemoveStudent.UseVisualStyleBackColor = true;
			this.btnRemoveStudent.Click += new System.EventHandler(this.btnRemoveStudent_Click);
			// 
			// btnAddStudent
			// 
			this.btnAddStudent.Location = new System.Drawing.Point(12, 408);
			this.btnAddStudent.Name = "btnAddStudent";
			this.btnAddStudent.Size = new System.Drawing.Size(75, 23);
			this.btnAddStudent.TabIndex = 6;
			this.btnAddStudent.Text = "Adicionar";
			this.btnAddStudent.UseVisualStyleBackColor = true;
			this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
			// 
			// gbxStudenGender
			// 
			this.gbxStudenGender.Controls.Add(this.radioGenderF);
			this.gbxStudenGender.Controls.Add(this.radioGenderM);
			this.gbxStudenGender.Location = new System.Drawing.Point(12, 303);
			this.gbxStudenGender.Name = "gbxStudenGender";
			this.gbxStudenGender.Size = new System.Drawing.Size(189, 52);
			this.gbxStudenGender.TabIndex = 5;
			this.gbxStudenGender.TabStop = false;
			this.gbxStudenGender.Text = "Gênero";
			// 
			// radioGenderF
			// 
			this.radioGenderF.AutoSize = true;
			this.radioGenderF.Location = new System.Drawing.Point(108, 22);
			this.radioGenderF.Name = "radioGenderF";
			this.radioGenderF.Size = new System.Drawing.Size(75, 19);
			this.radioGenderF.TabIndex = 1;
			this.radioGenderF.Text = "&Feminino";
			this.radioGenderF.UseVisualStyleBackColor = true;
			// 
			// radioGenderM
			// 
			this.radioGenderM.AutoSize = true;
			this.radioGenderM.Checked = true;
			this.radioGenderM.Location = new System.Drawing.Point(8, 22);
			this.radioGenderM.Name = "radioGenderM";
			this.radioGenderM.Size = new System.Drawing.Size(80, 19);
			this.radioGenderM.TabIndex = 0;
			this.radioGenderM.TabStop = true;
			this.radioGenderM.Text = "&Masculino";
			this.radioGenderM.UseVisualStyleBackColor = true;
			// 
			// numStudentAge
			// 
			this.numStudentAge.InterceptArrowKeys = false;
			this.numStudentAge.Location = new System.Drawing.Point(252, 274);
			this.numStudentAge.Name = "numStudentAge";
			this.numStudentAge.Size = new System.Drawing.Size(96, 23);
			this.numStudentAge.TabIndex = 4;
			// 
			// lblStudentAge
			// 
			this.lblStudentAge.AutoSize = true;
			this.lblStudentAge.Location = new System.Drawing.Point(207, 276);
			this.lblStudentAge.Name = "lblStudentAge";
			this.lblStudentAge.Size = new System.Drawing.Size(39, 15);
			this.lblStudentAge.TabIndex = 3;
			this.lblStudentAge.Text = "Idade:";
			// 
			// txtStudentName
			// 
			this.txtStudentName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.txtStudentName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.txtStudentName.Location = new System.Drawing.Point(64, 273);
			this.txtStudentName.Name = "txtStudentName";
			this.txtStudentName.Size = new System.Drawing.Size(137, 23);
			this.txtStudentName.TabIndex = 2;
			// 
			// lblStudentName
			// 
			this.lblStudentName.AutoSize = true;
			this.lblStudentName.Location = new System.Drawing.Point(12, 276);
			this.lblStudentName.Name = "lblStudentName";
			this.lblStudentName.Size = new System.Drawing.Size(46, 15);
			this.lblStudentName.TabIndex = 1;
			this.lblStudentName.Text = "Nome: ";
			// 
			// gbxAllStudents
			// 
			this.gbxAllStudents.Controls.Add(this.dgvAllStudents);
			this.gbxAllStudents.Location = new System.Drawing.Point(6, 22);
			this.gbxAllStudents.Name = "gbxAllStudents";
			this.gbxAllStudents.Size = new System.Drawing.Size(348, 240);
			this.gbxAllStudents.TabIndex = 0;
			this.gbxAllStudents.TabStop = false;
			this.gbxAllStudents.Text = "Lista de Estudantes";
			// 
			// dgvAllStudents
			// 
			this.dgvAllStudents.AllowUserToAddRows = false;
			this.dgvAllStudents.AllowUserToDeleteRows = false;
			this.dgvAllStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvAllStudents.Location = new System.Drawing.Point(6, 22);
			this.dgvAllStudents.Name = "dgvAllStudents";
			this.dgvAllStudents.ReadOnly = true;
			this.dgvAllStudents.RowTemplate.Height = 25;
			this.dgvAllStudents.Size = new System.Drawing.Size(336, 212);
			this.dgvAllStudents.TabIndex = 0;
			// 
			// FormTeacherStudents
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(384, 461);
			this.Controls.Add(this.gbxRegisterStudent);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormTeacherStudents";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Load += new System.EventHandler(this.FormStudent_Load);
			this.gbxRegisterStudent.ResumeLayout(false);
			this.gbxRegisterStudent.PerformLayout();
			this.gbxStudenGender.ResumeLayout(false);
			this.gbxStudenGender.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numStudentAge)).EndInit();
			this.gbxAllStudents.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvAllStudents)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private GroupBox gbxRegisterStudent;
		private Label lblStudentName;
		private GroupBox gbxAllStudents;
		private DataGridView dgvAllStudents;
		private NumericUpDown numStudentAge;
		private Label lblStudentAge;
		private TextBox txtStudentName;
		private GroupBox gbxStudenGender;
		private RadioButton radioGenderF;
		private RadioButton radioGenderM;
		private Button btnUpdateStudent;
		private Button btnRemoveStudent;
		private Button btnAddStudent;
	}
}