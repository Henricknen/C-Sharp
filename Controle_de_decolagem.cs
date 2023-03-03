using System;

namespace ControlePistaDecolagem
{
    class Controle_de_decolagem {
        static void Main(string[] args)
        {
            const int MAX_AVIOES = 100;     // numero maximo de avioes
            string[] filaAvioes = new string[MAX_AVIOES];
            int inicioFila = 0;     // 'inicioFila' controla o inicio
            int fimFila = 0;    // 'fimFila' controla o fim

            while (true) {      // loop infinito
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("a) Adicionar um avião na fila de espera");
                Console.WriteLine("b) Consultar a quantidade de aviões aguardando na fila");
                Console.WriteLine("c) Autorizar a decolagem de um avião da fila");
                Console.WriteLine("d) Listar os números de todos os aviões na fila");
                Console.WriteLine("e) Consultar o número do primeiro avião da fila");
                Console.WriteLine("f) Encerrar o programa");

                string opcao = Console.ReadLine();

                switch (opcao.ToLower()) {      // 'switch' executa a opreção escolhida
                    case "a":
                        if (fimFila < MAX_AVIOES) {
                            Console.WriteLine("Digite o número do avião:");
                            string numeroAviao = Console.ReadLine();
                            filaAvioes[fimFila] = numeroAviao;
                            fimFila++;
                            Console.WriteLine($"Avião {numeroAviao} adicionado à fila de espera.");
                        } else {
                            Console.WriteLine("A fila de espera está cheia.");
                        }
                        break;

                    case "b":
                        Console.WriteLine($"Há {fimFila - inicioFila} aviões aguardando na fila de espera.");
                        break;

                    case "c":
                        if (inicioFila == fimFila)    {
                            Console.WriteLine("Não há aviões aguardando na fila de espera.");
                        } else {
                            string numeroAviaoDecolado = filaAvioes[inicioFila];
                            inicioFila++;
                            Console.WriteLine($"Avião {numeroAviaoDecolado} decolado.");
                        }
                        break;

                    case "d":
                        Console.WriteLine("Aviões na fila de espera:");
                        for (int i = inicioFila; i < fimFila; i++) {
                            Console.WriteLine(filaAvioes[i]);
                        }
                        break;

                    case "e":
                        if (inicioFila == fimFila) {
                            Console.WriteLine("Não há aviões aguardando na fila de espera.");
                        } else {
                            string numeroPrimeiroAviao = filaAvioes[inicioFila];
                            Console.WriteLine($"O primeiro avião na fila de espera é o {numeroPrimeiroAviao}.");
                        }
                        break;

                    case "f":
                        Console.WriteLine("Encerrando o programa...");
                        return;

                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}
