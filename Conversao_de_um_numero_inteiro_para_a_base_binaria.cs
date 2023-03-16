using System;

public class Conversao_de_um_numero_inteiro_para_a_base_binaria {
    public static void Main() {
        int x = 20;
        Console.Write("A representação binária de " + x + " é: ");
        conversor(x);       // chama a função conversor para converter o número inteiro x em binário
    }
    
    public static void conversor(int x) {
        if (x > 0) {        // verifique se o número inteiro é maior que 0
            conversor(x / 2);        // chama a função novamente com o quociente da divisão por 2
            Console.Write(x % 2);       // imprime o resto da divisão por 2 na tela
        }
    }
}
