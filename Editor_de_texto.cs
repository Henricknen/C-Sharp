using System;

class Editor_de_texto {

    static int ExibirMenu() {       // função que vai criar um menu
        Console.Clear();
        Console.WriteLine("...Editor de Texto...");
        Console.WriteLine("Abrir um arquivo (1)");
        Console.WriteLine("Exibir texto do arquivo (2)");
        Console.WriteLine("Gravar um texto no arquivo (3)");
        Console.WriteLine("Gravar novo texto no arquivo(4)");
        Console.WriteLine("Sair(5)");
        Console.Write("Opção: ");      
        int op = Convert.ToInt32(Console.ReadLine());       // convertendo a leitura do usúario
        return op;
    }

    static void Main(string[] args) {
        int op = 0;
        while (op != 5) {
            op = ExibirMenu();
        }
    }
}