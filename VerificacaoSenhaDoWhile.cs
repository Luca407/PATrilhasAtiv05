using System;

 class Program
    {
        public static void Main(string[] args)
        {
        	
        	Console.WriteLine("Digite uma senha");
        	string senhaCorreta = Console.ReadLine();
            string senhaDigitada;
            int tentativas = 3;

            do
            {
                Console.Write("Digite a senha: ");
                senhaDigitada = Console.ReadLine();

                if (senhaDigitada == senhaCorreta)
                {
                    Console.WriteLine("Acesso permitido!");
                    Console.ReadKey();
                    return;
                }

                tentativas--;
                Console.WriteLine("Senha incorreta! Tentativas restantes: "+ tentativas);
            } while (tentativas > 0);

            Console.WriteLine("Acesso bloqueado!");
            Console.ReadKey();
        }
        
    }
