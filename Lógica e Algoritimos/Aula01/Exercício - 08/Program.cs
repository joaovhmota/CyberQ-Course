// Console.WriteLine("Hello, World!");

float l1, l2, l3, l4;

Console.Write("Lado 1: "); l1 = (float) Convert.ToDecimal(Console.ReadLine());
Console.Write("Lado 2: "); l2 = (float) Convert.ToDecimal(Console.ReadLine());
Console.Write("Lado 3: "); l3 = (float) Convert.ToDecimal(Console.ReadLine());
Console.Write("Lado 4: "); l4 = (float) Convert.ToDecimal(Console.ReadLine());

if (l1 == l2 && l1 == l3 && l1 == l4)
{
    Console.WriteLine("É um quadrado");
}
else
{
    Console.WriteLine("Não é um quadrado");
}