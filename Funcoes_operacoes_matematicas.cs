using System;

class Funcoes_operacoes_matematicas {

    static int ExibirMenu() {     // função de menu
        Console.Clear();        // limpando a tela        
        Console.WriteLine("...Sistema matemático...");
        Console.WriteLine("Calcular fatorial (1)");
        Console.WriteLine("Verificar se um número é primo (2)");
        Console.WriteLine("Efetuar a divisão de um número Inteiro (3)");
        Console.WriteLine("Sair (4)");
        Console.Write("Opção: ");
        int op = Convert.ToInt32(Console.ReadLine());     // fazenso leitura com 'ReadLine' e armazenando na variável 'op'
        return op;      // retornando o valor da opção digitada pelo usuario
    }

    static int Fatorial(int numero) {       // recebendo 'numero' como parâmetro
        for(int i = numero - 1; i > 1; i--) {       // laço for que decrementa
            numero = numero * i;        // após a multiplicação volta para o laço de repetição for que decrementará 'i' e assin sucessivamente
        }
        return numero; 
    }

    static Boolean NumeroPrimo(int numero) { // função que vai calcular se o número é primo ou não
        Boolean primo = false;
        int count = 0;      // variável 'count' cont quantas vezes numero será dividido
        for(int i = numero; i > 0; i--) {
            if(numero % i == 0) count++;        // resto 0 indica que a divisão foi exata 'count' é incrementado
        }
        if(count == 2) primo = true;
        return primo;
    }

    static void Dividir(int dividendo, int divisor, out int resto, out int quociente) {      // função 'Dividir' por ser do tipo void não devolve nada apenas executa a função, 'out' indica um valor de saída que pode ser modificado e devolvido
        resto = dividendo % divisor;        // pegando o resto da divisão
        quociente = dividendo / divisor;
    }

    static void Main(string[] args) {
    
        int op = 0;
        int n1 = 0;
        int n2 = 0;     // variáveis
        int fatorial = 0;
        int resto = 0;
        int quociente = 0;

        while (op != 4) {
            op = ExibirMenu();      // chamando a função 'ExibirMenu' enquanto 'op' for diferente de 4 e ela não recebe parâmetro
            Console.Clear();

            switch(op) {
                case 1:         // fatorial
                    Console.WriteLine("Informe um número: ");     // calcular fatorial
                    n1 = Convert.ToInt32(Console.ReadLine());     // lendo o valor
                    fatorial = Fatorial(n1);        // variável 'fatorial' recebe o valor calculado por meio da função 'Fatorial'
                    Console.WriteLine("O fatorial de {0} é {1}", n1, fatorial);
                    break;

                case 2:     // número primo
                    Console.WriteLine("Informe um número: ");
                    n1 = Convert.ToInt32(Console.ReadLine());
                    if(NumeroPrimo(n1)) {       // se numero for igual a 'true'
                        Console.WriteLine("O numero {0} é um numero primo", n1);
                    } else {
                        Console.WriteLine("O numero {0} não é um numero primo", n1);
                    }
                    break;

                case 3:     // divisão
                    Console.WriteLine("Informe o dividendo: "); 
                    n1 = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Informe o divisor: "); 
                    n2 = Convert.ToInt32(Console.ReadLine());
                    Dividir(n1, n2, out resto, out quociente);      // chamando função "Dividir'
                    Console.WriteLine("{0}/{1} = {2} e sobra {3}", n1, n2, quociente, resto);
                    break;
            }
            Console.ReadLine();
        }
    }
}
