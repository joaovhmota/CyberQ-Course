// Console.WriteLine("Hello, World!");

int   n1, n2;
char  option;
float result = 0.0f;

Console.Write("Número 1: "); n1 = Convert.ToInt32( Console.ReadLine() );
Console.Write("Número 2: "); n2 = Convert.ToInt32( Console.ReadLine() );

Console.WriteLine("Qual operação deseja realizar? ");
Console.Write(">>> "); option = Console.ReadLine().ToCharArray()[0];

switch (option)
{
    case '+':
        result = n1 + n2;
        break;
    case '-':
        result = n1 - n2;
        break;
    case '*':
        result = n1 * n2;
        break;
    case '/':
        result = n1 / n2;
        break;
    default:
        Console.WriteLine("Operação inválida!");
        break;
}

Console.WriteLine("O resultado da sua operação é: {0}", result);
