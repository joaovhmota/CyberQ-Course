// Console.WriteLine("Hello, World!");

double distance;

Console.Write("Diite uma medida: "); distance = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("{0}m => {1}km", distance, distance / 1000);
Console.WriteLine("{0}km => {1}m", distance, distance * 1000);