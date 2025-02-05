using System;

 class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Escolha um tamanho (P, M ou G): ");
            char tamanho = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();
            switch (tamanho)
            {
                case 'P': Console.WriteLine("Preço: R$ 30,00"); break;
                case 'M': Console.WriteLine("Preço: R$ 40,00"); break;
                case 'G': Console.WriteLine("Preço: R$ 50,00"); break;
                default: Console.WriteLine("Tamanho inválido"); break;
            }
            Console.ReadKey();
        }
        
    }
