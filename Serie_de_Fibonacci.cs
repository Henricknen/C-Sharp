using System;

namespace Fibonacci {
    class Serie_de_Fibonacci {
        static int FibonacciRecursive(int n) {      // Função recursiva para calcular o n-ésimo termo da série de Fibonacci
            if (n == 0) {
                return 0;
            }
            else if (n == 1) {
                return 1;
            } else {
                return FibonacciRecursive(n-1) + FibonacciRecursive(n-2);       // Calcula o n-ésimo termo somando os dois termos anteriores
            }
        }

        static void Main(string[] args) {
            Console.Write("Digite o n-ésimo termo da série de Fibonacci que deseja calcular: ");
            int n = int.Parse(Console.ReadLine());
            int fib = FibonacciRecursive(n);        // Chama a função FibonacciRecursive para calcular o termo
            Console.WriteLine("O " + n + "º termo da série de Fibonacci é: " + fib);        // Imprime o resultado
        }
    }
}