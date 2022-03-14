using System;
class escopo_de_variaveis {
    static int num = 10;        /* variavel global */
    static void Main() {
        int num2 = 0;        /* 'num' é o escopo do metodo 'Main'( metodo principal) */
                Console.WriteLine(num);

    }

    /*void teste() {
        int num3 = 0;        /* variavel local */
    } */
}