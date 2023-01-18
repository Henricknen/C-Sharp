using System;
class Formatando_a_saida_do_console {
    static void Main() {

        // int n1, n2, n3;     // variáveis

        // n1 = 10; n2 = 20; n3 =30;       // iniçializando as variáveis 
        // // Console.Write(n1 + ", " + n2 + ", " + n3);  // fazendo impressão das varáveis concatenadas
        // Console.Write("\nn1 = \t{0} \nn2 = \t{1} \nn3 = \t{2}\n", n1, n2, n3);        // ultilizano o modelo de indices '\n' imprime um elemento embaixo do outro '\t' insere uma tabulação (avastada)

        double valorCompra = 1500.00;      // variável 'double'
        double valorVenda;
        double lucro = 0.1;     // está variável é a porcentagem de 'lucro' de 10% que terá em cima deste produto
        string produto = "notebook";

        valorVenda = valorCompra + (valorCompra * lucro);   // executando a operação

        Console.WriteLine("Produto........:{0,15}", produto);     // {0, 15} '0' é o indice e '15' é o tamanho do espaço que será adiçionado pela tabulação
        Console.WriteLine("Val.Compra.....:{0,15:c}", valorCompra);        // ':' diz que vai ser indicado um formato de saida e 'c' é um formatdo de saida monetário
        Console.WriteLine("Lucro..........:{0,15:p}", lucro);      // ':p' é um formato de saida de porcentagem
        Console.WriteLine("Val.Venda......:{0,15:c}", valorVenda);
    }
}