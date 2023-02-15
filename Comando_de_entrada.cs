using System;

class  Comando_de_entrada {
    static void Main() {

        string nome = "";        // variável 'nome' vazia

        Console.WriteLine("Programa que efetua leitura de dados do usuário");
        Console.WriteLine("Qual é o seu nome?");
        Console.Write("Digite seu nome:");
        nome = Console.ReadLine();     // 'ReadLine' vai armazenar na variável 'nome' o que o usuário digitou e aguarda o usuário pressionar enter para fazer o print
        // Console.WriteLine(nome + " Seja bem vindo...");
        Console.WriteLine(" Bem vindo ao repositório de C# " + nome);        // outra maneira de ultilizar o comando 'WriteLine' que trocará '{0}' pelo conteúdo da variável 'nome'

    }
}