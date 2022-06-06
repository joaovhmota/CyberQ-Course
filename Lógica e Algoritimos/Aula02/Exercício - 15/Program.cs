bool   isRunning = true;

string productName,
	  tempProductName,
	  biggestProductName   = "",
	  biggestProductSecion = "";

double productPrice,
	  tempProductPrice,
	  biggestProcutPrice = 0.00,
	  totalSect1         = 0.00,
	  totalSect2         = 0.00,
	  totalSect3         = 0.00,
	  totalSect4         = 0.00,
	  totalSect5         = 0.00;

int    totalProducts = 0,
	  sect1Products = 0,
	  sect2Products = 0,
	  sect3Products = 0,
	  sect4Products = 0,
	  sect5Products = 0;

byte   secOpt;

while (isRunning)
{
	try
	{
		Console.WriteLine("\n\tSegmento do Produto:");
		Console.WriteLine("\t ・ 1 - Alimentício");
		Console.WriteLine("\t ・ 2 - Áudio e Vídeo");
		Console.WriteLine("\t ・ 3 - Computadores e Notebooks");
		Console.WriteLine("\t ・ 4 - Smartphone");
		Console.WriteLine("\t ・ 5 - Vestuário");
		Console.WriteLine("\t ・ 0 - Cancelar");
		Console.Write("\t>>> "); secOpt = Convert.ToByte(Console.ReadLine());

		if (secOpt > 5 || secOpt < 0) throw new Exception("Invalid Option.");
		else if (secOpt == 0) { isRunning = false; break; }

		Console.Write("\n\t ・ Nome do Produto:  "); tempProductName = Console.ReadLine()!;
		if (tempProductName == "") throw new Exception("Invalid product name.");

		Console.Write("\n\t ・ Valor do Produto: R$"); tempProductPrice = Convert.ToDouble(Console.ReadLine());
		if (tempProductPrice <= 0) throw new Exception("Invalid product price.");
		
		productName = tempProductName!;
		productPrice = tempProductPrice;
		totalProducts++;

		switch (secOpt)
		{
			case 1:
				sect1Products++;
				totalSect1 += productPrice;
				break;

			case 2:
				sect2Products++;
				totalSect2 += productPrice;
				break;

			case 3:
				sect3Products++;
				totalSect3 += productPrice;
				break;

			case 4:
				sect4Products++;
				totalSect4 += productPrice;
				break;
			
			case 5:
				sect5Products++;
				totalSect5 += productPrice;
				break;
		}

		if (productPrice > biggestProcutPrice)
		{
			biggestProductName = productName;
			biggestProcutPrice = productPrice;
			switch (secOpt)
			{
				case 1:
					biggestProductSecion = "Alimentício";
					break;
				
				case 2:
					biggestProductSecion = "Áudio e Vídeo";
					break;

				case 3:
					biggestProductSecion = "Computadores e Notebooks";
					break;

				case 4:
					biggestProductSecion = "Smartphones";
					break;

				case 5:
					biggestProductSecion = "Vestuário";
					break;
			}
		}

		Console.Clear();
	} catch (Exception e)
	{
		Console.Clear();
		Console.ForegroundColor = ConsoleColor.Red;
		Console.WriteLine($"\n ・ [{e.Message}] ・ \n");
		Console.ForegroundColor = ConsoleColor.White;
	}
}

Console.Clear();
Console.WriteLine($"\n\t ・ Total de produtos registrados: {totalProducts} registrados\n"); 
Console.WriteLine($"\t ・ Total de itens vendidos no setor Alimentício...............{sect1Products} [Média: {totalSect1 / totalProducts:C2}]");
Console.WriteLine($"\t ・ Total de itens vendidos no setor Áudio e Vídeo.............{sect2Products} [Média: {totalSect2 / totalProducts:C2}]");
Console.WriteLine($"\t ・ Total de itens vendidos no setor Computadores e Notebooks:.{sect3Products} [Média: {totalSect3 / totalProducts:C2}]");
Console.WriteLine($"\t ・ Total de itens vendidos no setor Smartphones:..............{sect4Products} [Média: {totalSect4 / totalProducts:C2}]");
Console.WriteLine($"\t ・ Total de itens vendidos no setor Vestuário:................{sect5Products} [Média: {totalSect5 / totalProducts:C2}]");
Console.WriteLine($"\n\t ・ Produto mais caro: {biggestProductName}");
Console.WriteLine($"\t ・ Preço do produto mais caro: {biggestProcutPrice:C2}");
Console.WriteLine($"\t ・ Setor do produto mais caro: {biggestProductSecion}");
