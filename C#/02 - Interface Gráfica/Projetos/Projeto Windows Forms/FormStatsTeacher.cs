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
	public partial class FormStatsTeacher : Form
	{
		public FormStatsTeacher()
		{
			InitializeComponent();
		}

		#region Custom Methods

		private void ConfigGrid(DataGridView dgv) {
			for ( int i = 0; i < dgv.ColumnCount; ++i ) {
				dgv.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
				dgv.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
               }
          }

		private void UpdateAllTestsGrid() {
			dgvAllTests.Columns.Clear();
			dgvAllTests.Rows.Clear();

			dgvAllTests.ColumnCount = 2;
			dgvAllTests.Columns[0].Name = "Prova";
			dgvAllTests.Columns[1].Name = "Data";

			foreach ( Tests t in FormMenuTeachers.RegisteredTests )
				dgvAllTests.Rows.Add(new object[] {t.Title, t.AppliedDate.ToString()});
			
			ConfigGrid(dgvAllTests);
          }

		#endregion

		private void FormStatsTeacher_Load(object sender, EventArgs e) {
			UpdateAllTestsGrid();

               #region Other Stats
               UpdateAllTestsGrid();
			double amountMan = 0,
			       amountWoman = 0,
			       above7 = 0,
			       below7 = 0;

			foreach (Student s in FormMenuTeachers.RegisteredStudent) {
				if ( s.Gender == 'M' ) ++amountMan;
				else ++amountWoman;

				if ( s.Avarage >= 7 ) ++above7;
				else ++below7;
               }


			lblBoys.Text = $"Quantidade de meninos: {amountMan}";
			lblGirls.Text = $"Quantidade de meninas: {amountWoman}";
			lblAbove7.Text = $"Alunos com média acima de 7: {above7} ({(above7 / FormMenuTeachers.RegisteredStudent.Count):P2})";
			lblBelow7.Text = $"Alunos com média abaixo de 7: {below7} ({(below7 / FormMenuTeachers.RegisteredStudent.Count):P2})";
               #endregion
          }

          private void dgvAllTests_CellContentClick(object sender, DataGridViewCellEventArgs e) {
			dgvResult.Rows.Clear();
			dgvResult.Columns.Clear();

			dgvResult.ColumnCount = 2;
			dgvResult.Columns[0].Name = "Turma";
			dgvResult.Columns[1].Name = "Média";

			int testIndex = dgvAllTests.CurrentCell.RowIndex;
			float result = 0.0f;

			for ( int i = 0; i < FormMenuTeachers.RegisteredClasses.Count; ++i ) {
				for (int j = 0; j < FormMenuTeachers.RegisteredClasses[i].Students.Count; ++j ) {
					for (int k = 0; k < FormMenuTeachers.RegisteredClasses[i].Students[j].Notes.Count; ++k ) {
						if (FormMenuTeachers.RegisteredClasses[i].Students[j].Notes[k].Test.Title == dgvAllTests.Rows[dgvAllTests.CurrentCell.RowIndex].Cells[0].Value.ToString()) {
							result += FormMenuTeachers.RegisteredClasses[i].Students[j].Notes[k].Result;
                              }
                         }
                    }
				result /= FormMenuTeachers.RegisteredClasses[i].Students.Count;
				dgvResult.Rows.Add(new object[] {FormMenuTeachers.RegisteredClasses[i].Name, result});
				result = 0.0f;
               }

			ConfigGrid(dgvResult);
          }
     }
}
