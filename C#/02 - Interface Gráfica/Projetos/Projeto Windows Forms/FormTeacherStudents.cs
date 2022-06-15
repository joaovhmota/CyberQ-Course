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
	public partial class FormTeacherStudents : Form
	{
		public FormTeacherStudents()
		{
			InitializeComponent();
		}

		private void UpdateGrid(DataGridView dgv)
		{
			dgvAllStudents.Rows.Clear();
			dgvAllStudents.Columns.Clear();

			dgvAllStudents.ColumnCount = 4;
			dgvAllStudents.Columns[0].Name = "Nome";
			dgvAllStudents.Columns[1].Name = "Idade";
			dgvAllStudents.Columns[2].Name = "Gênero";
			dgvAllStudents.Columns[3].Name = "Média";

			for (int i = 0; i < dgv.ColumnCount; ++i)
			{
				dgv.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
				dgv.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
			}

			foreach (Student s in FormMenuTeachers.RegisteredStudent)
				dgvAllStudents.Rows.Add(new object[] { s.Name, s.Age, s.Gender, s.Avarage });
		}

		private void FormStudent_Load(object sender, EventArgs e)
		{
			numStudentAge.Controls[0].Visible = false;
			UpdateGrid(dgvAllStudents);
		}

		private void btnAddStudent_Click(object sender, EventArgs e)
		{
			if (txtStudentName.Text.Trim() == "") return;
			if (numStudentAge.Value <= 0) return;

			char gender = ' ';
			if (radioGenderM.Checked) gender = 'M';
			if (radioGenderF.Checked) gender = 'F';
			FormMenuTeachers.RegisteredStudent.Add(new Student(txtStudentName.Text.Trim(), (int) numStudentAge.Value, gender));

			UpdateGrid(dgvAllStudents);
		}

		private void btnRemoveStudent_Click(object sender, EventArgs e)
		{
			FormMenuTeachers.RegisteredStudent.RemoveAt(dgvAllStudents.CurrentCell.RowIndex);
			UpdateGrid(dgvAllStudents);
		}

		private void btnUpdateStudent_Click(object sender, EventArgs e)
		{
			char gender = ' ';
			if (radioGenderM.Checked) gender = 'M';
			if (radioGenderF.Checked) gender = 'F';

			FormMenuTeachers.RegisteredStudent[dgvAllStudents.CurrentCell.RowIndex].UpdateInfo(txtStudentName.Text, (int) numStudentAge.Value, gender);

			UpdateGrid(dgvAllStudents);
		}
	}
}
