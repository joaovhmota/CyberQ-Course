Random rnd = new Random();
string[] cities = {"Pomerode", "Bluemanu", "Timbó", "Ponta Grossa", "São Paulo", "Jaraguá do Sul", "Hipotecas", "Chocolatin,é", "Porto Alegre", "Ivotí"};
string cidades = "";
int c = 0,
	generated;

while (c != 5)
{
	generated = rnd.Next(10);
	if (!cidades.Contains(generated.ToString()))
	{
		cidades += generated.ToString();
		Console.WriteLine(cities[generated]);
		c++;
	}
}