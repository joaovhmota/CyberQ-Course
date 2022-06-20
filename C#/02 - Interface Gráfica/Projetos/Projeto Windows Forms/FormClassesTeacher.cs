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
	public partial class FormClassesTeacher : Form
	{
		public FormClassesTeacher()
		{
			InitializeComponent();
		}

		private void FormClassesTeacher_Load(object sender, EventArgs e)
		{
			UpdateDgvAllClasses();
			UpdateClassesComboBox();
		}

		private void UpdateClassesComboBox()
		{
			cbxSelectedSchoolClass.Items.Clear();

			for (int i = 0; i < FormMenuTeachers.RegisteredClasses.Count; ++i)
				cbxSelectedSchoolClass.Items.Add(FormMenuTeachers.RegisteredClasses[i].Name);
		}

		private void UpdateDgvNotInClass()
		{
			dgvStudentsNotInClass.Rows.Clear();

			dgvStudentsNotInClass.ColumnCount = 4;
			dgvStudentsNotInClass.Columns[0].Name = "Nome";
			dgvStudentsNotInClass.Columns[1].Name = "Idade";
			dgvStudentsNotInClass.Columns[2].Name = "Gênero";
			dgvStudentsNotInClass.Columns[3].Name = "Média";

			for (int i = 0; i < FormMenuTeachers.RegisteredStudent.Count; ++i)
			{
				if (!FormMenuTeachers.RegisteredStudent[i].IsInClass)
					dgvStudentsNotInClass.Rows.Add(new object[] {
						FormMenuTeachers.RegisteredStudent[i].Name, 
						FormMenuTeachers.RegisteredStudent[i].Age, 
						FormMenuTeachers.RegisteredStudent[i].Gender, 
						FormMenuTeachers.RegisteredStudent[i].Avarage, 
					});
			}
		}

		private void ResizeGrid(DataGridView dgv)
		{
			for (int i = 0; i < dgv.ColumnCount; ++i)
			{
				dgv.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
				dgv.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
			}
		}

		private void UpdateDgvClassStudents()
		{
			dgvClassStudents.Rows.Clear();

			dgvClassStudents.ColumnCount = 4;
			dgvClassStudents.Columns[0].Name = "Nome";
			dgvClassStudents.Columns[1].Name = "Idade";
			dgvClassStudents.Columns[2].Name = "Gênero";
			dgvClassStudents.Columns[3].Name = "Média";

			for (int i = 0; i < FormMenuTeachers.RegisteredClasses[cbxSelectedSchoolClass.SelectedIndex].Students.Count; ++i)
			{
				dgvClassStudents.Rows.Add(new object[] {
					FormMenuTeachers.RegisteredClasses[cbxSelectedSchoolClass.SelectedIndex].Students[i].Name,
					FormMenuTeachers.RegisteredClasses[cbxSelectedSchoolClass.SelectedIndex].Students[i].Age,
					FormMenuTeachers.RegisteredClasses[cbxSelectedSchoolClass.SelectedIndex].Students[i].Gender,
					FormMenuTeachers.RegisteredClasses[cbxSelectedSchoolClass.SelectedIndex].Students[i].Avarage
				});
			}
		}

		private void UpdateDgvAllClasses()
		{
			dgvAllClasses.Rows.Clear();

			dgvAllClasses.ColumnCount = 2;
			dgvAllClasses.Columns[0].Name = "Nome";
			dgvAllClasses.Columns[1].Name = "Média";

			for (int i = 0; i < FormMenuTeachers.RegisteredClasses.Count; ++i)
			{
				dgvAllClasses.Rows.Add(new object[] {FormMenuTeachers.RegisteredClasses[i].Name, FormMenuTeachers.RegisteredClasses[i].ClassAvarage});
			}

			ResizeGrid(dgvAllClasses);
		}

		private void btnAddClass_Click(object sender, EventArgs e)
		{
			if (txtClassName.Text.Trim() == "") return;

			for (int i = 0; i < FormMenuTeachers.RegisteredClasses.Count; ++i)
				if (FormMenuTeachers.RegisteredClasses[i].Name == txtClassName.Text.Trim()) return;

			FormMenuTeachers.RegisteredClasses.Add(new SchoolClasses(txtClassName.Text.Trim()));

			UpdateDgvAllClasses();
			UpdateClassesComboBox();
		}

		private void btnRemoveClass_Click(object sender, EventArgs e)
		{
			try {
				if ( dgvAllClasses.CurrentCell.RowIndex < 0 || FormMenuTeachers.RegisteredClasses[dgvAllClasses.CurrentCell.RowIndex].Students.Count > 0 ) return;

				FormMenuTeachers.RegisteredClasses.RemoveAt(dgvAllClasses.CurrentCell.RowIndex);
				UpdateDgvAllClasses();
				UpdateClassesComboBox();

			} catch ( Exception ex ) { }
		}

		private void btnUpdateClass_Click(object sender, EventArgs e)
		{
			if (dgvAllClasses.CurrentCell.RowIndex < 0) return;
			FormMenuTeachers.RegisteredClasses[dgvAllClasses.CurrentCell.RowIndex].Name = txtClassName.Text;

			UpdateDgvAllClasses();
			UpdateClassesComboBox();
		}

		private void cbxSelectedSchoolClass_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateDgvClassStudents();
			UpdateDgvNotInClass();
			ResizeGrid(dgvClassStudents);
			ResizeGrid(dgvStudentsNotInClass);
		}

		private void btnAddStudentToClass_Click(object sender, EventArgs e)
		{
			try {

				for ( int i = 0; i < FormMenuTeachers.RegisteredStudent.Count; ++i ) {
					if ( FormMenuTeachers.RegisteredStudent[i].Name == dgvStudentsNotInClass.Rows[dgvStudentsNotInClass.CurrentCell.RowIndex].Cells[0].Value.ToString() ) {
						FormMenuTeachers.RegisteredStudent[i].IsInClass = true;
						FormMenuTeachers.RegisteredClasses[cbxSelectedSchoolClass.SelectedIndex].AddStudent(FormMenuTeachers.RegisteredStudent[i]);
					}
				}

				UpdateDgvClassStudents();
				UpdateDgvNotInClass();
				ResizeGrid(dgvClassStudents);
				ResizeGrid(dgvStudentsNotInClass);
			} catch ( Exception ex ) { }
		}

		private void btnRemoveStudentFromClass_Click(object sender, EventArgs e)
		{
			for (int i = 0; i < FormMenuTeachers.RegisteredStudent.Count; ++i)
			{
				if (FormMenuTeachers.RegisteredStudent[i].Name == dgvClassStudents.Rows[dgvClassStudents.CurrentCell.RowIndex].Cells[0].Value.ToString())
				{
					FormMenuTeachers.RegisteredStudent[i].IsInClass = false;
					FormMenuTeachers.RegisteredClasses[cbxSelectedSchoolClass.SelectedIndex].Students.Remove(FormMenuTeachers.RegisteredStudent[i]);
					FormMenuTeachers.RegisteredClasses[cbxSelectedSchoolClass.SelectedIndex].UpdateAvarage();
				}
			}

			UpdateDgvClassStudents();
			UpdateDgvNotInClass();
			ResizeGrid(dgvClassStudents);
			ResizeGrid(dgvStudentsNotInClass);
		}
	}
}
