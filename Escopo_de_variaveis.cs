using System;
class Escopo_de_variaveis {

    static int num = 10;       // variaveis globais criada na 'classe' antes da declaração de qualquer método
    static void Main() {
        int num2 = 5;    // variável 'num' declarada dentro do método principal 'Main' então está variável tem este 'escopo' (area de atuação)
        Console.WriteLine(num2 + ": é uma variável local e " + num + ": é uma variável global" );     // vai fazer a impressão da variável global 'num'
    }
}