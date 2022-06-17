namespace Projeto_Windows_Forms
{
	partial class FormClassesTeacher
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClassesTeacher));
			this.gbxAllClasses = new System.Windows.Forms.GroupBox();
			this.dgvAllClasses = new System.Windows.Forms.DataGridView();
			this.lblClassName = new System.Windows.Forms.Label();
			this.txtClassName = new System.Windows.Forms.TextBox();
			this.gbxAllStudents = new System.Windows.Forms.GroupBox();
			this.btnRemoveStudentFromClass = new System.Windows.Forms.Button();
			this.lblClass = new System.Windows.Forms.Label();
			this.cbxSelectedSchoolClass = new System.Windows.Forms.ComboBox();
			this.dgvClassStudents = new System.Windows.Forms.DataGridView();
			this.btnUpdateClass = new System.Windows.Forms.Button();
			this.btnRemoveClass = new System.Windows.Forms.Button();
			this.btnAddClass = new System.Windows.Forms.Button();
			this.gbxAddStudentToClass = new System.Windows.Forms.GroupBox();
			this.btnAddStudentToClass = new System.Windows.Forms.Button();
			this.dgvStudentsNotInClass = new System.Windows.Forms.DataGridView();
			this.gbxAllClasses.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvAllClasses)).BeginInit();
			this.gbxAllStudents.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvClassStudents)).BeginInit();
			this.gbxAddStudentToClass.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvStudentsNotInClass)).BeginInit();
			this.SuspendLayout();
			// 
			// gbxAllClasses
			// 
			this.gbxAllClasses.Controls.Add(this.dgvAllClasses);
			this.gbxAllClasses.Location = new System.Drawing.Point(12, 12);
			this.gbxAllClasses.Name = "gbxAllClasses";
			this.gbxAllClasses.Size = new System.Drawing.Size(460, 248);
			this.gbxAllClasses.TabIndex = 0;
			this.gbxAllClasses.TabStop = false;
			this.gbxAllClasses.Text = "Lista de Salas de Aula";
			// 
			// dgvAllClasses
			// 
			this.dgvAllClasses.AllowUserToAddRows = false;
			this.dgvAllClasses.AllowUserToDeleteRows = false;
			this.dgvAllClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvAllClasses.Location = new System.Drawing.Point(6, 22);
			this.dgvAllClasses.Name = "dgvAllClasses";
			this.dgvAllClasses.ReadOnly = true;
			this.dgvAllClasses.RowTemplate.Height = 25;
			this.dgvAllClasses.Size = new System.Drawing.Size(448, 220);
			this.dgvAllClasses.TabIndex = 0;
			// 
			// lblClassName
			// 
			this.lblClassName.AutoSize = true;
			this.lblClassName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblClassName.Location = new System.Drawing.Point(18, 269);
			this.lblClassName.Name = "lblClassName";
			this.lblClassName.Size = new System.Drawing.Size(120, 20);
			this.lblClassName.TabIndex = 1;
			this.lblClassName.Text = "Nome da Turma:";
			// 
			// txtClassName
			// 
			this.txtClassName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txtClassName.Location = new System.Drawing.Point(144, 266);
			this.txtClassName.Name = "txtClassName";
			this.txtClassName.Size = new System.Drawing.Size(322, 27);
			this.txtClassName.TabIndex = 2;
			// 
			// gbxAllStudents
			// 
			this.gbxAllStudents.Controls.Add(this.btnRemoveStudentFromClass);
			this.gbxAllStudents.Controls.Add(this.lblClass);
			this.gbxAllStudents.Controls.Add(this.cbxSelectedSchoolClass);
			this.gbxAllStudents.Controls.Add(this.dgvClassStudents);
			this.gbxAllStudents.Location = new System.Drawing.Point(478, 12);
			this.gbxAllStudents.Name = "gbxAllStudents";
			this.gbxAllStudents.Size = new System.Drawing.Size(494, 248);
			this.gbxAllStudents.TabIndex = 3;
			this.gbxAllStudents.TabStop = false;
			this.gbxAllStudents.Text = "Lista de Estudantes";
			// 
			// btnRemoveStudentFromClass
			// 
			this.btnRemoveStudentFromClass.Location = new System.Drawing.Point(222, 217);
			this.btnRemoveStudentFromClass.Name = "btnRemoveStudentFromClass";
			this.btnRemoveStudentFromClass.Size = new System.Drawing.Size(266, 23);
			this.btnRemoveStudentFromClass.TabIndex = 9;
			this.btnRemoveStudentFromClass.Text = "Remover Alunos";
			this.btnRemoveStudentFromClass.UseVisualStyleBackColor = true;
			this.btnRemoveStudentFromClass.Click += new System.EventHandler(this.btnRemoveStudentFromClass_Click);
			// 
			// lblClass
			// 
			this.lblClass.AutoSize = true;
			this.lblClass.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblClass.Location = new System.Drawing.Point(6, 217);
			this.lblClass.Name = "lblClass";
			this.lblClass.Size = new System.Drawing.Size(54, 20);
			this.lblClass.TabIndex = 8;
			this.lblClass.Text = "Turma:";
			// 
			// cbxSelectedSchoolClass
			// 
			this.cbxSelectedSchoolClass.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.cbxSelectedSchoolClass.FormattingEnabled = true;
			this.cbxSelectedSchoolClass.Location = new System.Drawing.Point(66, 214);
			this.cbxSelectedSchoolClass.Name = "cbxSelectedSchoolClass";
			this.cbxSelectedSchoolClass.Size = new System.Drawing.Size(150, 28);
			this.cbxSelectedSchoolClass.TabIndex = 7;
			this.cbxSelectedSchoolClass.SelectedIndexChanged += new System.EventHandler(this.cbxSelectedSchoolClass_SelectedIndexChanged);
			// 
			// dgvClassStudents
			// 
			this.dgvClassStudents.AllowUserToAddRows = false;
			this.dgvClassStudents.AllowUserToDeleteRows = false;
			this.dgvClassStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvClassStudents.Location = new System.Drawing.Point(6, 22);
			this.dgvClassStudents.Name = "dgvClassStudents";
			this.dgvClassStudents.ReadOnly = true;
			this.dgvClassStudents.RowTemplate.Height = 25;
			this.dgvClassStudents.Size = new System.Drawing.Size(482, 186);
			this.dgvClassStudents.TabIndex = 0;
			// 
			// btnUpdateClass
			// 
			this.btnUpdateClass.Location = new System.Drawing.Point(391, 299);
			this.btnUpdateClass.Name = "btnUpdateClass";
			this.btnUpdateClass.Size = new System.Drawing.Size(75, 23);
			this.btnUpdateClass.TabIndex = 4;
			this.btnUpdateClass.Text = "Atualizar";
			this.btnUpdateClass.UseVisualStyleBackColor = true;
			this.btnUpdateClass.Click += new System.EventHandler(this.btnUpdateClass_Click);
			// 
			// btnRemoveClass
			// 
			this.btnRemoveClass.Location = new System.Drawing.Point(310, 299);
			this.btnRemoveClass.Name = "btnRemoveClass";
			this.btnRemoveClass.Size = new System.Drawing.Size(75, 23);
			this.btnRemoveClass.TabIndex = 5;
			this.btnRemoveClass.Text = "Remover";
			this.btnRemoveClass.UseVisualStyleBackColor = true;
			this.btnRemoveClass.Click += new System.EventHandler(this.btnRemoveClass_Click);
			// 
			// btnAddClass
			// 
			this.btnAddClass.Location = new System.Drawing.Point(229, 299);
			this.btnAddClass.Name = "btnAddClass";
			this.btnAddClass.Size = new System.Drawing.Size(75, 23);
			this.btnAddClass.TabIndex = 6;
			this.btnAddClass.Text = "Adicionar";
			this.btnAddClass.UseVisualStyleBackColor = true;
			this.btnAddClass.Click += new System.EventHandler(this.btnAddClass_Click);
			// 
			// gbxAddStudentToClass
			// 
			this.gbxAddStudentToClass.Controls.Add(this.btnAddStudentToClass);
			this.gbxAddStudentToClass.Controls.Add(this.dgvStudentsNotInClass);
			this.gbxAddStudentToClass.Location = new System.Drawing.Point(478, 269);
			this.gbxAddStudentToClass.Name = "gbxAddStudentToClass";
			this.gbxAddStudentToClass.Size = new System.Drawing.Size(488, 280);
			this.gbxAddStudentToClass.TabIndex = 7;
			this.gbxAddStudentToClass.TabStop = false;
			this.gbxAddStudentToClass.Text = "Gerênciar Estudantes nas Turmas";
			// 
			// btnAddStudentToClass
			// 
			this.btnAddStudentToClass.Location = new System.Drawing.Point(6, 251);
			this.btnAddStudentToClass.Name = "btnAddStudentToClass";
			this.btnAddStudentToClass.Size = new System.Drawing.Size(476, 23);
			this.btnAddStudentToClass.TabIndex = 1;
			this.btnAddStudentToClass.Text = "Adicionar Estudante";
			this.btnAddStudentToClass.UseVisualStyleBackColor = true;
			this.btnAddStudentToClass.Click += new System.EventHandler(this.btnAddStudentToClass_Click);
			// 
			// dgvStudentsNotInClass
			// 
			this.dgvStudentsNotInClass.AllowUserToAddRows = false;
			this.dgvStudentsNotInClass.AllowUserToDeleteRows = false;
			this.dgvStudentsNotInClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvStudentsNotInClass.Location = new System.Drawing.Point(6, 22);
			this.dgvStudentsNotInClass.Name = "dgvStudentsNotInClass";
			this.dgvStudentsNotInClass.ReadOnly = true;
			this.dgvStudentsNotInClass.RowTemplate.Height = 25;
			this.dgvStudentsNotInClass.Size = new System.Drawing.Size(476, 223);
			this.dgvStudentsNotInClass.TabIndex = 0;
			// 
			// FormClassesTeacher
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(984, 561);
			this.Controls.Add(this.gbxAddStudentToClass);
			this.Controls.Add(this.btnAddClass);
			this.Controls.Add(this.btnRemoveClass);
			this.Controls.Add(this.btnUpdateClass);
			this.Controls.Add(this.gbxAllStudents);
			this.Controls.Add(this.txtClassName);
			this.Controls.Add(this.lblClassName);
			this.Controls.Add(this.gbxAllClasses);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormClassesTeacher";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Load += new System.EventHandler(this.FormClassesTeacher_Load);
			this.gbxAllClasses.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvAllClasses)).EndInit();
			this.gbxAllStudents.ResumeLayout(false);
			this.gbxAllStudents.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvClassStudents)).EndInit();
			this.gbxAddStudentToClass.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvStudentsNotInClass)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private GroupBox gbxAllClasses;
		private DataGridView dgvAllClasses;
		private Label lblClassName;
		private TextBox txtClassName;
		private GroupBox gbxAllStudents;
		private Button btnUpdateClass;
		private Button btnRemoveClass;
		private Button btnAddClass;
		private DataGridView dgvClassStudents;
		private ComboBox cbxSelectedSchoolClass;
		private Label lblClass;
		private Button btnRemoveStudentFromClass;
		private GroupBox gbxAddStudentToClass;
		private Button btnAddStudentToClass;
		private DataGridView dgvStudentsNotInClass;
	}
}