using System;
class Metodos{
    static void Main() {        // 'Main' é a parte prinçipal do programa, métodos são conjuntos de instruções
        for(int i = 0; i < 10; i++) {
            meuNome();      // fazendo chamada do método 'meuNome'
        }

        minhaFormacao();        // fazendo chamada do método 'minhaFormacao'
    }

    static void meuNome() {     // 'static' indica que é um método estatico 'void' é o retorno e 'void' não retorna n' é o nome do método
        Console.WriteLine("Luis Henrique Silva Ferreira");
    }

    static void minhaFormacao() {
        Console.WriteLine("Análise e desenvolvimento de sistemas");
        Console.WriteLine("Técnico de informática para internet");
        Console.WriteLine("Técnico de eletroeletrônica");
        Console.WriteLine("Programador front - end");
    }
    
}