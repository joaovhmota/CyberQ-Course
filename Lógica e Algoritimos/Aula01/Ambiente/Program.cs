using System;

namespace Ambiente
{ 
	public static class Program
	{
		static void showTitle(string title = "Lorem Ipsum")
		{ 
			Console.SetCursorPosition( (Console.WindowWidth - title.Length) / 2, Console.CursorTop );
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine( title );
			Console.ForegroundColor = ConsoleColor.White;
		}
		static void Main(string[] args)
		{
			
		}
	}
}