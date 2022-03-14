using System;

class Oper {
     static void Main() {
         int res = (10 + 5) * 2;      /* operadores de atribuicao, soma e multiplicacao */

        bool res2 = 10 < 5;        /* operadores relacionais retorna verdadeiro ou falso */

        int num = 10;
        num = num + 5;        /* operador de incremento */
        num--;                     /* decremento */
        num *= 2;                   /* multiplicacao */

        bool res3 = (5 > 3) | (1 < 5);        /* operador logico OR/ OU */
        bool res4 = (5 > 3) & (1 < 5);      /* operador logico AND/ E */
        
        Console.WriteLine(res);

        Console.WriteLine(res2);

        Console.WriteLine(num);

        Console.WriteLine(res3);

        Console.WriteLine(res4);
     }
}