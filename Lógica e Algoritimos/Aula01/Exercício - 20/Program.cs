// Console.WriteLine("Hello, World!");

double valor;
char   moeda;

Console.Write("Digite um valor: "); valor = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Em qual moeda está o valor: \n1 - Real \n2 - Dólar \n3 - Euro \n4 - Libra \n5 - Peso Argentino");
Console.Write(">>> "); moeda = Console.ReadLine().ToCharArray()[0];

switch (moeda)
{
    case '1':
        Console.WriteLine("R${0} => US${1}", valor, valor * 0.21); // Dólar
        Console.WriteLine("R${0} => EU${1}", valor, valor * 0.2);  // Euro
        Console.WriteLine("R${0} => LI${1}", valor, valor * 0.17);  // Libra
        Console.WriteLine("R${0} => PA${1}", valor, valor * 24.78);  // Libra
        break;
    case '2':
        Console.WriteLine("US${0} => R${1}", valor, valor * 4.8);
        break;
    case '3':
        Console.WriteLine("EU${0} => R${1}", valor, valor * 5.12);
        break;
    case '4':
        Console.WriteLine("LI${0} => R${1}", valor, valor * 6.03);
        break;
    case '5':
        Console.WriteLine("PA${0} => R${1}", valor, valor * 0.040);
        break;
    default:
        Console.WriteLine("Opção invalida");
        break;
}
