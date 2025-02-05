using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Digite uma letra: ");
        char letra = char.ToLower(Console.ReadKey().KeyChar);
        Console.WriteLine();

        switch (letra)
        {
            case 'a':
            case 'e':
            case 'i':
            case 'o':
            case 'u':
                Console.WriteLine("É uma vogal");
                break;
            default:
                if (char.IsLetter(letra))
                    Console.WriteLine("É uma consoante");
                else
                    Console.WriteLine("Não é uma letra válida");
                break;
        }

        Console.ReadKey();
    }
}
