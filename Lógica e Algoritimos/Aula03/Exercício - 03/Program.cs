const int limit = 2;
int[] nums1 = new int[limit];
int[] nums2 = new int[limit];
char opt = ' ';

for (int i = 0; i < limit; i++)
{
	try
	{
		Console.Write($"Informe o {i+1}° para o 1° Array: "); nums1[i] = Convert.ToInt32(Console.ReadLine()!);
		Console.Write($"Informe o {i+1}° para o 2° Array: "); nums2[i] = Convert.ToInt32(Console.ReadLine()!);
		Console.Clear();
	} catch (Exception ex) 
	{
		Console.ForegroundColor = ConsoleColor.Red;
		Console.WriteLine($" ・ [{ex.Message}] ・ ");
		Console.ForegroundColor = ConsoleColor.White;
	};
}

do
{
	try
	{
		Console.Write("Agora escola uma operação matemática [+ - / * %]:");
		opt = Console.ReadLine()!.ToCharArray()[0];
		if (opt == '+' || opt == '-' || opt == '/' || opt == '*' || opt == '%') break;
	}
	catch (Exception ex) 
	{
		Console.ForegroundColor = ConsoleColor.Red;
		Console.WriteLine($" ・ [{ex.Message}] ・ ");
		Console.ForegroundColor = ConsoleColor.White;
	};
} while (true);

switch (opt)
{
	case '+':
		for (int i = 0; i < limit; i++)
		{
			try
			{
				Console.WriteLine($"{nums1[i]} + {nums2[i]} = {nums1[i] + nums2[i]}");
			} catch (Exception ex)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine($" ・ {ex.Message} ・ ");
				Console.ForegroundColor = ConsoleColor.White;
			}
		}
		break;

	case '-':
		for (int i = 0; i < limit; i++)
		{
			try
			{
				Console.WriteLine($"{nums1[i]} - {nums2[i]} = {nums1[i] - nums2[i]}");
			} catch (Exception ex)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine($" ・ {ex.Message} ・ ");
				Console.ForegroundColor = ConsoleColor.White;
			}
		}
		break;

	case '/':
		for (int i = 0; i < limit; i++)
		{
			try
			{
				Console.WriteLine($"{nums1[i]} / {nums2[i]} = {nums1[i] / nums2[i]}");
			} catch (Exception ex)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine($" ・ {ex.Message} ・ ");
				Console.ForegroundColor = ConsoleColor.White;
			}
		}
		break;

	case '*':
		for (int i = 0; i < limit; i++)
		{
			try
			{
				Console.WriteLine($"{nums1[i]} * {nums2[i]} = {nums1[i] * nums2[i]}");
			} catch (Exception ex)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine($" ・ {ex.Message} ・ ");
				Console.ForegroundColor = ConsoleColor.White;
			}
		}
		break;

	case '%':
		for (int i = 0; i < limit; i++)
		{
			try
			{
				Console.WriteLine($"{nums1[i]} % {nums2[i]} = {nums1[i] % nums2[i]}");
			} catch (Exception ex)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine($" ・ {ex.Message} ・ ");
				Console.ForegroundColor = ConsoleColor.White;
			}
		}
		break;
}