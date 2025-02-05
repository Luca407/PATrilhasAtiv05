using System;

 class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Escolha uma opção:\n1 - Opção 1\n2 - Opção 2\n3 - Opção 3");
            int escolha = int.Parse(Console.ReadLine());
            switch (escolha)
            {
                case 1: Console.WriteLine("Você escolheu a Opção 1"); break;
                case 2: Console.WriteLine("Você escolheu a Opção 2"); break;
                case 3: Console.WriteLine("Você escolheu a Opção 3"); break;
                default: Console.WriteLine("Opção inválida"); break;
            }
            Console.ReadKey();
        }
    }
