using System;

class Funcões_metodos {
    public static void ExibirData() {        // modificador de acesso 'public' todos que tiverem acesso a esta classe pode usar, 'static' informa se o pedaçinho de programa pertençe a classe, tipo 'void' executa uma ação e não devolve nada

        string data = DateTime.Now.Date.ToString();        // convertendo para texto 'ToString' uma data "date' obtidida pelo comando 'Now' que devolve um objeto do tipo 'date'
        Console.WriteLine(data);        // escrevendo a data na tela
    }

    public static void ExibirMensagem(string nome) {       // função que tem 'string nome' com parâmetro

        Console.WriteLine("Olá {0}", nome);
    }

    public static void ExibirMensagem2(string texto) {       // função que tem 'string nome' com parâmetro

        Console.WriteLine("Olá {0}", texto);
    }

    public static int CalcularIdade(int anoNascimento) {        // função que executa uma ação, recebe parâmetro e devolve um valor 
        int anoAtual = DateTime.Now.Date.Year;      // 'DateTime.Now.Date.Year' pega o valor do ano atual
        int idade = anoAtual - anoNascimento;
        return idade;       // 'return' finaliza a função e devolve o valor que segue a palavra 'return'
    }

    public static Double Somar(double n1, double n2) {      // função recebe mais de um parâmetro e devolve valor
        double total = n1 + n2;
        return total;
    }
    static void Main() {

        Console.WriteLine("Trabalhando com função");     // o comando 'WriteLine' é uma função que recebe um parâmetro e executa a ação de mostrar algo na tela
        ExibirData();       // chamanda da função 'ExibirData'

        ExibirMensagem("Mundo...");       // chamada da função com um valor 'string'

        int idade = CalcularIdade(1991);
        ExibirMensagem2("Idade: " + idade);

        double total = Somar(17, 45);
        Console.WriteLine("A soma do valores passados para a função Soma é: " + total);       // exibindo na tela o que tem dentro do 'total'

        Console.ReadKey();      // para visualizar o que vai aconteçer

    }
    
}
