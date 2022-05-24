// Console.WriteLine("Hello, World!");

float media  = 8.0f;
int   faltas = 10;

// Operador E (&&)
Console.WriteLine( "Operador E: {0}", (media >= 7 && faltas < 10) );

// Operador OU (||)
Console.WriteLine( "Operador OU: {0}", (media >= 7 || faltas < 10) );

// Operador de Negação (!)
Console.WriteLine( "Operador NÃO: {0}", !(media >= 7 && faltas < 10) );

// Operador XOR (^)
Console.WriteLine( "Operador XOR: {0}", (media >= 7 ^ faltas < 10) );
