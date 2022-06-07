using System;

namespace Exercício_04
{
	internal class Agenda
	{
		// Attributes
		private List<Contact> ContactList = new List<Contact>();
		private List<string> CityList = new List<string>();
		private void AddContact(Contact c) => this.ContactList.Add(c);

		public void Start()
		{
			bool isRunning = true;
			do
			{
				try
				{
					ShowMenu();
					isRunning = GetOption();

				} catch (Exception ex)
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine($" ・ {ex.Message} ・ ");
					Console.ForegroundColor = ConsoleColor.White;
					Console.ReadLine();
				}

			} while (isRunning);
		}

		private void ShowMenu()
		{
			Console.Clear();
			Console.WriteLine(" ・ 1 - Cadastrar");
			Console.WriteLine(" ・ 2 - Listar");
			Console.WriteLine(" ・ 3 - Pesquisar");
			Console.WriteLine(" ・ 4 - Alterar");
			Console.WriteLine(" ・ 5 - Remover");
			Console.WriteLine(" ・ 6 - Estatísticas");
			Console.WriteLine(" ・ 7 - Finalizar");
		}

		private void AddCity()
		{
			for (int i = 0; i < ContactList.Count; i++)
				if (!CityList.Contains(ContactList[i].City))
					CityList.Add(ContactList[i].City);
		}

		private void DisplayContactList()
		{
			for (int i = 0; i < ContactList.Count; i++)
				Console.WriteLine($" ・ {i+1}° {ContactList[i].Name} - {ContactList[i].Phone} - {ContactList[i].Email} - {ContactList[i].City}");
		}

		private void SearchInContactList()
		{
			string searchTerm;
			do
			{
				Console.Write(" ・ Informe o termo que desejas pesquisar ['Sair' para finalizar]: "); searchTerm = Console.ReadLine()!;
				if (searchTerm.ToUpper() == "SAIR") break;
				Console.Clear();
				for (int i = 0; i < ContactList.Count; i++)
					if (ContactList[i].Name.Contains(searchTerm) || ContactList[i].Email.Contains(searchTerm) || ContactList[i].Phone.Contains(searchTerm) || ContactList[i].City.Contains(searchTerm))
						Console.WriteLine($" ・ {ContactList[i].Name} - {ContactList[i].Phone} - {ContactList[i].Email} - {ContactList[i].City}");
			} while (true);
		}

		private void UpdateContactInList()
		{
			try
			{
				int opt = 0;

				DisplayContactList();
				Console.Write("Contato que desejas editar: ");
				opt = Convert.ToInt32(Console.ReadLine()!) - 1;
				ContactList[opt] = ContactList[opt].EditContact();

			} catch(Exception ex)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine($" ・ {ex.Message} ・ ");
				Console.ForegroundColor = ConsoleColor.White;
				Console.ReadLine();
			}
		}

		private void DeleteContact()
		{
			try
			{
				int opt = 0;

				DisplayContactList();
				Console.Write("Contato que desejas remover: ");
				opt = Convert.ToInt32(Console.ReadLine()!) - 1;
				ContactList.Remove(ContactList[opt]);

			} catch(Exception ex)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine($" ・ {ex.Message} ・ ");
				Console.ForegroundColor = ConsoleColor.White;
				Console.ReadLine();
			}
		}

		private void ShowStatistics()
		{
			for (int i = 0; i < CityList.Count; i++)
			{
				Console.WriteLine($" ・ Contatos em: {CityList[i]}");
				for (int j = 0; j < ContactList.Count; j++)
				{
					if (ContactList[j].City == CityList[i])
						Console.WriteLine($" ・ {ContactList[j].Name} - {ContactList[j].Phone} - {ContactList[j].Email}");
				}
			}
		}

		private bool GetOption()
		{
			int opt = 0;
			Console.Write(">>> ");
			opt = Convert.ToInt32(Console.ReadLine()!);
			Console.Clear();
			switch (opt)
			{
				case 1: ContactList.Add( new Contact().CreateContact() ); AddCity(); break;
				case 2: DisplayContactList(); Console.ReadLine(); break;
				case 3: SearchInContactList(); break;
				case 4: UpdateContactInList(); break;
				case 5: DeleteContact(); break;
				case 6: ShowStatistics(); Console.ReadLine(); break;
				case 7: return false;
			}
			return true;
		}
	}
}
