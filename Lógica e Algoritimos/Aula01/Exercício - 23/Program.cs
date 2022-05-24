// Console.WriteLine("Hello, World!");

double temp;

Console.Write("Digite uma temperatura: "); temp = Convert.ToDouble(Console.ReadLine());
Console.Write("Em qual unidade está essa temperatura? [C ou F] \n>>> ");

switch (Console.ReadLine().ToCharArray()[0])
{
    case 'C':
        Console.WriteLine("{0}°C => {1}°F", temp, (temp * 1.8) + 32 );
        break;
    case 'F':
        Console.WriteLine("{0}°F => {1}°C", temp, (temp - 32) / 1.8 );
        break;
}