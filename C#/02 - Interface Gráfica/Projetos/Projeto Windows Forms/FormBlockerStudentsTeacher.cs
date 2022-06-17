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
	public partial class FormBlockerStudentsTeacher : Form
	{
		public FormBlockerStudentsTeacher()
		{
			InitializeComponent();
		}

		private void ResizeGrid(DataGridView dgv)
		{
			for (int i = 0; i < dgv.ColumnCount; ++i)
			{
				dgv.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
				dgv.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
			}
		}

		private void UpdateDataGrid()
		{
			dgvBlockedAccounts.Rows.Clear();
			dgvBlockedAccounts.Columns.Clear();

			dgvBlockedAccounts.ColumnCount = 3	;
			dgvBlockedAccounts.Columns[0].Name = "Nome";
			dgvBlockedAccounts.Columns[1].Name = "Idade";
			dgvBlockedAccounts.Columns[2].Name = "Gênero";

			for (int i = 0; i < FormMenuTeachers.RegisteredStudent.Count; ++i)
			{ 
				if (FormMenuTeachers.RegisteredStudent[i].IsLocked)
					dgvBlockedAccounts.Rows.Add(new object[] {FormMenuTeachers.RegisteredStudent[i].Name, FormMenuTeachers.RegisteredStudent[i].Age, FormMenuTeachers.RegisteredStudent[i].Gender});
			}
		}

		private void FormBlockerStudentsTeacher_Load(object sender, EventArgs e)
		{
			UpdateDataGrid();
			ResizeGrid(dgvBlockedAccounts);
		}

		private void btnUnblockAccount_Click(object sender, EventArgs e)
		{
			if (dgvBlockedAccounts.CurrentCell.RowIndex < 0) return;

			for (int i = 0; i < FormMenuTeachers.RegisteredStudent.Count; ++i)
			{
				if (dgvBlockedAccounts.Rows[dgvBlockedAccounts.CurrentCell.RowIndex].Cells[0].Value.ToString() == FormMenuTeachers.RegisteredStudent[i].Name)
				{
					FormMenuTeachers.RegisteredStudent[i].Tries = 0;
					FormMenuTeachers.RegisteredStudent[i].IsLocked = false;
				}
			}

			UpdateDataGrid();
			ResizeGrid(dgvBlockedAccounts);
		}
	}
}
