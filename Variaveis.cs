using System;

class Variaveis {
    static void Main() {
        byte n1 = 10;       /* variavel de 8 bits pode aramazena valor de 0 e 255 */
        int num = 0;        /* declarando variavel 'num' e importando o tipo de dados, atribuido um valor (0) a ela */
        string profissao = "Programador";       /* tipo primitivo de dados adiciona caracter com uso do apostrofo '' */
        float valor = 9.8f;       /* reservado para pontos flutuantes */
        string desenvolvedor = "Luis henrique silva ferreira";       /* pode armazena um texto maior, != de 'char' */
        
        var aux = 10;       /* o tipo d variavel 'var' e efinido na hora da compilacao pelo valor que a variavel possui */

        Console.WriteLine(profissao);
        Console.WriteLine(desenvolvedor);      /* comando para ler uma variavel e apresentar seu conteudo na tela */

        int num1, num2;        // declarando multiplas variáveis   

        num1 = 12;
        num2 = 6;

        Console.WriteLine("A multiplicação de " + num1 + " x " + num2 + " é igual a " + num1 * num2);

    }
}