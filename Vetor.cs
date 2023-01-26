using System;
class Vetor {
    static void Main() {
        int[] n = new int[5];        // declarando um vetor 'array' de 5 elementos
        n[0] = 10;        // armazenamento de valores em cada posição
        n[1] = 20;
        n[2] = 30;
        n[3] = 40;
        n[4] = 50;

        Console.WriteLine(n[1]);        // imprimindo valor da posição '1' do array

        int[] num1 = new int[3]{3, 2, 1};        // criando array 'num1' e atribuindo cada valor a cada indice
        Console.WriteLine(num1[0]);

        // int[] num2 = {6, 5, 4};      // atribuindo valores diretamente sem usar 'new'

        string[] cor = new string[3];       // tipo 'string' operador que indica ser um array '[]' nome 'cor' e 'new' indica o tamanho do vetor
        cor[0] = "vermelho";
        cor[1] = "amarelo";
        cor[2] = "azul";

        Console.WriteLine(cor[2]);
        
        
        
        
    }
}