bool   isBuying = true;
double total    = 0;

while (isBuying)
{
	Console.WriteLine("1 - Arroz    (5kg) \tR$18,70");
	Console.WriteLine("2 - Feijão   (2kg) \tR$5,85");
	Console.WriteLine("3 - Trigo    (2kg) \tR$4,55");
	Console.WriteLine("4 - Açúcar   (2kg) \tR$6,98");
	Console.WriteLine("5 - Macarrão (1kg) \tR$2,89");
	Console.WriteLine("6 - Milho    (Lata)\tR$1,78");
	Console.WriteLine("7 - Ervilha  (Lata)\tR$1,67");

	Console.Write("Digite o número para comprar [0 para cancelar] >>> ");
	switch (Console.ReadLine().ToCharArray()[0])
	{
		case '1':
			total += 18.70;
			break;

		case '2':
			total += 5.85;
			break;

		case '3':
			total += 4.55;
			break;

		case '4':
			total += 6.98;
			break;

		case '5':
			total += 2.89;
			break;

		case '6':
			total += 1.78;
			break;

		case '7':
			total += 1.67;
			break;

		case '0':
			isBuying = false;
			break;

		default:
			Console.Clear();
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("\n\tOpção Inválida\n");
			Console.ForegroundColor = ConsoleColor.White;
			break;
	}
}

Console.Clear();
Console.WriteLine("Valor total da compra é: R${0}", total);