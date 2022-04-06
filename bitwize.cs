using System;

class bitwize {
    static void Main() {
        int num = 10;
        int num1 = 10;

        num = num<< 1;      // bitwize feito a esquerda, deslocação em 1
        num1 = num1>> 1;        // bitwize feito a direita, deslocação em 1
        
        Console.WriteLine("O valor de num apos fazr um bitwize a esquerda é {0}", num);
        Console.WriteLine("O valor de num apos fazr um bitwize a direita é {0}", num1);
    }
}
