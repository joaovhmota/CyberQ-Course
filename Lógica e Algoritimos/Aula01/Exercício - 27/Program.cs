// Console.WriteLine("Hello, World!");

int month;

Console.Write("Informe um mês: "); month = Convert.ToInt32(Console.Read());

switch (month)
{
    case 1:
        Console.WriteLine("Capricórnio ou Aquário");
        break;
    case 2:
        Console.WriteLine("Aquário ou Peixes");
        break;
    case 3:
        Console.WriteLine("Peixes ou Áries");
        break;
    case 4:
        Console.WriteLine("Áries ou Touro");
        break;
    case 5:
        Console.WriteLine("Touro ou Gêmeos");
        break;
    case 6:
        Console.WriteLine("Gêmeos ou Câncer");
        break;
    case 7:
        Console.WriteLine("Câncer ou Leão");
        break;
    case 8:
        Console.WriteLine("Leão or Virgem");
        break;
    case 9:
        Console.WriteLine("Virgem ou Libra");
        break;
    case 10:
        Console.WriteLine("Libra ou Escorpião");
        break;
    case 11:
        Console.WriteLine("Escorpião ou Sagitário");
        break;
    case 12:
        Console.WriteLine("Sagitário ou Capricórnio");
        break;
}