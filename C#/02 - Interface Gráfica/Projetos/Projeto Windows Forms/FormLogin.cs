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
	public partial class FormLogin : Form
	{
		public FormLogin()
		{
			InitializeComponent();
		}

		private void ckbShowPass_CheckedChanged(object sender, EventArgs e)
		{
			if (ckbShowPass.Checked)
				txtPassword.PasswordChar = '\0';
			else
				txtPassword.PasswordChar = '•';
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			for (int i = 0; i < FormMenuTeachers.RegisteredTeachers.Count; ++i)
			{
				if (txtLogin.Text == FormMenuTeachers.RegisteredTeachers[i].Login)
					if (txtPassword.Text == FormMenuTeachers.RegisteredTeachers[i].Password)
					{
						FormMenuTeachers.LoggedTeacher = FormMenuTeachers.RegisteredTeachers[i];
						Close();
					}
			}

			for (int i = 0; i < FormMenuTeachers.RegisteredStudent.Count; ++i)
			{
				if (txtLogin.Text == FormMenuTeachers.RegisteredStudent[i].Login)
				{
					if (!FormMenuTeachers.RegisteredStudent[i].IsLocked)
					{
						if (txtPassword.Text == FormMenuTeachers.RegisteredStudent[i].Password)
						{
							FormMenuTeachers.LoggedStudent = FormMenuTeachers.RegisteredStudent[i];
							FormMenuTeachers.LoggedTeacher = null!;
							Close();
						}
						else
						{
							FormMenuTeachers.RegisteredStudent[i].Tries++;
							if (FormMenuTeachers.RegisteredStudent[i].Tries == 3)
								FormMenuTeachers.RegisteredStudent[i].IsLocked = true;
						}
					}
					else
					{
						MessageBox.Show($"A conta do aluno {FormMenuTeachers.RegisteredStudent[i].Name} foi bloqueada", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
				}
			}
		}
     }
}
