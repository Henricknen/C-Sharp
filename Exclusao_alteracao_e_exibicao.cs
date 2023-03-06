using System;

class Node {         // Define a classe Node que representa cada nó da lista
    public string nome;
    public int idade;
    public string whats;
    public Node prox;

    public Node(string nome, int idade, string whats) {     // Construtor que inicializa os atributos da classe
        this.nome = nome;
        this.idade = idade;
        this.whats = whats;
        this.prox = null;       // O atributo prox é inicializado como nulo, indicando que este é o último nó da lista
    }
}

class Lista {       // Define a classe Lista que encapsula as operações da lista encadeada
    private Node primeiro;

    public Lista() {    // Construtor que inicializa a lista como vazia
        this.primeiro = null;   // O atributo primeiro é inicializado como nulo, indicando que a lista está vazia
    }

    public void Incluir(string nome, int idade, string whats) {     // método de inclusão
        Node novo = new Node(nome, idade, whats);   // cria um novo nó de dados

        if (this.primeiro == null) {
            this.primeiro = novo;
        }
        else
        {
            Node atual = this.primeiro;
            while (atual.prox != null) {
                atual = atual.prox;
            }
            atual.prox = novo;
        }
    }

    public void Alterar(string nome) {      // método alterar
        Node atual = this.primeiro;
        while (atual != null) {      // Percorre a lista até encontrar o registro ou chegar ao final da lista
            if (atual.nome == nome) {       // Verifica se o nome do registro atual é o mesmo que o nome informado
                Console.WriteLine("Nome: " + atual.nome);
                Console.WriteLine("Idade: " + atual.idade);
                Console.WriteLine("WhatsApp: " + atual.whats);

                Console.WriteLine("Informe os novos dados:");
                Console.Write("Idade: ");
                int idade = int.Parse(Console.ReadLine());
                Console.Write("WhatsApp: ");
                string whats = Console.ReadLine();

                atual.idade = idade;
                atual.whats = whats;

                Console.WriteLine("Dados alterados com sucesso!");
                return;
            }
            atual = atual.prox;
        }

        Console.WriteLine("Registro não encontrado!");
    }

    public void Excluir(string nome) {      // método excluir
        if (this.primeiro == null) {
            Console.WriteLine("Lista vazia!");
            return;
        }

        if (this.primeiro.nome == nome) {
            this.primeiro = this.primeiro.prox;
            Console.WriteLine("Registro excluído com sucesso!");
            return;
        }

        Node atual = this.primeiro;
        while (atual.prox != null) {
            if (atual.prox.nome == nome) {
                atual.prox = atual.prox.prox;
                Console.WriteLine("Registro excluído com sucesso!");
                return;
            }
            atual = atual.prox;
        }

        Console.WriteLine("Registro não encontrado!");
    }

    public void Exibir() {
        if (this.primeiro == null) {
            Console.WriteLine("Lista vazia!");
            return;
        }

        Node atual = this.primeiro;
        while (atual != null)
        {
            Console.WriteLine("Nome: " + atual.nome);
            Console.WriteLine("Idade: " + atual.idade);
            Console.WriteLine("WhatsApp: " + atual.whats);
            Console.WriteLine();
            atual = atual.prox;
        }
    }
}

class Exclusao_alteracao_e_exibicao {
    static void Main(string[] args)     {
        Lista lista = new Lista();

        while (true) {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - Incluir");
            Console.WriteLine("2 - Alterar");
            Console.WriteLine("3 - Excluir");
            Console.WriteLine("4 - Exibir");
            Console.WriteLine("0 - Sair");

            int opcao = int.Parse(Console.ReadLine());

            switch (opcao) {
                case 0:
                    return;

                case 1:
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();
                    Console.Write("Idade: ");
                    int idade = int.Parse(Console.ReadLine());
                    Console.Write("WhatsApp: ");
                    string whats = Console.ReadLine();

                    lista.Incluir(nome, idade, whats);

                    Console.WriteLine("Registro incluído com sucesso!");
                    break;

                case 2:
                    Console.Write("Informe o nome do registro a ser alterado: ");
                    nome = Console.ReadLine();

                    lista.Alterar(nome);
                    break;

                case 3:
                    Console.Write("Informe o nome do registro a ser excluído: ");
                    nome = Console.ReadLine();

                    lista.Excluir(nome);
                    break;

                case 4:
                    lista.Exibir();
                    break;

                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }

            Console.WriteLine();
        }
    }
}

