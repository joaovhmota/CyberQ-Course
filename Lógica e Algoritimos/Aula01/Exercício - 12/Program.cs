// Console.WriteLine("Hello, World!");

int optionE, optionC;

Console.WriteLine("Escolha um estado: \n1) Paraná \n2) Santa Catarina \n3) Rio Grande do Sul");
Console.Write(">>> "); optionE = Convert.ToInt16(Console.ReadLine());
Console.Clear();

switch (optionE)
{
    case 1:
        Console.WriteLine("Escolha uma cidade: \n1) Curitiba \n2) Londrina \n3) Foz do Iguaçu");
        Console.Write(">>> "); optionC = Convert.ToInt16(Console.ReadLine());
        switch (optionC)
        {
            case 1:
                Console.WriteLine("Curitiba é a capital do Paraná");
                break;

            case 2:
                Console.WriteLine("Londrina tem uma elecação de 610m");
                break;

            case 3:
                Console.WriteLine("Foz do Iguacú tem as cataratas do Iguaçú");
                break;

            default:
                Console.WriteLine("Opção inválida");
                break;
        }
        break;

    case 2:
        Console.WriteLine("Escolha uma cidade: \n1) Blumenau \n2) Pomerode \n3) Florianópolis");
        Console.Write(">>> "); optionC = Convert.ToInt16(Console.ReadLine());
        switch (optionC)
        {
            case 1:
                Console.WriteLine("A Quicksoft está localizada aqui");
                break;

            case 2:
                Console.WriteLine("Pomerode é a cidade mais alemã do Brasil");
                break;

            case 3:
                Console.WriteLine("Florianópolis é a capital de Santa Catarina");
                break;

            default:
                Console.WriteLine("Opção inválida");
                break;
        }
        break;

    case 3:
        Console.WriteLine("Escolha uma cidade: \n1) Porto alegre \n2) Ivoti \n3) Gramado ");
        Console.Write(">>> "); optionC = Convert.ToInt16(Console.ReadLine());
        switch (optionC)
        {
            case 1:
                Console.WriteLine("Porto alegra é a capital do Rio Grande do Sul");
                break;

            case 2:
                Console.WriteLine("Ivoti tem uma populção de 24690 habitantes");
                break;

            case 3:
                Console.WriteLine("Gramado é uma cidade Turistica do Rio Grande do Sul");
                break;

            default:
                Console.WriteLine("Opção inválida");
                break;
        }
        break;

    default:
        Console.WriteLine("Opção inválida");
        break;
}