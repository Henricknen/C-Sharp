using System;

class Program {
    static void Main() {
        for (int i = 0; i <= 10; i++) {     // loop chama a função recursiva
            Console.WriteLine($"FibRecursive({i}) = {FibRecursive(i)}");
        }
    }
    public static int FibRecursive(int n) {     // função recursiva recebe um parâmetro inteiro
        if (n == 0 || n == 1) {
            return n;
        }
        else 
            return FibRecursive(n - 1) + FibRecursive(n - 2);       // chamando função recursiva
        }
    }
