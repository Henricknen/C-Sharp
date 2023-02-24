using System;

class Funcao_retorna_valor {
    static void Main(string[] args) {
        int valorRetornado = Recursao(27);
        Console.WriteLine(valorRetornado);
    }

    public static int Recursao(int n) {
        if (n <= 10) {
            return n * 2;
        }
        else {
            return Recursao(Recursao(n / 3));
        }
    }
}
