using System;
class Operadores_e_operacoes {
    static void Main() {
                                        // o caculo é inicado dentro dentro dos parenteses '()'
        int res1 = (10 + 5) * 2;       // '=' é operador de atribuição, '+, *' é um operadores matemáticos

        bool res2 = 10 != 5;        // tipo 'bool' retornará 'true' ou 'false', >, <, >=, <=, != são operadores relacionais

        int num = 10;

        // num = num + 1;      // incrementando a variável 'num'
        // num += 1;      // incrementando a variável 'num'
        num ++;      // incremendo somente de 1

        bool res3 = (5 > 3) | (10 < 5);        // operador lógico '|' OR que retornará 'true' se uma das duas condições for 'true'
        bool res4 = (5 > 7) & (10 > 5);     // operador lógico '&' retornará 'true' se se todas condições forem 'true'
        

        Console.WriteLine(res1);
        Console.WriteLine(res2);
        Console.WriteLine(num);
        Console.WriteLine(res3);
        Console.WriteLine(res4);

    }
}