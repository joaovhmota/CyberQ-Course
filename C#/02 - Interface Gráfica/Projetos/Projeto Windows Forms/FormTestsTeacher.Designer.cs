namespace Projeto_Windows_Forms
{
	partial class FormTestsTeacher
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
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTestsTeacher));
               this.gbxRegisterTests = new System.Windows.Forms.GroupBox();
               this.lblTestDate = new System.Windows.Forms.Label();
               this.dtpTestDate = new System.Windows.Forms.DateTimePicker();
               this.btnAddTest = new System.Windows.Forms.Button();
               this.btnRemoveTest = new System.Windows.Forms.Button();
               this.txtTestName = new System.Windows.Forms.TextBox();
               this.lblTestName = new System.Windows.Forms.Label();
               this.dgvRegisteredTests = new System.Windows.Forms.DataGridView();
               this.gbxApplyTest = new System.Windows.Forms.GroupBox();
               this.btnApplyToClass = new System.Windows.Forms.Button();
               this.btnApplyNote = new System.Windows.Forms.Button();
               this.lblStudentNote = new System.Windows.Forms.Label();
               this.cbxToApplyStudent = new System.Windows.Forms.ComboBox();
               this.numStudentNote = new System.Windows.Forms.NumericUpDown();
               this.lblStudent = new System.Windows.Forms.Label();
               this.dgvToApplyTest = new System.Windows.Forms.DataGridView();
               this.dgvToApplyClass = new System.Windows.Forms.DataGridView();
               this.gbxRegisterTests.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.dgvRegisteredTests)).BeginInit();
               this.gbxApplyTest.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.numStudentNote)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.dgvToApplyTest)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.dgvToApplyClass)).BeginInit();
               this.SuspendLayout();
               // 
               // gbxRegisterTests
               // 
               this.gbxRegisterTests.Controls.Add(this.lblTestDate);
               this.gbxRegisterTests.Controls.Add(this.dtpTestDate);
               this.gbxRegisterTests.Controls.Add(this.btnAddTest);
               this.gbxRegisterTests.Controls.Add(this.btnRemoveTest);
               this.gbxRegisterTests.Controls.Add(this.txtTestName);
               this.gbxRegisterTests.Controls.Add(this.lblTestName);
               this.gbxRegisterTests.Controls.Add(this.dgvRegisteredTests);
               this.gbxRegisterTests.Location = new System.Drawing.Point(12, 12);
               this.gbxRegisterTests.Name = "gbxRegisterTests";
               this.gbxRegisterTests.Size = new System.Drawing.Size(452, 375);
               this.gbxRegisterTests.TabIndex = 0;
               this.gbxRegisterTests.TabStop = false;
               this.gbxRegisterTests.Text = "Cadastrar Provas";
               // 
               // lblTestDate
               // 
               this.lblTestDate.AutoSize = true;
               this.lblTestDate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
               this.lblTestDate.Location = new System.Drawing.Point(6, 309);
               this.lblTestDate.Name = "lblTestDate";
               this.lblTestDate.Size = new System.Drawing.Size(133, 20);
               this.lblTestDate.TabIndex = 6;
               this.lblTestDate.Text = "Data de aplicação:";
               // 
               // dtpTestDate
               // 
               this.dtpTestDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
               this.dtpTestDate.Location = new System.Drawing.Point(145, 306);
               this.dtpTestDate.Name = "dtpTestDate";
               this.dtpTestDate.Size = new System.Drawing.Size(301, 23);
               this.dtpTestDate.TabIndex = 5;
               // 
               // btnAddTest
               // 
               this.btnAddTest.Location = new System.Drawing.Point(140, 335);
               this.btnAddTest.Name = "btnAddTest";
               this.btnAddTest.Size = new System.Drawing.Size(150, 30);
               this.btnAddTest.TabIndex = 4;
               this.btnAddTest.Text = "Adicionar";
               this.btnAddTest.UseVisualStyleBackColor = true;
               this.btnAddTest.Click += new System.EventHandler(this.btnAddTest_Click);
               // 
               // btnRemoveTest
               // 
               this.btnRemoveTest.Location = new System.Drawing.Point(296, 335);
               this.btnRemoveTest.Name = "btnRemoveTest";
               this.btnRemoveTest.Size = new System.Drawing.Size(150, 30);
               this.btnRemoveTest.TabIndex = 3;
               this.btnRemoveTest.Text = "Remover";
               this.btnRemoveTest.UseVisualStyleBackColor = true;
               this.btnRemoveTest.Click += new System.EventHandler(this.btnRemoveTest_Click);
               // 
               // txtTestName
               // 
               this.txtTestName.Location = new System.Drawing.Point(125, 277);
               this.txtTestName.Name = "txtTestName";
               this.txtTestName.Size = new System.Drawing.Size(321, 23);
               this.txtTestName.TabIndex = 2;
               // 
               // lblTestName
               // 
               this.lblTestName.AutoSize = true;
               this.lblTestName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
               this.lblTestName.Location = new System.Drawing.Point(6, 280);
               this.lblTestName.Name = "lblTestName";
               this.lblTestName.Size = new System.Drawing.Size(113, 20);
               this.lblTestName.TabIndex = 1;
               this.lblTestName.Text = "Título da prova:";
               // 
               // dgvRegisteredTests
               // 
               this.dgvRegisteredTests.AllowUserToAddRows = false;
               this.dgvRegisteredTests.AllowUserToDeleteRows = false;
               this.dgvRegisteredTests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               this.dgvRegisteredTests.Location = new System.Drawing.Point(6, 22);
               this.dgvRegisteredTests.Name = "dgvRegisteredTests";
               this.dgvRegisteredTests.ReadOnly = true;
               this.dgvRegisteredTests.RowTemplate.Height = 25;
               this.dgvRegisteredTests.Size = new System.Drawing.Size(440, 249);
               this.dgvRegisteredTests.TabIndex = 0;
               // 
               // gbxApplyTest
               // 
               this.gbxApplyTest.Controls.Add(this.btnApplyToClass);
               this.gbxApplyTest.Controls.Add(this.btnApplyNote);
               this.gbxApplyTest.Controls.Add(this.lblStudentNote);
               this.gbxApplyTest.Controls.Add(this.cbxToApplyStudent);
               this.gbxApplyTest.Controls.Add(this.numStudentNote);
               this.gbxApplyTest.Controls.Add(this.lblStudent);
               this.gbxApplyTest.Controls.Add(this.dgvToApplyTest);
               this.gbxApplyTest.Controls.Add(this.dgvToApplyClass);
               this.gbxApplyTest.Location = new System.Drawing.Point(470, 12);
               this.gbxApplyTest.Name = "gbxApplyTest";
               this.gbxApplyTest.Size = new System.Drawing.Size(602, 375);
               this.gbxApplyTest.TabIndex = 1;
               this.gbxApplyTest.TabStop = false;
               this.gbxApplyTest.Text = "Marcar prova";
               // 
               // btnApplyToClass
               // 
               this.btnApplyToClass.Location = new System.Drawing.Point(6, 285);
               this.btnApplyToClass.Name = "btnApplyToClass";
               this.btnApplyToClass.Size = new System.Drawing.Size(221, 23);
               this.btnApplyToClass.TabIndex = 7;
               this.btnApplyToClass.Text = "Marcar Prova";
               this.btnApplyToClass.UseVisualStyleBackColor = true;
               this.btnApplyToClass.Click += new System.EventHandler(this.btnApplyToClass_Click);
               // 
               // btnApplyNote
               // 
               this.btnApplyNote.Location = new System.Drawing.Point(316, 346);
               this.btnApplyNote.Name = "btnApplyNote";
               this.btnApplyNote.Size = new System.Drawing.Size(75, 23);
               this.btnApplyNote.TabIndex = 6;
               this.btnApplyNote.Text = "Aplicar Nota";
               this.btnApplyNote.UseVisualStyleBackColor = true;
               this.btnApplyNote.Click += new System.EventHandler(this.btnApplyNote_Click);
               // 
               // lblStudentNote
               // 
               this.lblStudentNote.AutoSize = true;
               this.lblStudentNote.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
               this.lblStudentNote.ForeColor = System.Drawing.SystemColors.ControlText;
               this.lblStudentNote.Location = new System.Drawing.Point(233, 313);
               this.lblStudentNote.Name = "lblStudentNote";
               this.lblStudentNote.Size = new System.Drawing.Size(45, 20);
               this.lblStudentNote.TabIndex = 5;
               this.lblStudentNote.Text = "Nota:";
               // 
               // cbxToApplyStudent
               // 
               this.cbxToApplyStudent.FormattingEnabled = true;
               this.cbxToApplyStudent.Location = new System.Drawing.Point(316, 285);
               this.cbxToApplyStudent.Name = "cbxToApplyStudent";
               this.cbxToApplyStudent.Size = new System.Drawing.Size(280, 23);
               this.cbxToApplyStudent.TabIndex = 4;
               // 
               // numStudentNote
               // 
               this.numStudentNote.DecimalPlaces = 1;
               this.numStudentNote.InterceptArrowKeys = false;
               this.numStudentNote.Location = new System.Drawing.Point(316, 315);
               this.numStudentNote.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
               this.numStudentNote.Name = "numStudentNote";
               this.numStudentNote.Size = new System.Drawing.Size(280, 23);
               this.numStudentNote.TabIndex = 3;
               // 
               // lblStudent
               // 
               this.lblStudent.AutoSize = true;
               this.lblStudent.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
               this.lblStudent.ForeColor = System.Drawing.SystemColors.ControlText;
               this.lblStudent.Location = new System.Drawing.Point(233, 284);
               this.lblStudent.Name = "lblStudent";
               this.lblStudent.Size = new System.Drawing.Size(77, 20);
               this.lblStudent.TabIndex = 2;
               this.lblStudent.Text = "Estudante:";
               // 
               // dgvToApplyTest
               // 
               this.dgvToApplyTest.AllowUserToAddRows = false;
               this.dgvToApplyTest.AllowUserToDeleteRows = false;
               this.dgvToApplyTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               this.dgvToApplyTest.Location = new System.Drawing.Point(233, 22);
               this.dgvToApplyTest.Name = "dgvToApplyTest";
               this.dgvToApplyTest.ReadOnly = true;
               this.dgvToApplyTest.RowTemplate.Height = 25;
               this.dgvToApplyTest.Size = new System.Drawing.Size(363, 249);
               this.dgvToApplyTest.TabIndex = 1;
               // 
               // dgvToApplyClass
               // 
               this.dgvToApplyClass.AllowUserToAddRows = false;
               this.dgvToApplyClass.AllowUserToDeleteRows = false;
               this.dgvToApplyClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               this.dgvToApplyClass.Location = new System.Drawing.Point(6, 22);
               this.dgvToApplyClass.Name = "dgvToApplyClass";
               this.dgvToApplyClass.ReadOnly = true;
               this.dgvToApplyClass.RowTemplate.Height = 25;
               this.dgvToApplyClass.Size = new System.Drawing.Size(221, 249);
               this.dgvToApplyClass.TabIndex = 0;
               this.dgvToApplyClass.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvToApplyClass_CellContentClick);
               // 
               // FormTestsTeacher
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(1084, 396);
               this.Controls.Add(this.gbxApplyTest);
               this.Controls.Add(this.gbxRegisterTests);
               this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
               this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
               this.MaximizeBox = false;
               this.MinimizeBox = false;
               this.Name = "FormTestsTeacher";
               this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
               this.Load += new System.EventHandler(this.FormTestsTeacher_Load);
               this.gbxRegisterTests.ResumeLayout(false);
               this.gbxRegisterTests.PerformLayout();
               ((System.ComponentModel.ISupportInitialize)(this.dgvRegisteredTests)).EndInit();
               this.gbxApplyTest.ResumeLayout(false);
               this.gbxApplyTest.PerformLayout();
               ((System.ComponentModel.ISupportInitialize)(this.numStudentNote)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.dgvToApplyTest)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.dgvToApplyClass)).EndInit();
               this.ResumeLayout(false);

		}

		#endregion

		private GroupBox gbxRegisterTests;
		private DataGridView dgvRegisteredTests;
		private Button btnAddTest;
		private Button btnRemoveTest;
		private TextBox txtTestName;
		private Label lblTestName;
		private Label lblTestDate;
		private DateTimePicker dtpTestDate;
          private GroupBox gbxApplyTest;
          private Label lblStudent;
          private DataGridView dgvToApplyTest;
          private DataGridView dgvToApplyClass;
          private NumericUpDown numStudentNote;
          private Button btnApplyToClass;
          private Button btnApplyNote;
          private Label lblStudentNote;
          private ComboBox cbxToApplyStudent;
     }
}