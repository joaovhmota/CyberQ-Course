bool isValidResult = false;
int  result        = 0;

do
{
	try
	{
		result = Convert.ToInt32(Console.ReadLine());

		isValidResult = (result < 0 || result > 10) ? false : true;
	} catch (Exception e)
	{
		Console.Clear();
		Console.ForegroundColor = ConsoleColor.Red;
		Console.Error.WriteLine(e.Message);
		Console.ForegroundColor = ConsoleColor.White;
	}
	
} while (!isValidResult);


Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Essa é uma nota válida!");
Console.ForegroundColor = ConsoleColor.White;