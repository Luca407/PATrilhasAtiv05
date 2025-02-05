using System;

	class Program
	{
		public static void Main(string[] args)
		{ 
		Console.Write("Digite a primeira data (AAAA-MM-DD): ");
       		DateTime data1 = DateTime.Parse(Console.ReadLine());
      		Console.Write("Digite a segunda data (AAAA-MM-DD): ");
		DateTime data2 = DateTime.Parse(Console.ReadLine());
        
        Console.WriteLine("Diferença em dias: " + (data2 - data1).Days);
        Console.ReadKey();
		}
	}
