// Console.WriteLine("Hello, World!");

double valor, taxa;
int    meses;

Console.Write("Valor aplicado: R$"); valor = Convert.ToInt32(Console.ReadLine());
Console.Write("Por quantos meses: "); meses = Convert.ToInt32(Console.ReadLine());
Console.Write("Qual a taxa: "); taxa = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("O total no final será de: R${0}", (valor + (valor * (taxa / 100) * meses )).ToString("N2"));