using System;

class Funcao_recursiva_potencia {     // Função que calcula a exponenciação de um número base elevado a um expoente utilizando recursão   
    static int Exponencial(int numBase, int expoente) {
        if (expoente > 0) {     // se 'expoente' for maior que 0
            return numBase * Exponencial(numBase, expoente - 1);        // é chamada a função 'Exponencial' novamente passando a base e o expoente reduzido em 1 e multiplicando o resultado pela base
        } else {        // caso contrário é retornado 1
            return 1;
        }
    }

    static void Main() {
        int numBase = 2;
        int expoente = 3;
        int resultado = Exponencial(numBase, expoente);
        Console.WriteLine($"{numBase}^{expoente} = {resultado}");
    }
}
