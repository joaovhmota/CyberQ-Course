// Console.WriteLine("Hello, World!");

double salario;

Console.Write("Informe o seu salário: R$"); salario = Convert.ToDouble(Console.ReadLine());

if (salario >= 1903.99 && salario <= 2826.65)
{
    salario *= 0.075;
}
else if (salario <= 3751.05)
{
    salario *= 0.15;
}
else if (salario <= 4664.68)
{
    salario *= 0.225;
}
else if (salario >=4664.69)
{
    salario *= 0.275;
}

Console.WriteLine("O valor a ser pago é de: {0}", salario);
