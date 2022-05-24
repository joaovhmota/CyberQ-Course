// Console.WriteLine("Hello, World!");

int acertos = 0;

Console.WriteLine("Qual é o número? [Quatro Zeros Dois Dois]");
Console.WriteLine("1 - 4022");
Console.WriteLine("2 - 000022");
if (Console.ReadLine().ToCharArray()[0] == '2') acertos++; 

Console.WriteLine("Se agora fosse meia noite, quantas horas seria em Tóquio?");
Console.WriteLine("1 - 10");
Console.WriteLine("2 - 12");
if (Console.ReadLine().ToCharArray()[0] == '2') acertos++;

Console.WriteLine("Quantos cm tem 1 metro?");
Console.WriteLine("1 - 1000cm");
Console.WriteLine("2 - 100cm");
if (Console.ReadLine().ToCharArray()[0] == '2') acertos++;

Console.WriteLine("Como se lê 自動販売機?");
Console.WriteLine("1 - Jidouhanbaiki");
Console.WriteLine("2 - Onegaishimasu");
if (Console.ReadLine().ToCharArray()[0] == '1') acertos++;

Console.WriteLine("Qual a cor do cavalo branco de Napoleão?");
Console.WriteLine("1 - Branco");
Console.WriteLine("2 - Preto");
if (Console.ReadLine().ToCharArray()[0] == '1') acertos++;

Console.WriteLine("Você teve um total de {0} acerto(s)!", acertos); 
