// Console.WriteLine("Hello, World!");

float n1, n2;

Console.Write("Número 1: "); n1 = (float) Convert.ToDecimal(Console.ReadLine());
Console.Write("Número 1: "); n2 = (float) Convert.ToDecimal(Console.ReadLine());

if (n1 == n2)
{
    Console.WriteLine("A soma dos 2 é: {0}", n1 + n1);
}
else
{
    Console.WriteLine("A multiplicação dos 2 é: {0}", n1 * n2);
}