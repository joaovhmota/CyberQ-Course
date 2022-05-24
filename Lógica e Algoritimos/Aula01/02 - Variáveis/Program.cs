// Console.WriteLine("Hello, World!");

string meuNome      = "João V. H. Mota";
char   minhaInicial = meuNome.ToCharArray()[0];
int    minhaIdade   = 17;
float  minhaAltura  = 1.72f;
bool   souEstudante = true;

switch (souEstudante)
{
    case true:
        Console.WriteLine("Meu nome é {0}, e minha letra inicial é {1}. \nTenho {2} anos e tenho {3}m de altura.", meuNome, minhaInicial, minhaIdade, minhaAltura);
        break;
    case false:
        Console.WriteLine("Apenas estudantes tem sua ficha exibida, desculpe-me.");
        break;
}