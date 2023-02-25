using System;

class Conversao {
    static void Main() {
        Console.Write("Digite um número inteiro em decimal: ");
        int decimalNumber = int.Parse(Console.ReadLine());
        string binaryNumber = "";

        while (decimalNumber > 0) {
            int remainder = decimalNumber % 2;
            binaryNumber = remainder.ToString() + binaryNumber;
            decimalNumber = decimalNumber / 2;
        }

        Console.WriteLine("O número em binário é: " + binaryNumber);
    }
}
