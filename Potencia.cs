using System;

public class Potencia {
    public static double potencia(double x, int y) {
        if (y == 0) {
            return 1;
        }
        else if (y == 1) {
            return x;
        }
        else if (y < 0) {
            return 1 / potencia(x, -y);
        }
        else if (y % 2 == 0) {
            return potencia(x*x, y/2);
        }
        else {
            return x * potencia(x*x, (y-1)/2);
        }
    }

    public static void Main() {
        double resultado = potencia(2, 3);
        Console.WriteLine(resultado);
    }
}
