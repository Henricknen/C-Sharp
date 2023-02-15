using System;

class Operadores {
    static void Main() {        // método 'Main' é uma ação executada pela classe 'Program'
        Console.WriteLine("Operadores aritméticos");
        Console.Write("10 + 10 = ");
        Console.WriteLine(10 + 10);

        Console.Write("10 - 10 = ");
        Console.WriteLine(10 - 10);

        Console.Write("10 * 10 = ");
        Console.WriteLine(10 * 10);

        Console.Write("10 / 10 = ");
        Console.WriteLine(10 / 10);

        Console.Write("10 / 3 o resto é = ");
        Console.WriteLine(10 % 3);

        Console.WriteLine("Operadores lógicos");
        Console.Write("56 é menor que 80 = ");        // comparação retornará 'true' ou 'false'
        Console.WriteLine(56 < 80);

        Console.Write("6 é menor ou igual a 9 = ");
        Console.WriteLine(6 <= 9);

        Console.Write("7 é maior que 19 = ");
        Console.WriteLine(7 > 19);

        Console.Write("10 é maior ou igual a 8 = ");
        Console.WriteLine(10 >= 8);

        Console.Write("23 é igual a 33 = ");
        Console.WriteLine(23 == 33);

        Console.Write("10 diferente de 21 = ");
        Console.WriteLine(10 != 21);

        // Console.ReadLine();     // 'ReadLine' serve para efetuar a proxima leitura no momento que é preçionado o enter
    }
}    