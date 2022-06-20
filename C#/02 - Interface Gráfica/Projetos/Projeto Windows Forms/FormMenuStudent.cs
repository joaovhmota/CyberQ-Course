using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Windows_Forms
{
	public partial class FormMenuStudent : Form
	{
		public FormMenuStudent()
		{
			InitializeComponent();
		}

		public void ResizeGrid(DataGridView dgv)
		{
			for (int i = 0; i < dgv.ColumnCount; ++i)
			{
				dgv.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
				dgv.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
			}
		}

		private void FormMenuStudent_Load(object sender, EventArgs e)
		{
			FormMenuTeachers.LoggedTeacher = null!;


			dgvStudentResults.Rows.Clear();
			dgvStudentResults.Columns.Clear();

			dgvStudentResults.ColumnCount = 3;
			dgvStudentResults.Columns[0].Name = "Prova";
			dgvStudentResults.Columns[1].Name = "Nota";
			dgvStudentResults.Columns[2].Name = "Data";

			for (int i = 0; i < FormMenuTeachers.LoggedStudent.Notes.Count; ++i)
			{
				dgvStudentResults.Rows.Add(new object[] {FormMenuTeachers.LoggedStudent.Notes[i].Test.Title, FormMenuTeachers.LoggedStudent.Notes[i].Result, FormMenuTeachers.LoggedStudent.Notes[i].Test.AppliedDate.ToString()});
			}

			ResizeGrid(dgvStudentResults);
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			dgvStudentResults.Rows.Clear();
			dgvStudentResults.Columns.Clear();

			dgvStudentResults.ColumnCount = 3;
			dgvStudentResults.Columns[0].Name = "Prova";
			dgvStudentResults.Columns[1].Name = "Nota";
			dgvStudentResults.Columns[2].Name = "Data";

			for (int i = 0; i < FormMenuTeachers.LoggedStudent.Notes.Count; ++i)
			{
				dgvStudentResults.Rows.Add(new object[] {FormMenuTeachers.LoggedStudent.Notes[i].Test.Title, FormMenuTeachers.LoggedStudent.Notes[i].Result, FormMenuTeachers.LoggedStudent.Notes[i].Test.AppliedDate.ToString()});
			}
			ResizeGrid(dgvStudentResults);
		}

		private void btnLogoff_Click(object sender, EventArgs e)
		{
			FormMenuTeachers.LoggedStudent = null!;
			FormMenuTeachers.LoggedTeacher = null!;
			FormMenuTeachers.HasClosedViaX = true;
			Dispose();
		}
	}
}
