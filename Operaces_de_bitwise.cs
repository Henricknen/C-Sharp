using System;

class Operaces_de_bitwise{
    static void Main() {
        int num = 10;
        int num1 = 30;

        num = num << 1;     // '<<' é um sinal de bitwise que desloca para a esquerda, que duplicará o valor de 'num'
        num1 = num1 >> 1;         // se o bitwise for a direita '>>'  reduzirá o valor de 'num1' pela metade

        Console.WriteLine(num);
        Console.WriteLine(num1);
    }
}