using System;

class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Escolha uma cor (vermelho, azul ou verde): ");
            string cor = Console.ReadLine().ToLower();
            switch (cor)
            {
                case "vermelho": Console.WriteLine("Você escolheu Vermelho"); break;
                case "azul": Console.WriteLine("Você escolheu Azul"); break;
                case "verde": Console.WriteLine("Você escolheu Verde"); break;
                default: Console.WriteLine("Cor inválida"); break;
            }
            Console.ReadKey();
        }
    }
