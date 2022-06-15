using Projeto_Windows_Forms.Classes;

namespace Projeto_Windows_Forms
{
	public partial class FormMenuTeachers : Form
	{
		public static List<Teacher> RegisteredTeachers = new List<Teacher>();
		public static List<Student> RegisteredStudent = new List<Student>();
		public static List<SchoolClasses> RegisteredClasses = new List<SchoolClasses>();
		public static Teacher LoggedTeacher = null!;
		public static Student LoggedStudent = null!;

		public FormMenuTeachers()
		{
			InitializeComponent();
			LoggedTeacher = null!;
			LoggedStudent = null!;
			Visible = false;

			RegisteredTeachers.Add(new Teacher("Ralf Lima", 20));
			RegisteredStudent.Add(new Student("João Mota", 17, 'M'));
			RegisteredStudent.Add(new Student("Henrique Lirio", 17, 'F'));
			RegisteredStudent.Add(new Student("William Padilha", 17, 'M'));
			RegisteredStudent.Add(new Student("Samuel Zubek", 17, 'M'));
			RegisteredStudent.Add(new Student("Victor Pimenta", 17, 'M'));
			RegisteredStudent.Add(new Student("Gabriel Ottequir", 17, 'M'));
			RegisteredStudent.Add(new Student("Wesley Sborch", 19, 'M'));
		}

		public void Login()
		{
			Visible = false;
			new FormLogin().ShowDialog();
			if (LoggedTeacher == null && LoggedStudent == null) Close();

			if (LoggedTeacher != null && LoggedStudent == null)
			{
				Visible = true;
			}
			if (LoggedTeacher == null && LoggedStudent != null)
			{
				new FormMenuStudent().ShowDialog();
				if (LoggedStudent != null) this.Close();
			}
		}

		public void DashStudents()
		{
			dgvDashboard.Rows.Clear();
			dgvDashboard.Columns.Clear();

			dgvDashboard.ColumnCount = 4;
			dgvDashboard.Columns[0].Name = "Nome";
			dgvDashboard.Columns[1].Name = "Idade";
			dgvDashboard.Columns[2].Name = "Gênero";
			dgvDashboard.Columns[3].Name = "Média";

			foreach (Student s in RegisteredStudent)
			{
				dgvDashboard.Rows.Add(new object[] { s.Name, s.Age, s.Gender, s.Avarage });
			}

			UpdateGrid(dgvDashboard);
		}
		private void UpdateGrid(DataGridView dgv)
		{
			for (int i = 0; i < dgv.ColumnCount; ++i)
			{
				dgv.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
				dgv.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
			}
		}

		private void FormMenu_Load(object sender, EventArgs e)
		{
			Login();
		}

		private void Logoff(object sender, EventArgs e)
		{
			LoggedTeacher = null!;
			LoggedStudent = null!;
			Visible = false;
			Login();
		}

		private void btnFormStudent_Click(object sender, EventArgs e)
		{
			new FormTeacherStudents().Show();
		}

		private void btnDashStudents_Click(object sender, EventArgs e)
		{
			DashStudents();
			UpdateGrid(dgvDashboard);
		}

		private void btnFormClasses_Click(object sender, EventArgs e)
		{
			new FormClassesTeacher().Show();
		}
	}
}