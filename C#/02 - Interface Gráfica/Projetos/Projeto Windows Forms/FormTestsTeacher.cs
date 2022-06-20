#nullable enable
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto_Windows_Forms.Classes;

namespace Projeto_Windows_Forms
{
     public partial class FormTestsTeacher : Form {
		public FormTestsTeacher()
		{
			InitializeComponent();
		}

		private void FormTestsTeacher_Load(object sender, EventArgs e)
		{
			UpdateAllTestsGrid();
			UpdateToApplyClassGrid();
		}

		private void UpdateToApplyClassGrid() {
			dgvToApplyClass.Rows.Clear();
			dgvToApplyClass.Columns.Clear();

			dgvToApplyClass.ColumnCount = 1;
			dgvToApplyClass.Columns[0].Name = "Turma";

			for (int i = 0; i < FormMenuTeachers.RegisteredClasses.Count; ++i ) {
				dgvToApplyClass.Rows.Add(new object[] {FormMenuTeachers.RegisteredClasses[i].Name});
			}

			UpdateDataGridView(dgvToApplyClass);
          }

		private void UpdateAllTestsGrid()
		{
               #region Cadastrar Provas
               dgvRegisteredTests.Rows.Clear();
			dgvRegisteredTests.Columns.Clear();

			dgvRegisteredTests.ColumnCount = 2;
			dgvRegisteredTests.Columns[0].Name = "Prova";
			dgvRegisteredTests.Columns[1].Name = "Data de aplicação";

			for (int i = 0; i < FormMenuTeachers.RegisteredTests.Count; ++i)
			{
				dgvRegisteredTests.Rows.Add(new object[] {FormMenuTeachers.RegisteredTests[i].Title, FormMenuTeachers.RegisteredTests[i].AppliedDate.ToString() });
			}

               #endregion

               #region Adicionar Provas
               dgvToApplyTest.Rows.Clear();
			dgvToApplyTest.Columns.Clear();

			dgvToApplyTest.ColumnCount = 2;
			dgvToApplyTest.Columns[0].Name = "Prova";
			dgvToApplyTest.Columns[1].Name = "Data de aplicação";

			for (int i = 0; i < FormMenuTeachers.RegisteredTests.Count; ++i)
			{
				dgvToApplyTest.Rows.Add(new object[] {FormMenuTeachers.RegisteredTests[i].Title, FormMenuTeachers.RegisteredTests[i].AppliedDate.ToString() });
			}

               #endregion

               UpdateDataGridView(dgvRegisteredTests);
               UpdateDataGridView(dgvToApplyTest);
		}

		private void UpdateDataGridView(DataGridView dgv)
		{
			for (int i = 0; i < dgv.ColumnCount; ++i)
			{
				dgv.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
				dgv.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
			}
		}

		private void btnAddTest_Click(object sender, EventArgs e)
		{
			bool hasTest = false;
			if (txtTestName.Text.Trim() == "") return;

			FormMenuTeachers.RegisteredTests.ForEach( t => {
				if (t.Title == txtTestName.Text.Trim()) hasTest = true;
			});

			if (!hasTest)
				FormMenuTeachers.RegisteredTests.Add(new Tests(txtTestName.Text.Trim(), dtpTestDate.Value));
			UpdateAllTestsGrid();
		}

          private void btnRemoveTest_Click(object sender, EventArgs e) {
			FormMenuTeachers.RegisteredTests.RemoveAt(dgvRegisteredTests.CurrentCell.RowIndex);
			UpdateAllTestsGrid();
          }

		private void UpdateCbxStudents() {
			cbxToApplyStudent.Items.Clear();

			for (int i = 0; i < FormMenuTeachers.RegisteredClasses[dgvToApplyClass.CurrentCell.RowIndex].Students.Count; ++i ) {
				cbxToApplyStudent.Items.Add(FormMenuTeachers.RegisteredClasses[dgvToApplyClass.CurrentCell.RowIndex].Students[i].ToString());
               }
          }

          private void btnApplyToClass_Click(object sender, EventArgs e) {
               try {
                    if ( FormMenuTeachers.RegisteredClasses[dgvToApplyClass.CurrentCell.RowIndex].Tests.Contains(FormMenuTeachers.RegisteredTests[dgvToApplyTest.CurrentCell.RowIndex]) ) return;

                    FormMenuTeachers.RegisteredClasses[dgvToApplyClass.CurrentCell.RowIndex].Tests.Add(
					FormMenuTeachers.RegisteredTests[dgvToApplyTest.CurrentCell.RowIndex]	
				);
                    
                    MessageBox.Show("Prova marcada!", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    UpdateCbxStudents();
               } catch (Exception ex) { }
          }

          private void dgvToApplyClass_CellContentClick(object sender, DataGridViewCellEventArgs e) {
			UpdateCbxStudents();
          }

          private void btnApplyNote_Click(object sender, EventArgs e) {
			FormMenuTeachers.RegisteredClasses[dgvToApplyClass.CurrentCell.RowIndex].Students[cbxToApplyStudent.SelectedIndex].AddResult(new TestResult(
				FormMenuTeachers.RegisteredTests[dgvToApplyTest.CurrentCell.RowIndex], (float) numStudentNote.Value
			));
			FormMenuTeachers.RegisteredClasses[dgvToApplyClass.CurrentCell.RowIndex].UpdateAvarage();
			MessageBox.Show("Nota adicionada!", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          }
     }
}
