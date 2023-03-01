using System;

class Fila_prioridade {
    static void Main(string[] args) {

        int[] filaPrioridade = { 10, 5, 15, 20, 8, 12 };        // criar uma fila com valores de prioridade
        
        Console.WriteLine("Fila original:");        // exibir a fila original
        foreach (int valor in filaPrioridade) {
            Console.WriteLine(valor);
        }

        Console.Write("\nDigite um valor divisor: ");        // solicitar o valor divisor
        int divisor = int.Parse(Console.ReadLine());

        // criar as novas filas
        int[] filaMaiorPrioridade = new int[filaPrioridade.Length];
        int[] filaMenorPrioridade = new int[filaPrioridade.Length];
        int tamanhoFilaMaior = 0;
        int tamanhoFilaMenor = 0;

        foreach (int valor in filaPrioridade) {     // dividir a fila original nas novas filas
            if (valor > divisor) {
                filaMaiorPrioridade[tamanhoFilaMaior++] = valor;
            } else {
                filaMenorPrioridade[tamanhoFilaMenor++] = valor;
            }
        }

        Console.WriteLine("\nFila de maior prioridade:");       // exibir as novas filas
        for (int i = 0; i < tamanhoFilaMaior; i++) {
            Console.WriteLine(filaMaiorPrioridade[i]);
        }

        Console.WriteLine("\nFila de menor prioridade:");
        for (int i = 0; i < tamanhoFilaMenor; i++) {
            Console.WriteLine(filaMenorPrioridade[i]);
        }
    }
}
