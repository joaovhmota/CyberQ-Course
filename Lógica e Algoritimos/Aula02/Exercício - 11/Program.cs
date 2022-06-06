int input = 1,
	odd = 0,
	even = 0,
	positive = 0,
	negative = 0,
	total = 0;
bool pass = true;

while (pass)
{
	Console.Write("Informe um número: "); 
	input = Convert.ToInt32(Console.ReadLine());

	if (input == 0) pass = false;

	if (input > 0) positive++;
	else negative++;

	if (input % 2 == 0) even++;
	else odd++;

	total++;
}

total--;

Console.Clear();
Console.WriteLine("Total de números informados: {0}", total);
Console.WriteLine("Ímpares: " + odd);
Console.WriteLine("Pares: " + even);
Console.WriteLine("Negativos: " + negative);
Console.WriteLine("Positivos: " + positive);
