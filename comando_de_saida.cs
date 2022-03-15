using System;

class saida {
    static void Main() {

        int n1, n2, n3;     /* criacao das variaveis */

        n1 = 10; n2 = 20; n3 = 30;      /* inicializacao das variaveis */
        Console.Write("\nn1 = \t{0}\n n2 = \t{1}\n n3 = \t{2}\n", n1, n2, n3);      /* '\n' e caracter de escape que faz uma quebra de linha, ja o '\t' faz uma tabulacao, comando 'Write' nao faz a quebra de linha no final */

        double valorCompra = 15.50;
        double valorVenda;
        double lucro = 0.1;
        string produto = "pizza";

        valorVenda = valorCompra + (valorCompra * lucro);       /* executando a operacao */

        Console.WriteLine("Produto............:{0, 15}", produto);      /* imprimindo o nome do produto com espacamento */

        Console.WriteLine("Val.Compra.........:{0, 15:c}", valorCompra);      /* imprimindo o valor da compra em formato monetario ':c'  */

        Console.WriteLine("Lucro..............:{0, 15:p}", lucro);      /* imprimindo o valor do lucro em porcentagem ':p'  */

        Console.WriteLine("Val.Venda..........:{0, 15:c}", valorVenda);      /* imprimindo o valor da venda em formato monetario ':c'  */

    }
}