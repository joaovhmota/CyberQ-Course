void conjulgarAR(string str)
{
	Console.WriteLine($"Eu {str.Split("ar")[0]}o");
	Console.WriteLine($"Tu {str.Split("ar")[0]}as");
	Console.WriteLine($"Eles {str.Split("ar")[0]}am");
	Console.WriteLine($"Nos {str.Split("ar")[0]}amos");
	Console.WriteLine($"Vós {str.Split("ar")[0]}áis");
	Console.WriteLine($"Eles {str.Split("ar")[0]}am");
	Console.WriteLine();
}

conjulgarAR("andar");
conjulgarAR("amar");
conjulgarAR("aproximar");