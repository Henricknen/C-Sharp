using System;

class Editor_de_texto {

    static void ExibirTexto(string arquivo) {       // função que fará a leitura do texto e por ser 'void' não retornará nada só executará uma ação
        try {       // 'try' tenta executar uma serie de comandos
          string line = ""  ;
          StreamReader sr = new StreamReader(arquivo);
          line = sr.ReadLine();     // fazendo leitura da 1º linha do 'arquivo'
          while ( line != null) {
            Console.WriteLine(line);        // se a linha existir é escrita na tela
            line = sr.ReadLine();       // leitura da proxima linha
          }
          sr.Close();       // fecha o 'arquivo'
        } catch (Exception e) {     // se ocorrer algum erro o comando cairá no 'catch' e mostrará uma menssagem para o usuário
            Console.WriteLine("Menssagem: " + "Arquivo está em branco ou não exite...");            
        }
        Console.ReadKey();      // 'ReadKey' é um comando de leitura

    }

    static int ExibirMenu() {       // função que vai criar um menu
        Console.Clear();
        Console.WriteLine("...Editor de Texto...");
        Console.WriteLine("Abrir um arquivo (1)");
        Console.WriteLine("Exibir texto do arquivo (2)");
        Console.WriteLine("Gravar um texto no arquivo (3)");
        Console.WriteLine("Gravar novo texto no arquivo(4)");
        Console.WriteLine("Sair(5)");
        Console.Write("Opção: ");      
        int op = Convert.ToInt32(Console.ReadLine());       // convertendo a leitura do usuário
        return op;
    }

    static void Main(string[] args) {
        int op = 0;     // menu
        string arquivo = "";        // arquivo texto
        while (op != 5) {
            op = ExibirMenu();
            Console.Clear();        // limpamdo tela depois do 'menu' para aparecer as outras coisas
            switch (op) {
                case 1:
                    Console.Write("Informe o nome do arquivo: ");
                    arquivo = Console.ReadLine();       // guardando o 'nome' do arquivo digitado pelo usuário e armazenando em 'arquivo'
                    break;                
                case 2:
                    ExibirTexto(arquivo);       // chamada da função 'ExibirTexto' com o nome do texto 'arquivo'
                    break;                             
            }
        }
    }
}