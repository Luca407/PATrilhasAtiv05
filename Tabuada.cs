using System;

class Program
{
    static void Main()
    {
        	Console.Write("Digite um número inteiro: ");
            int numero;
            
            // Verifica se a entrada é um número válido
            if (!int.TryParse(Console.ReadLine(), out numero))
            {
                Console.WriteLine("Entrada inválida. Por favor, insira um número inteiro.");
                return;
            }

            int i = 1; // Inicializa o contador

            Console.WriteLine("\nTabuada do " + numero + ":");

            while (i <= 10) 
            {
                Console.WriteLine(numero + " x " + i + " = " + (numero * i));
                i++;  
            }

        Console.ReadKey();
    }
}

