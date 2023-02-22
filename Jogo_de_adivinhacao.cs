using System;

class Jogo_de_adivinhacao {
    static void Main() {
        Random random = new Random();       // 'Random' gera numeros aleatorios
        int numero = random.Next(1, 101);
        int tentativas = 0;
        int palpite;

        Console.WriteLine("Bem-vindo ao jogo de adivinhação!");
        Console.WriteLine("Estou pensando em um número entre 1 e 100.");
        Console.WriteLine("Tente adivinhar qual é o número.");

        do {
            Console.Write("Digite o seu palpite: ");
            palpite = int.Parse(Console.ReadLine());
            tentativas++;

            if (palpite < numero) {
                Console.WriteLine("O número que estou pensando é maior.");
            } else if (palpite > numero) {
                Console.WriteLine("O número que estou pensando é menor.");
            }
        } while (palpite != numero);

        Console.WriteLine($"Parabéns, você acertou em {tentativas} tentativas!");

    }
}
