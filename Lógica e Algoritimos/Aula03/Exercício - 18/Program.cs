	// Variables
string[] brands    = new string[100];
int[] brandProducts = new int[100];
string[,] products = new string[100, 2];

bool isRunning = true,
	repeat   = false;

string nameBrand   = "",
	  nameProduct = "",
	  brandChosen = "";

int menuOPT = 1;

ConsoleKey currentKey;

	// Main Code
while (isRunning)
{
	do
	{
		Console.Clear();
		Console.WriteLine(" ・ Menu de opções:   ");
		Console.WriteLine(" 1 - Cadastrar marcas   " + ((menuOPT == 1) ? " <- " : null));
		Console.WriteLine(" 2 - Alterar marca      " + ((menuOPT == 2) ? " <- " : null));
		Console.WriteLine(" 3 - Excluir marca      " + ((menuOPT == 3) ? " <- " : null));
		Console.WriteLine(" 4 - Cadastrar produtos " + ((menuOPT == 4) ? " <- " : null));
		Console.WriteLine(" 5 - Listar produtos    " + ((menuOPT == 5) ? " <- " : null));
		Console.WriteLine(" 6 - Estastísticas      " + ((menuOPT == 6) ? " <- " : null));
		Console.WriteLine("");
		Console.WriteLine(" 7 - Sair               " + ((menuOPT == 7) ? " <- " : null));

		currentKey = Console.ReadKey().Key;

		if (currentKey == ConsoleKey.UpArrow   && menuOPT != 1) menuOPT--;
		if (currentKey == ConsoleKey.DownArrow && menuOPT != 7) menuOPT++;
		if (currentKey == ConsoleKey.Enter) break;
	} while (true);

	switch (menuOPT)
	{
		case 1:
			do
			{
				repeat = false;
				Console.Clear();
				Console.WriteLine(" ・ Cadastrar marca:");
				Console.Write(" 1 - Nome da marca: ");
				nameBrand = Console.ReadLine()!.ToUpper();
				if (nameBrand == "0") break;
				if (nameBrand == null || nameBrand == "") continue;
				for (int i = 0; i < brands.Length; i++)
				{
					if (brands[i] == null || brands[i] == "")
					{
						brands[i] = nameBrand;
						brandProducts[i] = 0;
						break;
					}
					else if (nameBrand == brands[i])
						repeat = true;
				}

			} while (repeat);
			break;

		case 2:
			do
			{
				repeat = true;
				Console.Clear();
				Console.WriteLine(" ・ Lista de marcas:");
				for (int i = 0; i < brands.Length; i++)
					Console.Write((brands[i] != null) ? $" {i+1}° - {brands[i]}\n" : null);

				Console.Write("Selecione uma marca: "); brandChosen = Console.ReadLine()!.ToUpper();
				if (brandChosen == "0") break;
				for (int i = 0; i < brands.Length; i++)
					if (brandChosen == brands[i])
					{
						Console.Write("Novo nome: "); nameBrand = Console.ReadLine()!.ToUpper();
						if (nameBrand == null || nameBrand == "") continue;
						brands[i] = nameBrand;
						brandProducts[i] = 0;
						repeat = false;
						break;
					}
				
			} while (repeat);

			break;

		case 3:
			do
			{
				repeat = true;
				Console.Clear();
				Console.WriteLine(" ・ Lista de marcas:");
				for (int i = 0; i < brands.Length; i++)
					Console.Write((brands[i] != null) ? $" {i+1}° - {brands[i]}\n" : null);

				Console.Write("Selecione uma marca para excluir: "); brandChosen = Console.ReadLine()!.ToUpper();
				if (brandChosen == "0") break;
				for (int i = 0; i < brands.Length; i++)
					if (brandChosen == brands[i])
					{
						brands[i] = null;
						brandProducts[i] = 0;
						repeat = false;
						break;
					}
			} while (repeat);
			break;

		case 4:
			do
			{
				repeat = false;
				Console.Clear();
				Console.WriteLine(" ・ Cadastrar Produto:");
				Console.Write(" 1 - Nome do Produto: ");
				nameProduct = Console.ReadLine()!.ToUpper();
				Console.Write(" 2 - Marca do Produto: ");
				nameBrand = Console.ReadLine()!.ToUpper();

				if (nameProduct == null || nameProduct == "") continue;
				for (int l = 0; l < products.GetLength(0); l++)
					if (products[l, 0] == null || products[l, 0] == "")
					{
						repeat = false;
						for (int i = 0; i < brands[i].Length; i++)
						{
							if (brands[i] == nameBrand)
							{
								products[l, 0] = nameProduct;
								products[l, 1] = nameBrand;
								brandProducts[i]++;
								break;
							}
						}
						break;
					}
			} while (repeat);
			break;

		case 5:
			Console.Clear();
			Console.WriteLine(" ・ Lista de produtos:");
			for (int l = 0; l < products.GetLength(0); l++)
				Console.Write( (products[l, 0] != null) ? $" {l+1}° {products[l, 0]} - {products[l, 1]}\n" : null);
			Console.ReadLine();
			break;

		case 6:
			Console.Clear();
			Console.WriteLine(" ・ Estastísticas:");
			for (int i = 0; i < brands.Length; i++)
				Console.Write( (brands[i] != null ) ? $" {i+1}° {brands[i]} - {brandProducts[i]} produtos\n" : null);

			Console.ReadLine();
			break;

		case 7:
			Console.Clear();
			isRunning = false;
			break;

	}
}
