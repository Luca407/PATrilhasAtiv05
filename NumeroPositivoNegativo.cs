using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Digite um número inteiro: ");
        int num = int.Parse(Console.ReadLine());

        // Usando uma variável auxiliar para categorizar o número
        int categoria = num == 0 ? 0 : (num > 0 ? 1 : -1);

        switch (categoria)
        {
            case 1:
                Console.WriteLine("Positivo");
                break;
            case -1:
                Console.WriteLine("Negativo");
                break;
            case 0:
                Console.WriteLine("Zero");
                break;
            default:
                Console.WriteLine("Entrada inválida");
                break;
        }

        Console.ReadKey();
    }
}
