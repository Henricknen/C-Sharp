using System;

class Mdc {
    static void Main(string[] args) {
        int x = 12;
        int y = 18;
        int mdc = MDC(x, y);
        Console.WriteLine("O MDC de {0} e {1} é: {2}", x, y, mdc);
    }

    static int MDC(int x, int y) {
        if (x == y) {
            return x;
        }
        else if (x < y) {
            return MDC(y, x);
        }
        else {
            return MDC(x - y, y);
        }
    }
}
