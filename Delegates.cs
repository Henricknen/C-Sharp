using System;

delegate int Op(int n1, int n2);        // criação de 'delegate' com dois parâmetros 'int' que conterá os método de 'soma' e 'multi'
class Mat {     // classe 'Mat'
    public static int soma(int n1, int n2) {        // método de 'soma' static estatico
        return n1 + n2;
    }

    public static int mult(int n1, int n2) {        // método de 'mutiplicação'
        return n1 * n2;
    }
}

class Delegates {
    static void Main() {

        int res;        // variável 'res' reçeberá o retorno

        Op d1 = new Op(Mat.soma);       // declaração do 'delegate' chamará 'd1' com método 'soma' que o 'delegate' fará referênçia

        res = d1(10, 45);       // armazenando na variável 'res' a soma e dois valores

        Console.WriteLine("A Soma: {0}", res);

        d1 = new Op(Mat.mult);      // agora 'deegate' aponta para função 'mult'

        res = d1(10, 45);

        Console.WriteLine("A multiplicação é: {0}", res);

    }
}