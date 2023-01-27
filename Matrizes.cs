using System;
class Matrizes {
    static void Main() {
        int[,] n = new int[3, 5];      // '[,]' indica que é um array bidimensional e [3, 5] é  criação de um array com 3 linhas e 5 colunas

        n[0, 0] = 01;       // inserindo valores da primeira linha [linha, coluna]
        n[0, 1] = 10;
        n[0, 2] = 20;
        n[0, 3] = 30;
        n[0, 4] = 40;
    
        n[1, 0] = 08;       // inserindo valores da segunda linha [linha, coluna]
        n[1, 1] = 11;
        n[1, 2] = 27;
        n[1, 3] = 89;
        n[1, 4] = 101;
    
        n[2, 0] = 01;       // inserindo valores da terçeira linha [linha, coluna]
        n[2, 1] = 17;
        n[2, 2] = 49;
        n[2, 3] = 32;
        n[2, 4] = 77;

        Console.WriteLine(n[1, 3]);     // imprimindo um valor 'espeçifico', da primeira linha da terçeira coluna
    
    }
}
