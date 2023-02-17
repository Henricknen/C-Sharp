using Internal;
using System;

class Funcoes_oeracoes_matematicas {

    static int ExibirMenu() {     // função de menu
        Console.Clear();        // limpando a tela        
        Console.WriteLine("Sistema matemático");
        Console.WriteLine("Calcular fatorial (1)");
        Console.WriteLine("Verificar se um número é primo (2)");
        Console.WriteLine("Efetuar a divisão de um número Inteiro (3)");
        Console.WriteLine("Sair (4)");
        Console.Write("Opção: ");
        int op = Convert.ToInt32(Console.ReadLine());     // fazenso leitura com 'ReadLine' e armazenando na variável 'op'
        return op;      // retornando o valor da opção digitada pelo usuario
    }
    static void Main() {
    
        int op = 0;
        while (op != 4) {
            op = ExibirMenu();      // chamando a função 'ExibirMenu' enquanto 'op' for diferente de 4
        }

        
        if(op == 1) {
            
        }
        
        if(op == 2) {

        }
    }
}