using System;

namespace ProjetoSchool.Classes
{
	internal class ProgramSystem
	{
		private void Print(string str = null) => Console.Write( (str != null) ? $"{str}" : "");
		private void BallPrint(string str = null) => Console.Write( (str != null) ? $" ・ {str}" : "");
		private void BallPrintLn(string str = null) => Console.WriteLine((str != null) ? $" ・ {str}" : "");
		private string WihBall(string str = null) => ( (str != null) ? $" ・ {str}" : "");
		
		private School theSchool;
		private ConsoleKey pressedKey;
		private bool isRunning = true;
		private string tempString;
		private float tempFloat;
		private int menuOPT = 1, executeSection;

		// For Students
		private string tempCPF;
		private string tempName;
		private int tempAge;

		public void Init()
		{
			if (theSchool == null) CreateSchool();
			while (isRunning)
			{
				menuOPT = 1;
				SchoolMenu();

				switch (menuOPT)
				{
					case 1: StudentSection(); break;
					case 2: TeacherSection(); break;
					case 3: ClassSection(); break;
					case 4: SubjectSection(); break;
					case 5: StatisticsSection(); break;
				}
			}
			Console.Clear();
		}

		public void CreateSchool()
		{
			do
			{
				try
				{
					Console.Clear();
			
					Console.ForegroundColor = ConsoleColor.White;
					Console.SetCursorPosition(1, 1); BallPrintLn("Criação da escola");
			
					Console.SetCursorPosition(1, 2); BallPrint("Nome: ");
					Console.SetCursorPosition(1, 3); BallPrint("Média Minima: ");
			
					Console.ForegroundColor = ConsoleColor.Yellow;
					Console.SetCursorPosition(WihBall("Nome: ").Length + 1, 2); tempString = Console.ReadLine()!;
					if (tempString == "") continue;
			
					Console.SetCursorPosition(WihBall("Média Minima: ").Length + 1, 3); tempFloat = Convert.ToSingle(Console.ReadLine()!);
					if (tempFloat <= 0) continue;
			
					theSchool = new School(tempString, tempFloat);
					break;
				} catch (Exception ex) { }
			} while (true);
		}

		public void SchoolMenu()
		{
			do
			{
				Console.Clear();
				Console.ForegroundColor = ConsoleColor.White;
				Console.SetCursorPosition(1, 1); BallPrintLn($"Menu de administração da escola: ");
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.SetCursorPosition($" ・ Menu de administração da escola: ".Length + 1, 1); Print(theSchool.SchoolName);
				Console.ForegroundColor = ConsoleColor.White;

				Console.SetCursorPosition(1, 2); BallPrintLn("1 - Alunos       " + (menuOPT == 1 ? "<" : null));
				Console.SetCursorPosition(1, 3); BallPrintLn("2 - Professores  " + (menuOPT == 2 ? "<" : null));
				Console.SetCursorPosition(1, 4); BallPrintLn("3 - Turmas       " + (menuOPT == 3 ? "<" : null));
				Console.SetCursorPosition(1, 5); BallPrintLn("4 - Matérias     " + (menuOPT == 4 ? "<" : null));
				Console.SetCursorPosition(1, 6); BallPrintLn("5 - Estatísticas " + (menuOPT == 5 ? "<" : null));
				Console.SetCursorPosition(1, 7); BallPrintLn("6 - Finalizar    " + (menuOPT == 6 ? "<" : null));

				if (ChangePointer(1, 6)) break;
			} while (true);
		}

		public void StudentSection()
		{
			menuOPT = 1;
			do
			{
				Console.Clear();
				Console.ForegroundColor = ConsoleColor.White;
				Console.SetCursorPosition(1, 1); BallPrintLn($"Menu de administração de: ");
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.SetCursorPosition($" ・ Menu de administração de: ".Length + 1, 1); Print("Alunos");
				Console.ForegroundColor = ConsoleColor.White;

				Console.SetCursorPosition(1, 2); BallPrintLn("1 - Cadastrar aluno " + (menuOPT == 1 ? "<" : null));
				Console.SetCursorPosition(1, 3); BallPrintLn("2 - Remover aluno   " + (menuOPT == 2 ? "<" : null));
				Console.SetCursorPosition(1, 4); BallPrintLn("3 - Finalizar       " + (menuOPT == 3 ? "<" : null));

				if (!ChangePointer(1, 3)) continue;
				if (menuOPT == 3) break;

				if (menuOPT == 1)
				{
					try
					{
						Console.SetCursorPosition(1, 8); BallPrint("Cadastro de aluno");
						Console.SetCursorPosition(1, 9); BallPrint("CPF: ");
						Console.SetCursorPosition(1, 10); BallPrint("Nome: ");
						Console.SetCursorPosition(1, 11); BallPrint("Idade: ");

						Console.ForegroundColor = ConsoleColor.Yellow;
						Console.SetCursorPosition(WihBall("CPF: ").Length + 1, 9); tempCPF = Console.ReadLine()!.Trim();
						if (tempCPF.Length != 11) continue;

						Console.SetCursorPosition(WihBall("Nome: ").Length + 1, 10); tempName = Console.ReadLine()!.Trim();
						if (tempName.Length < 3 || tempName == "") continue;

						Console.SetCursorPosition(WihBall("Idade: ").Length + 1, 11); tempAge = Convert.ToInt32(Console.ReadLine()!.Trim());
						if (tempAge < 0) continue;

						Console.ForegroundColor = ConsoleColor.White;
					} catch (Exception ex) { }

					theSchool.Add(new Student(tempCPF, tempName, tempAge));
				}

				if (menuOPT == 2)
				{
					theSchool.Remove(new Student("","",0));
				}

			} while (true);
		}

