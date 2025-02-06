using System;

class Program
{
    static void Main()
    {
    	
    	Console.Write("Digite um número inteiro positivo: ");
        int numero = int.Parse(Console.ReadLine());
        int i = 0;
        
    	do {
         if (i % 2 == 0)
            Console.WriteLine(i);
            i++;
    	} while (i <= numero);

        Console.ReadKey();
    }
}
