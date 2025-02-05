using System;

 class Program
    {
        public static void Main(string[] args)
        {
        int soma = 0;
        int numero;

        Console.WriteLine("Digite números inteiros para somar (digite um numero negativo para sair):");
        
        while (true)
        {
            numero = int.Parse(Console.ReadLine()); // Lê um número inteiro do usuário
            if (numero < 0) break; // Se for 0, sai do loop
            soma += numero; // Adiciona o número à soma
        }

        Console.WriteLine("A soma dos números é: "+ soma);
            Console.ReadKey();
        }
        
    }
