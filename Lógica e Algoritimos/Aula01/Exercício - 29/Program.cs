// Console.WriteLine("Hello, World!");

int spd, spdLimit;

Console.Write("Qual o limite de velocidade: "); spdLimit = Convert.ToInt32(Console.ReadLine());
Console.Write("Qual a velocidade do motorista: "); spd = Convert.ToInt32(Console.ReadLine());

if (spd <= spdLimit + 10 && spd >= spdLimit)
{
    Console.WriteLine("Multa de R$50,00");
}
else if (spd < spdLimit + 30)
{
    Console.WriteLine("Multa de R$100,00");
}
else if (spd < spdLimit + 30)
{
    Console.WriteLine("Multa de R$200,00");
}
else if (spd >= spdLimit)
{
    Console.WriteLine("Multa de R$300,00");
}
