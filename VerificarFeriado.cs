using System;

 class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite uma data (AAAA-MM-DD): ");
            DateTime feriado = DateTime.Parse(Console.ReadLine());
            if (feriado.Month == 1 && feriado.Day == 1 || feriado.Month == 12 && feriado.Day == 25)
            {
                Console.WriteLine("É um feriado nacional!");
            }
            else
            {
                Console.WriteLine("Não é um feriado nacional.");
            }
            Console.ReadKey();
        }
    }
