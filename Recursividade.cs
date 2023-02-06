using System;

class Fatorial {
    public int fat(int n) {     // função de 'fat' que fará o fatorial  
        int res;        // variável que vai armazena o resultado da operação
        if(n <= 1) {        // controle de parada - quando 'n' for menor que 1 a função irar parar e retorá o resultado
            res = 1;        
        } else {
            res = n * fat(n - 1);     // chamando a propria função subtraido -1 do valor passado e multiplicado o resultado pelo valor 'n' isto é uma recursividade
        }
        return res;     // retornando o 'fatorial'
    }
}
class Recusividade {
    static void Main() {

        Fatorial fator = new Fatorial();

        var res = fator.fat(5);

        Console.WriteLine("O fatorial é: {0} ", res);

    }
}