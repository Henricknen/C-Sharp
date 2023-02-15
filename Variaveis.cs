using System;

class Variaveis {
    static void Main() {
    Console.WriteLine("-----Variaveis-----");
//  tipo    nome
    string texto;       // variável 'texto'
    texto = "Ola mundo";     // atribuindo texto 'Ola mundo' a variável 'texto'
    Console.WriteLine(texto);       // imprimindo valor da variável 'texto' na tela

    texto = "Codificando em C#";        // alterando o valor da variável 'texto'
    Console.WriteLine(texto);       // e tem que imprimir novamente

    int n1= 2;      // variaveis 'n1 e n2'
    int n2= 4;
    Console.WriteLine(n1 + " é maior que " + n2 + ":" + (n1 > n2));
    Console.WriteLine(n1 + " é menor que " + n2 + ":" + (n1 < n2));
    Console.WriteLine(n1 + " é diferente de " + n2 + ":" + (n1 != n2));
    Console.WriteLine(n1 + " é igual a " + n2 + ":" + (n1 == n2));

    Console.WriteLine("-----Constantes-----");
    Console.WriteLine("Luis_henrique");      // texto 'Luis_henrique' é uma constante lietral que nunca vai mudar
    Console.WriteLine(10);     // constante numérica
    // Console.ReadKey();      // 'ReadKey' faz a leitura do teclado que captura a tecla pressionada
    }
}