		public void TeacherSection()
		{
			menuOPT = 1;
			do
			{
				Console.Clear();
				Console.ForegroundColor = ConsoleColor.White;
				Console.SetCursorPosition(1, 1); BallPrintLn($"Menu de administração de: ");
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.SetCursorPosition($" ・ Menu de administração de: ".Length + 1, 1); Print("Professores");
				Console.ForegroundColor = ConsoleColor.White;

				Console.SetCursorPosition(1, 2); BallPrintLn("1 - Cadastrar Professor " + (menuOPT == 1 ? "<" : null));
				Console.SetCursorPosition(1, 3); BallPrintLn("2 - Remover Professor   " + (menuOPT == 2 ? "<" : null));
				Console.SetCursorPosition(1, 4); BallPrintLn("3 - Finalizar           " + (menuOPT == 3 ? "<" : null));

				if (!ChangePointer(1, 3)) continue;
				if (menuOPT == 3) break;

				if (menuOPT == 1)
				{
					
				}

				if (menuOPT == 2)
				{

				}

			} while (true);
		}

		public void ClassSection()
		{
			menuOPT = 1;
			do
			{
				Console.Clear();
				Console.ForegroundColor = ConsoleColor.White;
				Console.SetCursorPosition(1, 1); BallPrintLn($"Menu de administração de: ");
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.SetCursorPosition($" ・ Menu de administração de: ".Length + 1, 1); Print("Turmas");
				Console.ForegroundColor = ConsoleColor.White;

				Console.SetCursorPosition(1, 2); BallPrintLn("1 - Cadastrar Turma " + (menuOPT == 1 ? "<" : null));
				Console.SetCursorPosition(1, 3); BallPrintLn("2 - Remover Turma   " + (menuOPT == 2 ? "<" : null));
				Console.SetCursorPosition(1, 4); BallPrintLn("3 - Finalizar       " + (menuOPT == 3 ? "<" : null));

				if (!ChangePointer(1, 3)) continue;
				if (menuOPT == 3) break;

				if (menuOPT == 1)
				{
					
				}

				if (menuOPT == 2)
				{

				}

			} while (true);
		}

		public void SubjectSection()
		{
			menuOPT = 1;
			do
			{
				Console.Clear();
				Console.ForegroundColor = ConsoleColor.White;
				Console.SetCursorPosition(1, 1); BallPrintLn($"Menu de administração de: ");
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.SetCursorPosition($" ・ Menu de administração de: ".Length + 1, 1); Print("Matérias");
				Console.ForegroundColor = ConsoleColor.White;

				Console.SetCursorPosition(1, 2); BallPrintLn("1 - Cadastrar Matéria " + (menuOPT == 1 ? "<" : null));
				Console.SetCursorPosition(1, 3); BallPrintLn("2 - Remover Matéria   " + (menuOPT == 2 ? "<" : null));
				Console.SetCursorPosition(1, 4); BallPrintLn("3 - Finalizar         " + (menuOPT == 3 ? "<" : null));

				if (!ChangePointer(1, 3)) continue;
				if (menuOPT == 3) break;

				if (menuOPT == 1)
				{
					
				}

				if (menuOPT == 2)
				{

				}

			} while (true);
		}

		public void StatisticsSection()
		{
			
		}

		public bool ChangePointer(int min, int max)
		{
			pressedKey = Console.ReadKey().Key;
			if (pressedKey == ConsoleKey.UpArrow && menuOPT > min) menuOPT--;
			if (pressedKey == ConsoleKey.DownArrow && menuOPT < max) menuOPT++;
			if (pressedKey == ConsoleKey.Enter)
			{
				if (menuOPT > 0 && menuOPT < 6)
				{
					executeSection = menuOPT;
					return true;
				}
				else if (menuOPT == 6)
				{
					isRunning = false;
					return true;
				}
			}
			return false;
		}
	}
}
