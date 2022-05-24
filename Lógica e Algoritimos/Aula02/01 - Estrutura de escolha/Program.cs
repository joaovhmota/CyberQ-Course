string CityName = "Blumenau";

switch (CityName.ToUpper())
{
	case "BLUMENAU":
		Console.WriteLine("Cidade onde se faz a OktoberFest");
		break;
	
	case "POMERODE":
		Console.WriteLine("Cidade mais alemã do Brasil");
		break;

	default:
		Console.WriteLine("Não");
		break;
}