using System;

class Argumentos_de_entrada_do_parametro {
    static void Main(string[] args) {        // 'string[] args' cria uma lista de entrada de argumentos

        int res = 0;

        if(args.Length > 0) {       // verificando se foi passado algum parâmetro
            Console.WriteLine("Qtde de argumentos {0}", args.Length);       // faz o print da quantidade de argumentos passado
            for(int i = 0; i < args.Length; i++) {
                res += Int32.Parse(args[i]);        // 'res' reçebe a soma da posição'i' de args
            }
            Console.WriteLine("Soma: {0}", res);        // imprimido a soma
        } else {
            Console.WriteLine("Não foram passados argumentos");
        }

    }
}