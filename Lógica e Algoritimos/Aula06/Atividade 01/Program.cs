List<string> nomeProduto = new List<string>();
List<string> marcaProduto = new List<string>();
List<double> valorProduto = new List<double>();

string temp;
bool isRunning = true;
int opt;
int alter;
string toSearch;

do
{
	try
	{
		Console.Clear();
		Console.WriteLine(" ・ 1 - Cadastrar");
		Console.WriteLine(" ・ 2 - Listar");
		Console.WriteLine(" ・ 3 - Pesquisar");
		Console.WriteLine(" ・ 4 - Alterar");
		Console.WriteLine(" ・ 5 - Remover");
		Console.WriteLine(" ・ 6 - Sair");
		Console.Write(">>> "); opt = Convert.ToInt32(Console.ReadLine()!);

		Console.Clear();
		switch (opt)
		{
			case 1:
				Console.Write(" ・ Digite o nome do produto: "); nomeProduto.Add(Console.ReadLine()!);
				Console.Write(" ・ Digite a marca do produto: "); marcaProduto.Add(Console.ReadLine()!);
				Console.Write(" ・ Digite o valor do produto: "); valorProduto.Add(Convert.ToDouble(Console.ReadLine()!));
				break;
			case 2:
				for (int i = 0; i < nomeProduto.Count; i++)
					Console.WriteLine($" ・ {nomeProduto[i]} - {marcaProduto[i]} - {valorProduto[i]:C2}");
				Console.ReadLine();
				break;
			case 3:
				Console.Write("Digite um termo para pesquisar: "); toSearch = Console.ReadLine()!;
				for (int i = 0; i < nomeProduto.Count; i++)
				{
					if (nomeProduto[i].Contains(toSearch) || marcaProduto[i].Contains(toSearch) || valorProduto[i].ToString().Contains(toSearch))
						Console.WriteLine($" ・ {nomeProduto[i]} - {marcaProduto[i]} - {valorProduto[i]:C2}");
				}
				Console.ReadLine();
				break;
			case 4: 
				for (int i = 0; i < nomeProduto.Count; i++)
					Console.WriteLine($" ・ {i+1}° - {nomeProduto[i]} - {marcaProduto[i]} - {valorProduto[i]:C2}");

				Console.Write("Escolha um produto para editar: "); alter = Convert.ToInt32(Console.ReadLine()!) - 1;

				Console.Write("Novo nome [Vazio para deixar igual]: "); temp = Console.ReadLine()!.Trim();
				if (temp != "") nomeProduto[alter] = temp;

				Console.Write("Nova marca [Vazio para deixar igual]: "); temp = Console.ReadLine()!.Trim();
				if (temp != "") marcaProduto[alter] = temp;

				Console.Write("Novo valor [Vazio para deixar igual]: "); temp = Console.ReadLine()!.Trim();
				if (temp != "") valorProduto[alter] = Convert.ToDouble(temp);

				break;
			case 5: 
				for (int i = 0; i < nomeProduto.Count; i++)
					Console.WriteLine($" ・ {i+1}° - {nomeProduto[i]} - {marcaProduto[i]} - {valorProduto[i]:C2}");

				Console.Write("Escolha um produto para remover: "); alter = Convert.ToInt32(Console.ReadLine()!) - 1;
				nomeProduto.Remove(nomeProduto[alter]);
				marcaProduto.Remove(marcaProduto[alter]);
				valorProduto.Remove(valorProduto[alter]);
				break;
			case 6:
				isRunning = false;
				break;
		}

	} catch(Exception ex) { }
} while (isRunning);