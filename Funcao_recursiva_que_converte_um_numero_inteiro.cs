using System;

class Program
{
    static void Main() {        // solicita o número inteiro para o usuário
        Console.Write("Digite um número inteiro: ");
        int num = int.Parse(Console.ReadLine());

        string binary = DecimalToBinary(num);       // converte o número para a base binária usando a função recursiva

        Console.WriteLine($"O número {num} em binário é: {binary}");        // exibe o resultado
    }

    public static string DecimalToBinary(int n) {
        if (n == 0) {
            return "0";
        }
        else if (n == 1) {
            return "1";
        }
        else {
            string binary = DecimalToBinary(n / 2);            // chama a função recursivamente para n/2
            if (n % 2 == 0) {            // verifica se n é par ou ímpar e adiciona 0 ou 1 à string binária
                return binary + "0";
            }
            else {
                return binary + "1";
            }
        }
    }
}
