using System;

	class Program
	{
		public static void Main(string[] args)
		{ 
			Console.Write("Digite sua data de nascimento (AAAA-MM-DD): ");
            DateTime nascimento = DateTime.Parse(Console.ReadLine());
            
            int idade = DateTime.Now.Year - nascimento.Year;
            
            if (DateTime.Now < nascimento.AddYears(idade)) idade--;
            Console.WriteLine("Idade: " + idade);
            Console.ReadKey();
		}
	}
