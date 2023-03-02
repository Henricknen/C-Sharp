using System;
using System.Collections.Generic;

class Maior_menor_media_aritmetica {
    static void Main(string[] args) {
        List<double> fila = new List<double>();     // lista vazia para armazenar os números digitados

        while (true) {
            Console.Write("Digite um número (ou 'fim' para encerrar): ");
            string numero = Console.ReadLine();
            if (numero == "fim") {
                break;
            }
            try {
                fila.Add(double.Parse(numero));
            } catch (FormatException) {
                Console.WriteLine("Valor inválido. Digite um número ou 'fim' para encerrar.");
            }
        }

        if (fila.Count == 0) {
            Console.WriteLine("Nenhum número foi digitado.");
        } else {
            double maior = fila.Max();
            double menor = fila.Min();
            double media = fila.Average();

            Console.WriteLine("O maior número é: " + maior);
            Console.WriteLine("O menor número é: " + menor);
            Console.WriteLine("A média aritmética dos números é: " + media);
        }
    }
}
