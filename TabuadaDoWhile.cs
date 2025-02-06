using System;

class Program
{
    static void Main()
    {
    	
    		Console.Write("Digite um número inteiro: ");
            int numero;

            if (!int.TryParse(Console.ReadLine(), out numero))
            {
                Console.WriteLine("Entrada inválida. Por favor, insira um número inteiro.");
                return;
            }

            int i = 1;

            Console.WriteLine("\nTabuada do " + numero + ":");

            do
            {
				Console.WriteLine(numero + " x " + i + " = " + (numero * i));
                i++; 
            }while (i <= 10);


        Console.ReadKey();
    }
}
