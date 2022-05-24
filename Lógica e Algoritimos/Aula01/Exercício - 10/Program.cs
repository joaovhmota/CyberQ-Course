// Console.WriteLine("Hello, World!");

float  price, finalPrice = 0;
char   option;
string nomeProduto;

Console.Write("Nome do produto: "); nomeProduto = Console.ReadLine();
Console.Write("Valor do produto: "); price = (float) Convert.ToDecimal(Console.ReadLine());
Console.Write("Forma de pagamento [V = À vista, P = A prazo]: "); option = Console.ReadLine().ToUpper().ToCharArray()[0];

switch (option)
{
    case 'V':
        finalPrice = (float) ( (price >= 500) ? price * 0.9 : price );
        break;
    case 'P':
        finalPrice = price;
        break;
    default:
        Console.WriteLine("Opção inválida!");
        break;
}

Console.WriteLine("O valor final ficou em: R${0}", finalPrice);