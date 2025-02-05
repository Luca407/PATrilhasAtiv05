using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite um número: ");
        int x = Convert.ToInt32(Console.ReadLine());

        if (x < 0)
        {
            Console.WriteLine("Só será aceito números acima de 0");
        }
        else
        {
            Console.WriteLine("Os números pares entre o número digitado e 0 são:");
            while (x >= 0)
            {
                if (x % 2 == 0)
                {
                    Console.WriteLine(x);
                }
                x--;
            }
        }

        Console.ReadKey();
    }
}
