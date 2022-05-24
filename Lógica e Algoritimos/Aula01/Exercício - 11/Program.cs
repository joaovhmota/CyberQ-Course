// Console.WriteLine("Hello, World!");

float l1, l2, l3;

Console.Write("Lado 1: "); l1 = (float) Convert.ToDecimal(Console.ReadLine());
Console.Write("Lado 1: "); l2 = (float) Convert.ToDecimal(Console.ReadLine());
Console.Write("Lado 1: "); l3 = (float) Convert.ToDecimal(Console.ReadLine());

if (l1 == l2 && l1 == l3)
{
    Console.WriteLine("Equilátero");
}
else if (l1 != l2 && l2 != l3 && l1 != l3)
{
    Console.WriteLine("Escaleno");
}
else
{
    Console.WriteLine("Escaleno");
}