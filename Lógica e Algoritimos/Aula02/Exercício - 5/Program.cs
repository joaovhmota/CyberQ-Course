int start, end, odd = 0, even = 0, n1, n2;

Console.Write("Informe o início: "); n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Informe o fim: "); n2 = Convert.ToInt32(Console.ReadLine());  

start = (n1 < n2) ? n1 : n2;
end = (n1 > n2) ? n1 : n2;

Console.Clear();
for (int i = start; i <= end; i++)
{
	Console.Write(i + " ");
	if (i % 2 == 0) even++;
	else odd++;
}


Console.WriteLine("\nPares: {0}", even);
Console.WriteLine("Ímpares: {0}", odd);