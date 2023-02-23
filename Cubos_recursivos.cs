using System;

public class Cubos_recursivos {
    public static void Cubos(int n) {
        CubosRecursivo(n, 1);
    }

    public static void CubosRecursivo(int n, int i) {
        if (i <= n) {
            Console.WriteLine(i * i * i);
            CubosRecursivo(n, i + 1);
        }
    }

    public static void Main() {
        Cubos(5); 
    }
}
