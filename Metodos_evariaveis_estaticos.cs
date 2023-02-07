using System;

class Mat {     // classe 'Mat'
    public static double pi = 3.14;     // propriedade 'pi'

    public static int dobro(int n) {        // método 'dobro' que retornará o dobro de um valor
        return n * 2;
    }
}

class Metodos_evariaveis_estaticos {
    static void Main() {

        double vpi = Mat.pi;        // variável 'vpi' chma a propriedade 'pi' da classe 'Mat'
        int num = 10;

        Console.WriteLine("O valor de PI é: {0}", Mat.pi);      // verificando o 'dobro' da variável num
        Console.WriteLine("O dobro de da variável é: {0}", Mat.dobro(num));      // verificando o 'dobro' da variável num
    }
}