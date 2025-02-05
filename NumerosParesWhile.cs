using System;

 class Program
    {
        public static void Main(string[] args)
        {
      		Console.Write("Digite um número inteiro positivo: ");
            int numero = int.Parse(Console.ReadLine());
            int i = 0;

            while (i <= numero)
            {
                if (i % 2 == 0)
                    Console.Write(i);
                i++;
            Console.ReadKey();
        }
        
    }
        
 }
