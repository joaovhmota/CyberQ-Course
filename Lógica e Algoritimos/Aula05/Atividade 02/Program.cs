while (true)
{
	DateTime centralTime = DateTime.Now.AddHours(3); // From Brazil
	Thread.Sleep(1000);
	Console.Clear();
	Console.WriteLine($"No Brasil,      são: {centralTime.AddHours(-3)}");
	Console.WriteLine($"Nos EUA,        são: {centralTime.AddHours(-8)}");
	Console.WriteLine($"No Japão,       são: {centralTime.AddHours(9)}");
	Console.WriteLine($"No Mexico,      são: {centralTime.AddHours(-7)}");
	Console.WriteLine($"No Chile,       são: {centralTime.AddHours(-5)}");
	Console.WriteLine($"No Alasca,      são: {centralTime.AddHours(-10)}");
	Console.WriteLine($"Na Africa do Sul, é: {centralTime.AddHours(2)}");
	Console.WriteLine($"Na China,       são: {centralTime.AddHours(8)}");
	Console.WriteLine($"Em Moscow,      são: {centralTime.AddHours(3)}");
	Console.WriteLine($"Em Sidney,      são: {centralTime.AddHours(10)}");
	
}