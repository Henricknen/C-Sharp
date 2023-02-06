using System;

class Calc {        // classe 'Calc'

    public int soma(int n1, int n2) {     // método 'soma' reçebendo dois parâmetros
        return n1 + n2;
    }

    public int soma(int n1, int n2, int n3) {     // método com mesmo nome 'soma' com 3 parâmetros é uma sobrecarga
        return n1 + n2 + n3;
    }

    public int soma(int n1, int n2, int n3, int n4) {     // método com mesmo nome 'soma' com 4 parâmetros é uma sobrecarga
        return n1 + n2 + n3 + n4;
    }

    public double soma(double n1, double n2) {     //  criando método com parâmetros do tipo 'double'
        return n1 + n2;
    }

    public int soma(params int[]n) {     //  passando um número indeterminado de prâmetros função recebe 'int'
        int s = 0;      // variável 's' iniçiada em 0
        for(int i = 0; i <n.Length; i++) {      // 'for' vai percorre e retorna a soma
            s += n[i];
        }
    return s;
    }

    public double soma(params double[]n) {      // função com mesmo nome que reçebe 'double' é uma sobrecarga
        double s = 0;
        for(int i = 0; i <n.Length; i++) {      // 'for' vai percorre e retorna a soma
            s += n[i];
        }
    return s;
    }
}
class Sobrecarga_de_metodos {
    static void Main() {

        int res;        // variável 'res' vai armazena o resultado da soma
        // double ress;

        Calc calc = new Calc();     // criação do objeto 'calc'

        res = calc.soma(10, 5, 3, 6, 7, 9);      // passando número indeterminado de parâmetros
       var ress = calc.soma(10.6, 4.4, 5.5);      // passando valores 'double' para soma e ultilizando 'var' não é neçessario ficar coloquando o 'tipo' na variável

        Console.WriteLine(res);
        Console.WriteLine(ress);

    }
}