// Console.WriteLine("Hello, World!");

int day;

Console.Write("Informe um dia do mês de maio de 2022: "); day = Convert.ToInt16(Console.ReadLine());

if (day == 1 || day == 8 || day == 15 || day == 22 || day == 29 )
{
    Console.WriteLine("Domingo");
}
else if (day == 2 || day == 9 || day == 16 || day == 23 || day == 30)
{
    Console.WriteLine("Segunda-feira");
}
else if (day == 3 || day == 10 || day == 17 || day == 24 || day == 31)
{
    Console.WriteLine("Terça-feira");
}
else if (day == 4 || day == 11 || day == 18 || day == 25)
{
    Console.WriteLine("Quarta-feira");
}
else if (day == 5 || day == 12 || day == 19 || day == 26)
{
    Console.WriteLine("Quinta-feira");
}
else if (day == 6 || day == 13 || day == 20 || day == 27)
{
    Console.WriteLine("Sexta-feira");
}
else if (day == 7 || day == 11 || day == 21 || day == 30)
{
    Console.WriteLine("Sábado");
}
