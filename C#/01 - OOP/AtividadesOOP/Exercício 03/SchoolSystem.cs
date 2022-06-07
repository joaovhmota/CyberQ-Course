using System;

namespace Exercício_03
{
	internal class SchoolSystem
	{
		// Attributes
		private double MinimumAvarage = 7.0;
		private List<Student> RegisteredStudents = new List<Student>();
		private int ApprovedStudents = 0;
		private int DisapprovedStudents = 0;
		private double StudentsAvarage = 0.00;
		private Student BestStudent = new Student();

		// Methods
		public void Start()
		{
			bool isRunning = true;
			do
			{
				Student s = new Student();
				string tempName = "";
				double tempNote;

				Console.Clear();
				Console.Write(" ・ Informe o nome do aluno: ");
				tempName = Console.ReadLine();
				if (tempName == "" || tempName.Length < 3) continue;
				s.Name = tempName;


				Console.Write(" ・ Informe a primeira nota do aluno: ");
				tempNote = Convert.ToDouble(Console.ReadLine());
				s.AddNote(tempNote);

				Console.Write(" ・ Informe a segunda nota do aluno: ");
				tempNote = Convert.ToDouble(Console.ReadLine());
				s.AddNote(tempNote);


				this.RegisteredStudents.Add(s);
				UpdateStudentSituation(s);
				UpdateStudentsAvarage();
				UpdateBestStudent();

				Console.Clear();
				Console.Write(" ・ Continuar? [S/N]: ");
				switch ( Console.ReadLine().ToUpper().ToCharArray()[0] )
				{
					case 'S':
						continue;
					case 'N':
						isRunning = false;
						break;
				}
			} while (isRunning);
			ShowStatsPanel();
		}

		private void UpdateStudentSituation(Student s)
		{
			if (s.Avarage >= MinimumAvarage)
			{
				s.Situation = "Aprovado";
				this.ApprovedStudents++;
			}
			else
			{
				s.Situation = "Reprovado";
				this.DisapprovedStudents++;
			}

		}

		private void UpdateStudentsAvarage()
		{
			for (int i = 0; i < RegisteredStudents.Count; i++)
				StudentsAvarage += RegisteredStudents[i].Avarage;
			StudentsAvarage /= ( RegisteredStudents.Count * 2 );
		}

		private void UpdateBestStudent()
		{
			for (int i = 0; i < RegisteredStudents.Count; i++)
				if (RegisteredStudents[i].Avarage > BestStudent.Avarage)
					BestStudent = RegisteredStudents[i];
		}

		private void ShowStatsPanel()
		{
			Console.Clear();
			Console.WriteLine(" ・ Resumo dos alunos:");
			Console.WriteLine($" ・ Total de alunos cadastrados: {ApprovedStudents + DisapprovedStudents} alunos");
			Console.WriteLine($" ・ Quantidade de alunos aprovados: {ApprovedStudents} alunos");
			Console.WriteLine($" ・ Quantidade de alunos reprovados: {DisapprovedStudents} alunos");
			Console.WriteLine($" ・ Média geral dos alunos: {StudentsAvarage:F2}");
			Console.WriteLine($" ・ O melhor aluno foi: {BestStudent.Name},  com a média de: {BestStudent.Avarage}");
			Console.WriteLine(" ・ Média dos alunos:");
			for (int i = 0; i < RegisteredStudents.Count; i++)
				Console.WriteLine($"\t ・ {RegisteredStudents[i].Name} - {RegisteredStudents[i].Avarage:F2}");
		}
	}
}
