#nullable enable

using Projeto_Windows_Forms.Classes;

namespace Projeto_Windows_Forms
{
	public partial class FormMenuTeachers : Form
	{
		public static List<Teacher> RegisteredTeachers = new List<Teacher>();
		public static List<Student> RegisteredStudent = new List<Student>();
		public static List<SchoolClasses> RegisteredClasses = new List<SchoolClasses>();
		public static List<Tests> RegisteredTests = new List<Tests>();
		public static Teacher? LoggedTeacher = null;
		public static Student? LoggedStudent = null;

		public FormMenuTeachers()
		{
			InitializeComponent();
			LoggedTeacher = null!;
			LoggedStudent = null!;
			Visible = false;

			RegisteredTeachers.Add(new Teacher("Ralf Lima", 32));
			RegisteredStudent.Add(new Student("João Mota", 17, 'M'));
			RegisteredStudent.Add(new Student("Henrique Lirio", 17, 'F'));
			RegisteredStudent.Add(new Student("William Padilha", 20, 'M'));
			RegisteredStudent.Add(new Student("Samuel Zubek", 17, 'M'));
			RegisteredStudent.Add(new Student("Victor Pimenta", 17, 'M'));
			RegisteredStudent.Add(new Student("Gabriel Ottequir", 19, 'M'));
			RegisteredStudent.Add(new Student("Wesley Sborch", 19, 'M'));

			RegisteredClasses.Add(new SchoolClasses("3ãoA"));
			RegisteredClasses.Add(new SchoolClasses("3ãoB"));
			RegisteredClasses.Add(new SchoolClasses("3ãoC"));
			RegisteredClasses.Add(new SchoolClasses("3ãoD"));


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

		public void Login()
		{
			Visible = false;
			new FormLogin().ShowDialog();
			if (LoggedTeacher == null && LoggedStudent == null) Close();

			if (LoggedTeacher != null && LoggedStudent == null)
			{
				Visible = true;
			}
			else if (LoggedTeacher == null && LoggedStudent != null)
			{
				new FormMenuStudent().ShowDialog();
				if (LoggedStudent != null) Close();
			}
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
			do
			{
				Login();
				LoggedStudent = new(null, 0, ' ');
			} while (LoggedStudent == null && LoggedTeacher == null);
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

		private void btnFormClasses_Click(object sender, EventArgs e)
		{
			new FormClassesTeacher().Show();
		}

		private void btnBlockedAccounts_Click(object sender, EventArgs e)
		{
			new FormBlockerStudentsTeacher().Show();
		}

		private void btnFormTests_Click(object sender, EventArgs e)
		{
			new FormTestsTeacher().Show();
		}

		private void btnDashClasses_Click(object sender, EventArgs e)
		{
			dgvDashboard.Rows.Clear();

			dgvDashboard.ColumnCount = 2;
			dgvDashboard.Columns[0].Name = "Nome";
			dgvDashboard.Columns[1].Name = "Média";

			UpdateGrid(dgvDashboard);

			for (int i = 0; i < FormMenuTeachers.RegisteredClasses.Count; ++i)
			{
				dgvDashboard.Rows.Add(new object[] {FormMenuTeachers.RegisteredClasses[i].Name, FormMenuTeachers.RegisteredClasses[i].ClassAvarage});
			}
		}

		private void btnDashTests_Click(object sender, EventArgs e)
		{
			dgvDashboard.Rows.Clear();

			dgvDashboard.ColumnCount = 2;
			dgvDashboard.Columns[0].Name = "Título";
			dgvDashboard.Columns[1].Name = "Data de Aplicação";

			for (int i = 0; i < FormMenuTeachers.RegisteredTests.Count; ++i)
				dgvDashboard.Rows.Add(new object[] { FormMenuTeachers.RegisteredTests[i].Title, FormMenuTeachers.RegisteredTests[i].AppliedDate.ToString() });

			UpdateGrid(dgvDashboard);
		}

		private void btnSchoolStats_Click(object sender, EventArgs e)
		{
			new FormStatsTeacher().Show();
		}
	}
}