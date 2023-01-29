using System;
class passagem_por_valor_epor_referencia {
    static void Main() {
        int num1 = 50;   // variável local 'num' iniçializado com valor 10
        dobrar1(ref num1);        // chamando método 'dobrar' com variável 'num' e o operador 'ref' indica que está sendo feita uma passagem por referênçia
        Console.WriteLine(num1);

        int num2 = 75;
        dobrar2(num2);      // o valor da variável não será alterado pois está recebendo o valor por 'ref' referênçia
        Console.WriteLine(num2);
    }

    static void dobrar1(ref int valor) {     // método dobrar1 ultilizando 'ref' faz uma passagem por referênçia
        valor *= 2;
    }

    static void dobrar2(int valor) {        // método dobrar2 faz uma passagem por valor
        valor *= 2;
    }
}