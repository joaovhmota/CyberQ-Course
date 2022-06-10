using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSchool.Classes
{
	internal class ActionProgram
	{
		public List<School> RegisteredSchools { get; set; }
		public int          MenuOption        { get; set; } = 1;
		public ConsoleKey   PressedKey        { get; set; }
		public School       CurrentSchool     { get; set; }

		public void BallPrint(string str) => Console.Write($" ・ {str}");
		public void BallPrintLine(string str) => Console.WriteLine($" ・ {str}");
		public int  WithBall(string str) => $" ・ {str}".Length;

		public ActionProgram() => RegisteredSchools = new List<School>();

		public void Init()
		{
			MenuOption = 1;
			if (RegisteredSchools.Count < 1) RegisterSchool();
			do
			{
				Console.Clear();
				Console.SetCursorPosition(2, 1); BallPrintLine("Menu: ");
				Console.SetCursorPosition(4, 2); BallPrintLine("1 - Cadastrar escola " + (MenuOption == 1 ? "<" : null));
				Console.SetCursorPosition(4, 3); BallPrintLine("2 - Entrar em escola " + (MenuOption == 2 ? "<" : null));
				switch (ChangePointer(1, 2))
				{
					case 1: RegisterSchool(); break;
					case 2: EnterSchool();     break;
				}
				if (CurrentSchool != null) SchoolMenu();
			} while (true);
		}
		public void ShowException(Exception ex)
		{
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine(ex.Message);
			Console.ForegroundColor = ConsoleColor.White;
			Console.ReadLine();
		}
		public int  ChangePointer(int min, int max)
		{
			PressedKey = Console.ReadKey().Key;

			if (PressedKey == ConsoleKey.UpArrow   && MenuOption > min) MenuOption--;
			if (PressedKey == ConsoleKey.DownArrow && MenuOption < max) MenuOption++;
			if (PressedKey == ConsoleKey.Enter) return MenuOption;

			return -1;
		}
		public void RegisterSchool()
		{
			do
			{
				try
				{
					string tempSchoolName;
					float  tempSchoolMinimumAvarage;
					bool   hasNumber = false;
					Console.Clear();
					Console.ForegroundColor = ConsoleColor.White;
					Console.SetCursorPosition(2, 1); BallPrintLine("Cadastrar Escola");
					Console.SetCursorPosition(4, 2); BallPrint("Nome da Escola: ");
					Console.SetCursorPosition(4, 3); BallPrint("Média Mínima da Escola: ");

					Console.ForegroundColor = ConsoleColor.Yellow;
					Console.SetCursorPosition(WithBall("Nome da Escola: ") + 4, 2); tempSchoolName = Console.ReadLine()!.Trim();
					if (tempSchoolName == "" || tempSchoolName.Length < 4) continue;
					for (int i = 0; i < tempSchoolName.Length; i++)
						if (Char.IsDigit(tempSchoolName[i]) || Char.IsSymbol(tempSchoolName[i]) || Char.IsPunctuation(tempSchoolName[i])) hasNumber = true;
					if (hasNumber) continue;

					Console.SetCursorPosition(WithBall("Média Mínima da Escola: ") + 4, 3); tempSchoolMinimumAvarage = Convert.ToSingle(Console.ReadLine()!.Replace('.', ','));
					if (tempSchoolMinimumAvarage < 0 || tempSchoolMinimumAvarage > 9) continue;
					Console.ForegroundColor = ConsoleColor.White;

					RegisteredSchools.Add(new School(tempSchoolName, tempSchoolMinimumAvarage));
					break;
				}
				catch (Exception ex) { ShowException(ex); }
			} while (true);
		}
		public void EnterSchool()
		{
			MenuOption = 1;
			do
			{
				try
				{
					Console.Clear();
					Console.SetCursorPosition(2, 1); BallPrintLine("Entrar na escola: ");

					for (int i = 0; i < RegisteredSchools.Count; i++)
					{
						Console.SetCursorPosition(4, i + 2); BallPrintLine($"{i+1}° {RegisteredSchools[i].Name} " + (MenuOption == RegisteredSchools.IndexOf(RegisteredSchools[i]) ? "<" : null));
					}
					Console.SetCursorPosition(4, RegisteredSchools.Count + 2); BallPrintLine("Sair " + (MenuOption == RegisteredSchools.Count ? "<" : null));
					ChangePointer(0, RegisteredSchools.Count);
					
					if (PressedKey == ConsoleKey.Enter)
					{
						if (MenuOption == RegisteredSchools.Count) break;
						else
						{
							CurrentSchool = RegisteredSchools[MenuOption];
							break;
						}
					}
				} catch (Exception ex) { }
			} while (true);
			
		}
		public void SchoolMenu()
		{
			MenuOption = 1;
			do
			{
				Console.Clear();
				Console.SetCursorPosition(2, 1); BallPrintLine($"Escola: {CurrentSchool.Name}");
				Console.SetCursorPosition(4, 2); BallPrintLine("Seções: ");
				Console.SetCursorPosition(6, 3); BallPrintLine("1 - Aluno        " + (MenuOption == 1 ? "<" : null));
				Console.SetCursorPosition(6, 4); BallPrintLine("2 - Professor    " + (MenuOption == 2 ? "<" : null));
				Console.SetCursorPosition(6, 5); BallPrintLine("3 - Sala de Aula " + (MenuOption == 3 ? "<" : null));
				Console.SetCursorPosition(6, 6); BallPrintLine("4 - Funcionário  " + (MenuOption == 4 ? "<" : null));
				Console.SetCursorPosition(6, 7); BallPrintLine("5 - Estatísticas " + (MenuOption == 5 ? "<" : null));
				Console.SetCursorPosition(6, 8); BallPrintLine("6 - Sair         " + (MenuOption == 6 ? "<" : null));

				ChangePointer(1,6);

				if (PressedKey == ConsoleKey.Enter)
				{
					if (MenuOption == 6)
					{
						CurrentSchool = null!;
						break;
					} 
					else
					{
						switch(MenuOption)
						{
							case 1: StudentSection(); break;
							case 2: TeacherSection(); break;
							case 3: ClassroomSection(); break;
							case 4: WorkerSection(); break;
							case 5: SchoolStatus(); break;
						}
					}
				}
			} while (true);
			MenuOption = 1;
		}
		public void StudentSection()
		{
			do
			{
				Console.Clear();
				Console.SetCursorPosition(2, 1); BallPrintLine($"Escola: {CurrentSchool.Name}");
				Console.SetCursorPosition(4, 2); BallPrintLine("Seção: Aluno");
				Console.SetCursorPosition(6, 3); BallPrintLine("1 - Cadastrar Aluno                " + (MenuOption == 1 ? "<" : null));
				Console.SetCursorPosition(6, 4); BallPrintLine("2 - Remover Aluno                  " + (MenuOption == 2 ? "<" : null));
				Console.SetCursorPosition(6, 5); BallPrintLine("3 - Adicionar Nota                 " + (MenuOption == 3 ? "<" : null));
				Console.SetCursorPosition(6, 6); BallPrintLine("4 - Adicionar Advertência ao Aluno " + (MenuOption == 4 ? "<" : null));
				Console.SetCursorPosition(6, 7); BallPrintLine("5 - Adicionar Suspensão ao Aluno   " + (MenuOption == 5 ? "<" : null));
				Console.SetCursorPosition(6, 8); BallPrintLine("6 - Sair                           " + (MenuOption == 6 ? "<" : null));
				
				ChangePointer(1, 6);

				if (PressedKey == ConsoleKey.Enter)
				{
					if (MenuOption == 6)
						break;
					else
					{
						switch (MenuOption)
						{
							case 1: // 学生を足す
								do
								{
									try
									{
										string tempStudentName;
										int    tempStudentAge;
										bool   hasNumber = false;
										Console.Clear();

										Console.ForegroundColor = ConsoleColor.White;
										Console.SetCursorPosition(2, 1); BallPrint("Nome do aluno: ");
										Console.SetCursorPosition(2, 2); BallPrint("Idade do aluno: ");

										Console.ForegroundColor = ConsoleColor.Yellow;
										Console.SetCursorPosition(WithBall("Nome do aluno: ") + 2, 1); tempStudentName = Console.ReadLine()!;
										if (tempStudentName == "" || tempStudentName.Length < 3) continue;
										for (int i = 0; i < tempStudentName.Length; i++)
											if (Char.IsDigit(tempStudentName[i]) || Char.IsSymbol(tempStudentName[i]) || Char.IsPunctuation(tempStudentName[i])) hasNumber = true;
										if (hasNumber) continue;

										Console.SetCursorPosition(WithBall("Idade do aluno: ") + 2, 2); tempStudentAge = Convert.ToInt32(Console.ReadLine()!);
										if (tempStudentAge < 0) continue;

										Console.ForegroundColor = ConsoleColor.White;

										CurrentSchool.Students.Add(new Student(tempStudentName, tempStudentAge));
										break;
									} catch(Exception ex) { ShowException(ex); }
								} while (true);
								break;
							case 2: // 学生を外す
								MenuOption = 0;
								do
								{
									try
									{
										Console.Clear();

										Console.ForegroundColor = ConsoleColor.White;

										for (int i = 0; i < CurrentSchool.Students.Count; i++)
										{
											Console.SetCursorPosition(4, i + 2); BallPrintLine($"{i+1} - {CurrentSchool.Students[i].ID}, {CurrentSchool.Students[i].Name} " + (MenuOption == CurrentSchool.Students.IndexOf(CurrentSchool.Students[i]) ? "<" : null));
										}
										Console.SetCursorPosition(4, CurrentSchool.Students.Count + 2); BallPrintLine("Sair " + (MenuOption == CurrentSchool.Students.Count ? "<" : null));

										ChangePointer(0, CurrentSchool.Students.Count);
										if (PressedKey == ConsoleKey.Enter)
										{
											if (MenuOption == CurrentSchool.Students.Count) break;
											else
											{
												CurrentSchool.Students.Remove(CurrentSchool.Students[MenuOption]);
												break;
											}
										}

									} catch(Exception ex) { ShowException(ex); }
								} while (true);
								break;
							case 3: // 学生にノートを足す 
								MenuOption = 0;
								do
								{
									try
									{
										float tempNote;

										Console.Clear();

										Console.ForegroundColor = ConsoleColor.White;

										for (int i = 0; i < CurrentSchool.Students.Count; i++)
										{
											Console.SetCursorPosition(4, i + 2); BallPrintLine($"{i+1} - {CurrentSchool.Students[i].ID}, {CurrentSchool.Students[i].Name} " + (MenuOption == CurrentSchool.Students.IndexOf(CurrentSchool.Students[i]) ? "<" : null));
										}
										Console.SetCursorPosition(4, CurrentSchool.Students.Count + 2); BallPrintLine("Sair " + (MenuOption == CurrentSchool.Students.Count ? "<" : null));

										ChangePointer(0, CurrentSchool.Students.Count);
										if (PressedKey == ConsoleKey.Enter)
										{
											if (MenuOption == CurrentSchool.Students.Count) break;
											else
											{
												Console.Clear();
												Console.SetCursorPosition(4, 1); BallPrint("Informe a nota do aluno: "); tempNote = Convert.ToSingle(Console.ReadLine()!);
												if (tempNote < 0 || tempNote > 10) continue;
												else
													CurrentSchool.Students[MenuOption].AddNote(tempNote);
												break;
											}
										}

									} catch(Exception ex) { ShowException(ex); }
								} while (true);
								break;
							case 4: 
								MenuOption = 0;
								do
								{
									try
									{
										string tempReason;

										Console.Clear();

										Console.ForegroundColor = ConsoleColor.White;

										for (int i = 0; i < CurrentSchool.Students.Count; i++)
										{
											Console.SetCursorPosition(4, i + 2); BallPrintLine($"{i+1} - {CurrentSchool.Students[i].ID}, {CurrentSchool.Students[i].Name} " + (MenuOption == CurrentSchool.Students.IndexOf(CurrentSchool.Students[i]) ? "<" : null));
										}
										Console.SetCursorPosition(4, CurrentSchool.Students.Count + 2); BallPrintLine("Sair " + (MenuOption == CurrentSchool.Students.Count ? "<" : null));

										ChangePointer(0, CurrentSchool.Students.Count);
										if (PressedKey == ConsoleKey.Enter)
										{
											if (MenuOption == CurrentSchool.Students.Count) break;
											else
											{
												Console.Clear();
												Console.SetCursorPosition(4, 1); BallPrint("Informe o motivo da advertência: "); tempReason = Console.ReadLine()!;
												if (tempReason == "") return;
												CurrentSchool.Students[MenuOption].Warnings.Add(new Warning(tempReason));
											}
										}

									} catch(Exception ex) { ShowException(ex); }
								} while (true);
								break;
							case 5: 
								MenuOption = 0;
								do
								{
									try
									{
										string tempReason;

										Console.Clear();

										Console.ForegroundColor = ConsoleColor.White;

										for (int i = 0; i < CurrentSchool.Students.Count; i++)
										{
											Console.SetCursorPosition(4, i + 2); BallPrintLine($"{i+1} - {CurrentSchool.Students[i].ID}, {CurrentSchool.Students[i].Name} " + (MenuOption == CurrentSchool.Students.IndexOf(CurrentSchool.Students[i]) ? "<" : null));
										}
										Console.SetCursorPosition(4, CurrentSchool.Students.Count + 2); BallPrintLine("Sair " + (MenuOption == CurrentSchool.Students.Count ? "<" : null));

										ChangePointer(0, CurrentSchool.Students.Count);
										if (PressedKey == ConsoleKey.Enter)
										{
											if (MenuOption == CurrentSchool.Students.Count) break;
											else
											{
												Console.Clear();
												Console.SetCursorPosition(4, 1); BallPrint("Informe o motivo da suspenção: "); tempReason = Console.ReadLine()!;
												if (tempReason == "") return;
												CurrentSchool.Students[MenuOption].Suspensions.Add(new Suspension(tempReason));
											}
										}

									} catch(Exception ex) { ShowException(ex); }
								} while (true);
								break;
						}
					}
				}

			} while (true);
			MenuOption = 1;
		}
		public void TeacherSection()
		{
			MenuOption = 1;
			do
			{
				try
				{
					Console.Clear();
					Console.SetCursorPosition(2, 1); BallPrintLine($"Escola: {CurrentSchool.Name}");
					Console.SetCursorPosition(4, 2); BallPrintLine("Seção: Professor");
					Console.SetCursorPosition(6, 3); BallPrintLine("1 - Cadastrar Professor " + (MenuOption == 1 ? "<" : null));
					Console.SetCursorPosition(6, 4); BallPrintLine("2 - Remover Professor   " + (MenuOption == 2 ? "<" : null));
					Console.SetCursorPosition(6, 5); BallPrintLine("Sair                    " + (MenuOption == 3 ? "<" : null));

					ChangePointer(1, 3);
					if (PressedKey == ConsoleKey.Enter)
					{
						if (MenuOption == 3)
							break;
						switch (MenuOption)
						{
							case 1:
								string tempTeacherName;
								int    tempTeacherAge;
								float  tempTeacherSalary;
								string tempTeacherSubject;
								bool   hasNumber = false;
								Console.Clear();

								Console.ForegroundColor = ConsoleColor.White;
								Console.SetCursorPosition(2, 1); BallPrint("Nome do Professor: ");
								Console.SetCursorPosition(2, 2); BallPrint("Idade do Professor: ");
								Console.SetCursorPosition(2, 3); BallPrint("Salário do Professor: ");
								Console.SetCursorPosition(2, 4); BallPrint("Matéria do Professor: ");

								Console.ForegroundColor = ConsoleColor.Yellow;
								Console.SetCursorPosition(WithBall("Nome do Professor: ") + 2, 1);    tempTeacherName = Console.ReadLine()!.Trim();
								if (tempTeacherName == "" || tempTeacherName.Length < 3) continue;

								Console.SetCursorPosition(WithBall("Idade do Professor: ") + 2, 2);   tempTeacherAge = Convert.ToInt32(Console.ReadLine()!);
								if (tempTeacherAge < 18 || tempTeacherAge > 122) continue;


								Console.SetCursorPosition(WithBall("Salário do Professor: ") + 2, 3); tempTeacherSalary = Convert.ToSingle(Console.ReadLine()!.Replace('.', ','));
								if (tempTeacherSalary < 0) continue;

								Console.SetCursorPosition(WithBall("Matéria do Professor: ") + 2, 4); tempTeacherSubject = Console.ReadLine()!.Trim();
								if (tempTeacherSubject == "") continue;

								Console.ForegroundColor = ConsoleColor.White;

								CurrentSchool.Teachers.Add( new Teacher(tempTeacherName, tempTeacherAge, tempTeacherSalary, new Subject(tempTeacherSubject)) );
								break;

							case 2:
								do
								{
									Console.Clear();
									for (int i = 0; i < CurrentSchool.Teachers.Count; i++)
									{
										Console.SetCursorPosition(4, i + 2); BallPrintLine($"{i+1} - {CurrentSchool.Teachers[i].ID}, {CurrentSchool.Teachers[i].Name} - {CurrentSchool.Teachers[i].Subject.Name}" + (MenuOption == CurrentSchool.Teachers.IndexOf(CurrentSchool.Teachers[i]) ? "<" : null));
									}
									
									Console.SetCursorPosition(4, CurrentSchool.Teachers.Count + 2);
									BallPrintLine("Sair " + (MenuOption == CurrentSchool.Teachers.Count ? "<" : null));

									ChangePointer(0, CurrentSchool.Teachers.Count);
									if (PressedKey == ConsoleKey.Enter)
									{
										if (MenuOption == CurrentSchool.Teachers.Count) break;
										else
										{
											CurrentSchool.Teachers.Remove(CurrentSchool.Teachers[MenuOption]);
											break;
										}
									}
								} while (true);
								break;
						}
					}
				} catch (Exception ex) { ShowException(ex); }
			} while (true);
		}
		public void ClassroomSection()
		{
			MenuOption = 1;
			do
			{
				try
				{
					Console.Clear();
					Console.SetCursorPosition(2, 1); BallPrintLine($"Escola: {CurrentSchool.Name}");
					Console.SetCursorPosition(4, 2); BallPrintLine("Seção: Sala de Aula");
					Console.SetCursorPosition(6, 3); BallPrintLine("1 - Cadastrar Sala de aula " + (MenuOption == 1 ? "<" : null));
					Console.SetCursorPosition(6, 4); BallPrintLine("2 - Remover Sala de Aula   " + (MenuOption == 2 ? "<" : null));
					Console.SetCursorPosition(6, 5); BallPrintLine("3 - Adicionar Aluno        " + (MenuOption == 3 ? "<" : null));
					Console.SetCursorPosition(6, 6); BallPrintLine("4 - Remover Aluno          " + (MenuOption == 4 ? "<" : null));
					Console.SetCursorPosition(6, 7); BallPrintLine("Sair                       " + (MenuOption == 5 ? "<" : null));

					ChangePointer(1, 5);
					if (PressedKey == ConsoleKey.Enter)
					{
						if (MenuOption == 5)
							break;
						switch (MenuOption)
						{
							case 1:
								string tempClassName;
								Console.Clear();

								Console.ForegroundColor = ConsoleColor.White;
								Console.SetCursorPosition(2, 1); BallPrint("Nome da Turma: ");

								Console.ForegroundColor = ConsoleColor.Yellow;
								Console.SetCursorPosition(WithBall("Nome da Turma: ") + 2, 1); tempClassName= Console.ReadLine()!.Trim();

								Console.ForegroundColor = ConsoleColor.White;

								CurrentSchool.SchoolClasses.Add(new SchoolClasses(tempClassName) );
								
								break;

							case 2:
								MenuOption = 0;
								do
								{
									Console.Clear();
									for (int i = 0; i < CurrentSchool.SchoolClasses.Count; i++)
									{
										Console.SetCursorPosition(4, i + 2); BallPrintLine($"{i+1} - {CurrentSchool.SchoolClasses[i].ID}, {CurrentSchool.SchoolClasses[i].Name} " + (MenuOption == CurrentSchool.SchoolClasses.IndexOf(CurrentSchool.SchoolClasses[i]) ? "<" : null));
									}
									
									Console.SetCursorPosition(4, CurrentSchool.SchoolClasses.Count + 2);
									BallPrintLine("Sair " + (MenuOption == CurrentSchool.SchoolClasses.Count ? "<" : null));

									ChangePointer(0, CurrentSchool.SchoolClasses.Count);
									if (PressedKey == ConsoleKey.Enter)
									{
										if (MenuOption == CurrentSchool.SchoolClasses.Count) break;
										else
										{
											CurrentSchool.SchoolClasses.Remove(CurrentSchool.SchoolClasses[MenuOption]);
											break;
										}
									}
								} while (true);
								break;

							case 3:
								MenuOption = 0;
								do
								{
									try
									{
										SchoolClasses currentClass;
										Student currentStudent;

										Console.Clear();
										for (int i = 0; i < CurrentSchool.SchoolClasses.Count; i++)
										{
											Console.SetCursorPosition(4, i + 2); BallPrintLine($"{i+1} - {CurrentSchool.SchoolClasses[i].ID}, {CurrentSchool.SchoolClasses[i].Name} " + (MenuOption == CurrentSchool.SchoolClasses.IndexOf(CurrentSchool.SchoolClasses[i]) ? "<" : null));
										}
										
										Console.SetCursorPosition(4, CurrentSchool.SchoolClasses.Count + 2);
										BallPrintLine("Sair " + (MenuOption == CurrentSchool.SchoolClasses.Count ? "<" : null));

										ChangePointer(0, CurrentSchool.SchoolClasses.Count);
										
										if (PressedKey == ConsoleKey.Enter)
										{
											if (MenuOption == CurrentSchool.SchoolClasses.Count) break;
											else
											{
												currentClass = CurrentSchool.SchoolClasses[MenuOption];
												Console.ForegroundColor = ConsoleColor.White;
												MenuOption = 0;
												do
												{
													Console.Clear();
													for (int i = 0; i < CurrentSchool.Students.Count; i++)
													{
														Console.SetCursorPosition(4, i + 2); BallPrintLine($"{i+1} - {CurrentSchool.Students[i].ID}, {CurrentSchool.Students[i].Name} " + (MenuOption == CurrentSchool.Students.IndexOf(CurrentSchool.Students[i]) ? "<" : null));
													}
													Console.SetCursorPosition(4, CurrentSchool.Students.Count + 2); BallPrintLine("Sair " + (MenuOption == CurrentSchool.Students.Count ? "<" : null));
													ChangePointer(0, CurrentSchool.Students.Count);

													if (PressedKey == ConsoleKey.Enter)
													{
														if (MenuOption == CurrentSchool.Students.Count) break;
														else
														{
															currentClass.AddStudent(CurrentSchool.Students[MenuOption]);
														}
													}

												} while (true);
											}
										}
									} catch (Exception ex) { ShowException(ex); }
								} while (true);
								break;

							case 4:
								MenuOption = 0;
								do
								{
									try
									{
										SchoolClasses currentClass;
										Student currentStudent;

										Console.Clear();
										for (int i = 0; i < CurrentSchool.SchoolClasses.Count; i++)
										{
											Console.SetCursorPosition(4, i + 2); BallPrintLine($"{i+1} - {CurrentSchool.SchoolClasses[i].ID}, {CurrentSchool.SchoolClasses[i].Name} " + (MenuOption == CurrentSchool.SchoolClasses.IndexOf(CurrentSchool.SchoolClasses[i]) ? "<" : null));
										}
										
										Console.SetCursorPosition(4, CurrentSchool.SchoolClasses.Count + 2);
										BallPrintLine("Sair " + (MenuOption == CurrentSchool.SchoolClasses.Count ? "<" : null));

										ChangePointer(0, CurrentSchool.SchoolClasses.Count);
										
										if (PressedKey == ConsoleKey.Enter)
										{
											if (MenuOption == CurrentSchool.SchoolClasses.Count) break;
											else
											{
												currentClass = CurrentSchool.SchoolClasses[MenuOption];
												Console.ForegroundColor = ConsoleColor.White;
												MenuOption = 0;
												do
												{
													Console.Clear();
													for (int i = 0; i < currentClass.Students.Count; i++)
													{
														Console.SetCursorPosition(4, i + 2); BallPrintLine($"{i+1} - {currentClass.Students[i].ID}, {currentClass.Students[i].Name} " + (MenuOption == currentClass.Students.IndexOf(currentClass.Students[i]) ? "<" : null));
													}
													Console.SetCursorPosition(4, currentClass.Students.Count + 2); BallPrintLine("Sair " + (MenuOption == currentClass.Students.Count ? "<" : null));
													ChangePointer(0, currentClass.Students.Count);

													if (PressedKey == ConsoleKey.Enter)
													{
														if (MenuOption == currentClass.Students.Count) break;
														else
														{
															currentClass.Students.Remove(currentClass.Students[MenuOption]);
														}
													}

												} while (true);
											}
										}
									} catch (Exception ex) { ShowException(ex); }
								} while (true);
								break;
						}
					}
				} catch (Exception ex) { ShowException(ex); }
			} while (true);
		}
		public void WorkerSection()
		{
			
			MenuOption = 1;
			do
			{
				try
				{
					Console.Clear();
					Console.SetCursorPosition(2, 1); BallPrintLine($"Escola: {CurrentSchool.Name}");
					Console.SetCursorPosition(4, 2); BallPrintLine("Seção: Funcionário");
					Console.SetCursorPosition(6, 3); BallPrintLine("1 - Cadastrar Funcionário " + (MenuOption == 1 ? "<" : null));
					Console.SetCursorPosition(6, 4); BallPrintLine("2 - Remover Funcionário   " + (MenuOption == 2 ? "<" : null));
					Console.SetCursorPosition(6, 5); BallPrintLine("Sair                    " + (MenuOption == 3 ? "<" : null));

					ChangePointer(1, 3);
					if (PressedKey == ConsoleKey.Enter)
					{
						if (MenuOption == 3)
							break;
						switch (MenuOption)
						{
							case 1:
								string tempWorkerName;
								int    tempWorkerAge;
								float  tempWorkerSalary;
								string tempWorkerRole;
								bool   hasNumber = false;
								Console.Clear();

								Console.ForegroundColor = ConsoleColor.White;
								Console.SetCursorPosition(2, 1); BallPrint("Nome do Funcionário: ");
								Console.SetCursorPosition(2, 2); BallPrint("Idade do Funcionário: ");
								Console.SetCursorPosition(2, 3); BallPrint("Salário do Funcionário: ");
								Console.SetCursorPosition(2, 4); BallPrint("Profissão do Funcionário: ");

								Console.ForegroundColor = ConsoleColor.Yellow;
								Console.SetCursorPosition(WithBall("Nome do Funcionário: ") + 2, 1);    tempWorkerName = Console.ReadLine()!.Trim();
								if (tempWorkerName == "" || tempWorkerName.Length < 3) continue;

								Console.SetCursorPosition(WithBall("Idade do Funcionário: ") + 2, 2);   tempWorkerAge = Convert.ToInt32(Console.ReadLine()!);
								if (tempWorkerAge < 18 || tempWorkerAge > 122) continue;


								Console.SetCursorPosition(WithBall("Salário do Funcionário: ") + 2, 3); tempWorkerSalary = Convert.ToSingle(Console.ReadLine()!.Replace('.', ','));
								if (tempWorkerSalary < 0) continue;

								Console.SetCursorPosition(WithBall("Profissão do Funcionário: ") + 2, 4); tempWorkerRole = Console.ReadLine()!.Trim();
								if (tempWorkerRole == "") continue;

								Console.ForegroundColor = ConsoleColor.White;

								CurrentSchool.Workers.Add(new Worker(tempWorkerName, tempWorkerAge, tempWorkerSalary, tempWorkerRole));
								break;

							case 2:
								do
								{
									Console.Clear();
									for (int i = 0; i < CurrentSchool.Workers.Count; i++)
									{
										Console.SetCursorPosition(4, i + 2); BallPrintLine($"{i+1} - {CurrentSchool.Workers[i].ID}, {CurrentSchool.Workers[i].Name} - {CurrentSchool.Workers[i].Role} " + (MenuOption == CurrentSchool.Workers.IndexOf(CurrentSchool.Workers[i]) ? "<" : null));
									}
									
									Console.SetCursorPosition(4, CurrentSchool.Workers.Count + 2);
									BallPrintLine("Sair " + (MenuOption == CurrentSchool.Workers.Count ? "<" : null));

									ChangePointer(0, CurrentSchool.Workers.Count);
									if (PressedKey == ConsoleKey.Enter)
									{
										if (MenuOption == CurrentSchool.Workers.Count) break;
										else
										{
											CurrentSchool.Workers.Remove(CurrentSchool.Workers[MenuOption]);
											break;
										}
									}
								} while (true);
								break;
						}
					}
				} catch (Exception ex) { ShowException(ex); }
			} while (true);
		}
		public void SchoolStatus()
		{
			Console.Clear();

			BallPrintLine($"Escola: {CurrentSchool.Name}");
			BallPrintLine($"Professores:");
			for (int i = 0; i < CurrentSchool.Teachers.Count; i++)
			{
				BallPrintLine($"Nome: {CurrentSchool.Teachers[i].Name}, Matéria: {CurrentSchool.Teachers[i].Subject.Name}, ID: {CurrentSchool.Teachers[i].ID}");
			}

			Console.WriteLine();
			BallPrintLine($"Funcionários:");
			for (int i = 0; i < CurrentSchool.Workers.Count; i++)
			{
				BallPrintLine($"Nome: {CurrentSchool.Workers[i].Name}, Função: {CurrentSchool.Workers[i].Role}, ID: {CurrentSchool.Teachers[i].ID}");
			}

			Console.WriteLine();
			BallPrintLine("Salas: ");
			for (int i = 0; i < CurrentSchool.SchoolClasses.Count; i++)
			{
				BallPrint($"Nome: {CurrentSchool.SchoolClasses[i].Name}, Média: {CurrentSchool.SchoolClasses[i].Avarage}, ID: {CurrentSchool.SchoolClasses[i].ID}");
			}

			Console.WriteLine();
			CurrentSchool.UpdateStudentSituation();
			BallPrintLine("Alunos: ");
			for (int i = 0; i < CurrentSchool.Students.Count; i++)
			{
				BallPrintLine($"Nome: {CurrentSchool.Students[i].Name}, Média: {CurrentSchool.Students[i].StudentAvarage}, Situação: {CurrentSchool.Students[i].Situation}");
			}
			Console.ReadLine();
		}
	}
}
