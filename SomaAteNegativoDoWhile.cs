using System;

 class Program
    {
        public static void Main(string[] args)
        {
        int soma = 0;
        int numero;

        Console.WriteLine("Digite números inteiros para somar (digite um numero negativo para sair):");
        
        
        do{
            numero = int.Parse(Console.ReadLine()); // Lê um número inteiro do usuário
            soma += numero; // Adiciona o número à soma
        }while (numero >= 0);

        Console.WriteLine("A soma dos números é: "+ soma);
            Console.ReadKey();
        }
        
    }
