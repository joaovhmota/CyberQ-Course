int fat, result = 1;

Console.Write("Informe um valor: "); 
fat = Convert.ToInt32(Console.ReadLine());

for (int i = fat; i >= 1; i--)
{
	result *= i;
}

Console.WriteLine($"O fatorial de {fat} é {result}");