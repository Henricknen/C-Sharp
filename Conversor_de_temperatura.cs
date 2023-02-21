using System;

class Conversor_de_temperatura {
    static void Main() {
        double celsius, fahrenheit;

        Console.Write("Digite a temperatura em graus Celsius: ");
        celsius = double.Parse(Console.ReadLine());

        fahrenheit = celsius * 1.8 + 32;

        Console.WriteLine($"A temperatura em Fahrenheit é: {fahrenheit}");

        // Console.ReadLine();
    }
}
