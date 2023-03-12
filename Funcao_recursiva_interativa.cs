using System;

public class Funcao_recursiva_interativa {
    public static void iterativa(int x) {       // função recursiva para imprimir a 'tabela de cubos' de 1 até 'x'
        if (x > 0) {        // enquanto 'x' for maior que 0 chama novamente a função interativa 'recursividade'
            iterativa(x - 1);       // chamando a função 'interativa' diminuindo 1
            int exp = x * x * x;        // calculando o cubo de 'x'
            Console.WriteLine($"O número {x} ao cubo é: {exp}.");       // imprimindo o resultado 
        }
    }
    
    public static void Main() {
        int n = 5;      // definição do valor máximo da tabela de cubos
        Console.WriteLine($"Tabela de cubos de 1 até {n}:");
        iterativa(n);       // chamando a função 'interativa' passando 'n' como parâmetro
    }
}