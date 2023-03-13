using System;

public class Program {
    public static int Mdc(int x, int y) {       // função recursiva para calcular o 'MDC' de dois números
        if (y == 0) {        // se 'y' for 0 o 'mdc' será o 'x'
            return x;
        } else {    // caso ao contrario é chamanda a função recursiva "Mdc'
            return Mdc(y, x % y);
        }
    }
    public static void Main() {
        int x = 24;     // declando variáveis 'x' e 'y' com valores iniçiais
        int y = 36;
        int mdc = Mdc(x, y);         // chamada da função 'Mdc' para calcular o mdc entre 'x' e 'y'
        Console.WriteLine($"O mdc entre {x} e {y} é: {mdc}");       // imprimindo o resultado
    }    
}