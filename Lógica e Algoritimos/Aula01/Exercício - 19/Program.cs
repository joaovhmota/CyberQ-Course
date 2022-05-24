// Console.WriteLine("Hello, World!");

double quant;

Console.Write("Quantidade de moedas de: 0,01: "); quant = 0.01 * Convert.ToInt32(Console.ReadLine());
Console.Write("Quantidade de moedas de: 0,05: "); quant += 0.05 * Convert.ToInt32(Console.ReadLine());
Console.Write("Quantidade de moedas de: 0,10: "); quant += 0.1 * Convert.ToInt32(Console.ReadLine());
Console.Write("Quantidade de moedas de: 0,25: "); quant += 0.25 * Convert.ToInt32(Console.ReadLine());
Console.Write("Quantidade de moedas de: 0,50: "); quant += 0.5 * Convert.ToInt32(Console.ReadLine());
Console.Write("Quantidade de moedas de: 1: "); quant += 1 * Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Quantidade total: {0}", quant);