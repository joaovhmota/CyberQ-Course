using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoSchool.Interfaces;

namespace ProjetoSchool.Classes
{
	internal class School : ISchoolSystem
	{
		public string SchoolName { get; set; }
		public List<SchoolClass> SchoolClasses { get; set; }
		public List<Student> RegisteredStudents { get; set; }
		public List<Teacher> RegisteredTeachers { get; set; }
		public List<Subject> RegisteredSubjects { get; set; }
		public List<Student> ApprovedStudents { get; set; }
		public List<Student> DisapprovedStudents { get; set; }
		public float SchoolAvarage { get; set; }
		public float SchoolMinimumAvarage { get; set; }

		public School(string SchoolName = "", float SchoolMinimumAvarage = 0)
		{
			this.SchoolName = SchoolName;
			this.SchoolClasses = new List<SchoolClass>();
			this.RegisteredStudents = new List<Student>();
			this.RegisteredTeachers = new List<Teacher>();
			this.ApprovedStudents = new List<Student>();
			this.DisapprovedStudents = new List<Student>();
			this.SchoolAvarage = 0.0f;
			this.SchoolMinimumAvarage = SchoolMinimumAvarage;
		}

		public void Update()
		{

		}

		public void Update(Student student)
		{
			// Remove o aluno das classes
			for (int i = 0; i < SchoolClasses.Count; i++)
				for (int j = 0; j < SchoolClasses[i].ClassStudents.Count; j++)
					if (student.ID == SchoolClasses[i].ClassStudents[j].ID)
						SchoolClasses[i].ClassStudents.Remove(SchoolClasses[i].ClassStudents[j]);

			// Remove o aluno da escola
			for (int i = 0; i < RegisteredStudents.Count; i++)
				if (student.ID == RegisteredStudents[i].ID)
					RegisteredStudents.Remove(RegisteredStudents[i]);

			Update();
		}

		public void Update(Subject subject)
		{
			// Remove a matéria do professor
			for (int i = 0; i < RegisteredTeachers.Count; i++)
				if (RegisteredTeachers[i].Subject == subject)
					RegisteredTeachers[i].Subject = null;
			Update();
		}

		public void ShowStats()
		{

		}

		public void Search()
		{

		}

		public void Add(Student student)
		{
			this.RegisteredStudents.Add(student);
		}

		public void Remove(Student student)
		{
			string removeID;

			ListStudents();
			Console.Write(" ・ Digite o ID que desejas deletar: ");
			removeID = Console.ReadLine()!.Trim();
			if (removeID == "") return;

			for (int i = 0; i < RegisteredStudents.Count; i++)
				if (RegisteredStudents[i].ID == removeID)
				{
					RegisteredStudents.Remove(RegisteredStudents[i]);
					break;
				}
			Update(student);
		}

		public void Add(Teacher teacher)
		{
			this.RegisteredTeachers.Add(teacher);
		}

		public void Remove(Teacher teacher)
		{
			string removeID;

			ListTeachers();
			Console.Write("Digite o ID que desejas deletar: ");
			removeID = Console.ReadLine()!.Trim();
			if (removeID == "") return;

			for (int i = 0; i < RegisteredTeachers.Count; i++)
				if (RegisteredTeachers[i].ID == removeID)
				{
					RegisteredTeachers.Remove(RegisteredTeachers[i]);
					break;
				}
		}

		public void Add(SchoolClass schoolClass)
		{
			this.SchoolClasses.Add(schoolClass);
		}

		public void Remove(SchoolClass schoolClass)
		{
			string removeID;

			ListClasses();
			Console.Write("Digite o ID que desejas deletar: ");
			removeID = Console.ReadLine()!.Trim();
			if (removeID == "") return;

			for (int i = 0; i < SchoolClasses.Count; i++)
				if (SchoolClasses[i].ID == removeID)
				{
					SchoolClasses.Remove(SchoolClasses[i]);
					break;
				}
		}

		public void Add(Subject subject)
		{
			this.RegisteredSubjects.Add(subject);
		}

		public void Remove(Subject subject)
		{
			string removeID;

			ListSubjects();
			Console.Write("Digite o ID que desejas deletar: ");
			removeID = Console.ReadLine()!.Trim();
			if (removeID == "") return;

			for (int i = 0; i < RegisteredSubjects.Count; i++)
				if (RegisteredSubjects[i].ID == removeID)
				{
					RegisteredSubjects.Remove(RegisteredSubjects[i]);
					break;
				}
			Update(subject);
		}

		public void ListStudents()
		{
			Console.WriteLine();
			for (int i = 0; i < this.RegisteredStudents.Count; i++)
			{
				Console.WriteLine($" ・ ID: {RegisteredStudents[i].ID}, Nome: {RegisteredStudents[i].Name}, Média: {RegisteredStudents[i].StudentAvarage}");
				Console.WriteLine($"   ・ Total de Advertências: {RegisteredStudents[i].WarningLists.Count}");
				Console.WriteLine($"   ・ Total de Suspenções: {RegisteredStudents[i].SuspensionList.Count}");
				Console.WriteLine();
			}
		}

		public void ListTeachers()
		{
			for (int i = 0; i < this.RegisteredTeachers.Count; i++)
			{
				Console.WriteLine($" ・ ID: {RegisteredTeachers[i].ID}, Nome: {RegisteredTeachers[i].Name}");
				Console.WriteLine($"   ・ Matéria: {RegisteredTeachers[i].Subject.SubjectName}");
				Console.WriteLine($"   ・ Salário: {RegisteredTeachers[i].Salary:C2}");
			}
		}

		public void ListSubjects()
		{
			for (int i = 0; i < this.RegisteredSubjects.Count; i++)
			{
				Console.WriteLine($" ・ ID:{RegisteredSubjects[i].ID}, Nome: {RegisteredSubjects[i].SubjectName}");
			}
		}

		public void ListClasses()
		{
			for (int i = 0; i < this.SchoolClasses.Count; i++)
			{
				Console.WriteLine($" ・ ID:{SchoolClasses[i].ID}, Nome: {SchoolClasses[i].ClassName}");
				Console.WriteLine($"   ・ Total de alunos: {SchoolClasses[i].ClassStudents.Count}");
				Console.WriteLine($"   ・ Média da sala: {SchoolClasses[i].ClassAvarage}");
			}
		}
	}
}
