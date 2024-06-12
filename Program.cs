using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int numeroAleatorio = random.Next(1, 101);
        int tentativas = 0;
        bool acertou = false;

        Console.WriteLine("Bem-vindo ao jogo de adivinhação!");
        Console.WriteLine("Tente adivinhar o número entre 1 e 100.");

        while (!acertou)
        {
            Console.Write("Digite sua tentativa: ");
            int tentativa = Convert.ToInt32(Console.ReadLine());
            tentativas++;

            if (tentativa < numeroAleatorio)
            {
                Console.WriteLine("Tente um número maior.");
            }
            else if (tentativa > numeroAleatorio)
            {
                Console.WriteLine("Tente um número menor.");
            }
            else
            {
                Console.WriteLine($"Parabéns! Você acertou o número {numeroAleatorio} em {tentativas} tentativas.");
                acertou = true;
            }
        }

        Console.WriteLine("Obrigado por jogar!");
    }
}
