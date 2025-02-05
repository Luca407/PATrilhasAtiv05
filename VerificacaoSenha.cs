using System;

 class Program
    {
        public static void Main(string[] args)
        {
         string senhaCorreta = "1234";
            string senhaDigitada;
            int tentativas = 3;

            while (tentativas > 0)
            {
                Console.Write("Digite a senha: ");
                senhaDigitada = Console.ReadLine();

                if (senhaDigitada == senhaCorreta)
                {
                    Console.WriteLine("Acesso permitido!");
                    return;
                }

                tentativas--;
                Console.WriteLine("Senha incorreta! Tentativas restantes: "+ tentativas);
            }

            Console.WriteLine("Acesso bloqueado!");
        }
        
    }
