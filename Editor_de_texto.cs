using System;

class Editor_de_texto {

    static void ExibirTexto(string arquivo) {       // função que fará a leitura do texto e por ser 'void' não retornará nada só executará uma ação
        try {       // 'try' tenta executar uma serie de comandos
          string line = ""  ;
          StreamReader sr = new StreamReader(arquivo);      // 'StreamReader' ler de algum lugar que 'sr' representa
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

    static void GravarTexto(string arquivo, string texto, bool incrementar) {     // a função 'GravarTexto' vai reçeber o arquivo que será editado e texto que estará dentro  como parâmetros
        try {
            StreamWriter sr = new StreamWriter(arquivo, incrementar);        // 'StreamWriter' grava em algum lugar que 'sr' representa
            sr.WriteLine(texto);     // linha
            sr.Close();     // feçhando 'arquivo'
        } catch (Exception e) {
            Console.WriteLine("Error: " + e.Message);
            Console.ReadKey();
        }
    }

    static int ExibirMenu() {       // função que vai criar um menu
        Console.Clear();
        Console.WriteLine("...Editor de Texto...");
        Console.WriteLine("Abrir/ criar um arquivo (1)");
        Console.WriteLine("Exibir texto do arquivo (2)");
        Console.WriteLine("Criar um arquivo com um novo texto (3)");
        Console.WriteLine("Adiçionar novo texto no arquivo(4)");
        Console.WriteLine("Sair(5)");
        Console.Write("Opção: ");      
        int op = Convert.ToInt32(Console.ReadLine());       // convertendo a leitura do usuário
        return op;
    }

    static void Main(string[] args) {
        int op = 0;     // menu
        string arquivo = "";        // variável 'arquivo' 
        string texto = "";      // variável 'texto'
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
                case 3:
                    Console.Write("Informe o texto: ");
                    texto = Console.ReadLine();       // guardando o que usuário digitar dentro da variável 'texto'
                    GravarTexto(arquivo, texto, false);            // chamando função 'GravarTexto'
                    ExibirTexto(arquivo);       // chamando função 'ExibirTexto'
                    break;
                case 4:
                    Console.Write("Informe o texto: ");
                    texto = Console.ReadLine();       
                    GravarTexto(arquivo, texto, true);
                    ExibirTexto(arquivo);
                    break;
            }
        }
    }
}