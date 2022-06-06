double[,] products =
{
	{ 1,  1500.0, 5,  0},
	{ 2,  23.0, 127,  0},
	{ 3,  120.0, 18,  0},
	{ 4,  15.0, 53 ,  0},
	{ 5,  0.1, 999 ,  0},
	{ 6,  245.0, 7 ,  0},
	{ 7,  105.0, 23,  0},
	{ 8,  80.0, 10 ,  0},
	{ 9,  136.0, 13,  0},
	{ 10, 12500.0, 6, 0}
};
double total = 0;
string productName = "";
int opt,
    amount = 0;
bool endThis = false;

do
{
	try
	{
		Console.Clear();
		Console.WriteLine($" [Loja do seu Sérgio] ");
		for (int l = 0; l < products.GetLength(0); l++)
		{
			switch (products[l, 0])
			{
				case 1:
					productName = "I9 9900";
					break;

				case 2:
					productName = "Mousepad";
					break;

				case 3:
					productName = "Teclado Mecânico";
					break;
				
				case 4:
					productName = "Mouse";
					break;
				
				case 5:
					productName = "Tijolo";
					break;

				case 6:
					productName = "Monitor";
					break;
				
				case 7:
					productName = "Fita RGB";
					break;

				case 8:
					productName = "HD";
					break;

				case 9:
					productName = "SSD";
					break;

				case 10:
					productName = "RTX 4900 TI GIGA";
					break;
			}
			Console.WriteLine($" ・ {products[l, 0]} - {productName}\t [{products[l, 2]} unidades restante]");
		}
		Console.Write("Produto [-1 para sair]: "); opt = Convert.ToInt16(Console.ReadLine()!);
		if (opt == -1) break;
		Console.Write("Quantidade: "); amount = Convert.ToInt16(Console.ReadLine()!);
		
		if (!(products[opt - 1, 2] >= amount))
			throw new Exception("Quantidade escolhida além do limite");

		switch (opt)
		{ 
			case 1:
				total += products[opt - 1, 1];
				products[opt - 1, 2] -= amount;
				products[opt - 1, 3] += amount;
				break;

			case 2:
				total += products[opt-1, 1];
				products[opt - 1, 2] -= amount;
				products[opt - 1, 3] += amount;
				break;

			case 3:
				total += products[opt-1, 1];
				products[opt - 1, 2] -= amount;
				products[opt - 1, 3] += amount;
				break;
			
			case 4:
				total += products[opt-1, 1];
				products[opt - 1, 2] -= amount;
				products[opt - 1, 3] += amount;
				break;
			
			case 5:
				total += products[opt-1, 1];
				products[opt - 1, 2] -= amount;
				products[opt - 1, 3] += amount;
				break;

			case 6:
				total += products[opt-1, 1];
				products[opt - 1, 2] -= amount;
				products[opt - 1, 3] += amount;
				break;
			
			case 7:
				total += products[opt-1, 1];
				products[opt - 1, 2] -= amount;
				products[opt - 1, 3] += amount;
				break;

			case 8:
				total += products[opt-1, 1];
				products[opt - 1, 2] -= amount;
				products[opt - 1, 3] += amount;
				break;

			case 9:
				total += products[opt-1, 1];
				products[opt - 1, 2] -= amount;
				products[opt - 1, 3] += amount;
				break;

			case 10:
				total += products[opt-1, 1];
				products[opt - 1, 2] -= amount;
				products[opt - 1, 3] += amount;
				break;	
		}
	} catch (Exception ex) { continue; }

} while (!endThis);

Console.Clear();
Console.WriteLine($" ・ Total: {total:C2}");
for (int l = 0; l < products.GetLength(0); l += amount)
	Console.WriteLine( (products[l, 3] > 0) ? $" ・ Product: {products[l, 0]} | Qtd: {products[l, 3]} uni. | {products[l, 1]:C2} por uni." : null);