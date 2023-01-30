using System;
class Argumento_params {
    static void Main() {
        soma(6, 9, 56, 3,12);     // chamando a unção soma
    }

    static void soma(params int[]n) {     // método de soma com com 'params'
        int res = 0;

        if(n.Length < 1) {
            Console.WriteLine("Não existe valores para serem somados");
        } else if(n.Length < 2) {
            Console.WriteLine("Valores insulficientes para soma {0}", n[0]);
        } else {
            for(int i = 0; i < n.Length; i++ ) {
                res += n[i];
            }
            Console.WriteLine("A soma dos valores é: {0}", res);
        }
    }
}