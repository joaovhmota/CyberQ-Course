using System;

namespace Exemplo_04
{
	internal class SysAction
	{
		private List<Person> registeredPerson;
		public SysAction() { this.registeredPerson = new List<Person>(); }

		public void Init()
		{
			bool isRunning = true;
			do
			{
				Console.Clear();
				Console.WriteLine(" ・ Menu ・ ");
				Console.WriteLine(" ・ 1 - Cadastrar");
				Console.WriteLine(" ・ 2 - Listar");
				Console.WriteLine(" ・ 3 - Remover");
				Console.WriteLine(" ・ 4 - Finalizar");
				int opt = Convert.ToInt32(Console.ReadLine()!);

				switch (opt)
				{
					case 1: this.RegisterPerson();        break;
					case 2: 
						this.ShowRegisteredPerson(); 
						Console.ReadLine(); 
						break;
					case 3: this.RemovePerson();          break;
					case 4: isRunning = false;            break;
				}
			} while (isRunning);
		}

		private void RegisterPerson()
		{
			Person tempPerson = new Person();

			Console.Write(" ・ Informe o nome da pessoa: ");
			tempPerson.Name = Console.ReadLine()!;

			Console.Write(" ・ Informa a idade da pessoa: ");
			tempPerson.Age = Convert.ToInt32(Console.ReadLine());

			this.registeredPerson.Add(tempPerson);
		}

		private void ShowRegisteredPerson()
		{
			for (int i = 0; i < this.registeredPerson.Count; i++)
				Console.WriteLine($" ・ {i+1}° {this.registeredPerson[i].Name} ({this.registeredPerson[i].Age} anos)");
			
		}

		private void RemovePerson()
		{
			this.ShowRegisteredPerson();

			Console.Write(" ・ Selecione a pessoa que deseja remover da lista: ");
			this.registeredPerson.Remove(
				this.registeredPerson[Convert.ToInt32(Console.ReadLine()) - 1]
			);
		}
	}
}
