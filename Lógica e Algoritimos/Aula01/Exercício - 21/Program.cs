// Console.WriteLine("Hello, World!");

double valorHora, total;
int    horasTrabalhadas, extra1, extra2;

Console.Write("Digite o valor ganho por hora: R$");     valorHora        = Convert.ToDouble(Console.ReadLine());
Console.Write("Quantas horas foram trabalhadas? >>> "); horasTrabalhadas = Convert.ToInt16(Console.ReadLine());
Console.Write("Trabalhou hora extra? >>> ");            extra1           = Convert.ToInt16(Console.ReadLine());
Console.Write("Trabahlou no fim de semana? >>> ");      extra2           = Convert.ToInt16(Console.ReadLine());


total = valorHora * horasTrabalhadas;
total += extra1 * (valorHora / 2);
total += extra2 * valorHora;

Console.WriteLine("Total: R${0}", total);