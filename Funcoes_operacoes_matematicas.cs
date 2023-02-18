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
                    break;

                case 3:     // divisão
                    Console.WriteLine("Informe o dividendo: "); 
                    n1 = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Informe o divisor: "); 
                    n2 = Convert.ToInt32(Console.ReadLine());
                    break;
            }
            Console.ReadLine();
        }
    }
}
