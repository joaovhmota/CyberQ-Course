// Console.WriteLine("Hello, World!");

double quant;

Console.Write("Quantidade de notas de: 2: "); quant = 2 * Convert.ToInt32(Console.ReadLine());
Console.Write("Quantidade de notas de: 5: "); quant += 5 * Convert.ToInt32(Console.ReadLine());
Console.Write("Quantidade de notas de: 10: "); quant += 10 * Convert.ToInt32(Console.ReadLine());
Console.Write("Quantidade de notas de: 20: "); quant += 20 * Convert.ToInt32(Console.ReadLine());
Console.Write("Quantidade de notas de: 50: "); quant += 50 * Convert.ToInt32(Console.ReadLine());
Console.Write("Quantidade de notas de: 100: "); quant += 100 * Convert.ToInt32(Console.ReadLine());
Console.Write("Quantidade de notas de: 200: "); quant += 200 * Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Quantidade total: {0}", quant);