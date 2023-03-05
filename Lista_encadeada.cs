using System;

class Node {        //  classe 'Node' representa cada nó da lista encadeada
    public int data;        // valor do nó
    public Node next;           // ponteiro para o próximo nó da lista
    
    public Node(int data) {     // construtor da classe 'Node'
        this.data = data;
        this.next = null;
    }
}

class ListaEncadeada {      // a classe 'ListaEncadeada' é responsável por gerenciar a lista como um todo
    private Node head;          // 'head' é um ponteiro que aponta para o primeiro nó da lista
    
    public ListaEncadeada() {
        this.head = null;   // primeiro ponteiro deve ser inicializado com 'null' para dizer que a lista está vazia
    }
    
    public void AdicionarUltimo(int data) {     // método que irá adiçionar um elemento no final da lista
        Node novoNo = new Node(data);       // criação de novo nó com valor reçebido como parâmetro 'data'
        if (this.head == null) {        // se lista vazia
            this.head = novoNo;     // define o novo nó como primeiro nó
        } else {    // se a lista já conter elementos
            Node temp = this.head;      // a lista será percorrida a partir do primeiro nó
            while (temp.next != null) {     // percorre a lista até encontrar o último nó
                temp = temp.next;
            }
            temp.next = novoNo;     // define o próximo nó do último nó como o novo nó
        }
    }
    
    public void Remover(int data) {
        Node temp = this.head;      // começa a percorrer a lista a partir do primeiro nó
        Node anterior = null;           // ponteiro para o nó anterior ao nó atual
        bool encontrado = false;            // indica se o valor a ser removido foi encontrado na lista
        while (temp != null) {      // percorre a lista enquanto não chega ao fim
            if (temp.data == data) {    // se o valor a ser removido for encontrado na lista
                encontrado = true;  // marca como encontrado
                break;
            }
            anterior = temp;    // salva o nó atual como anterior
            temp = temp.next;       // avança para o próximo nó

        }
        if (encontrado) { // se o valor a ser removido foi encontrado na lista
                if (anterior == null) { // se o nó a ser removido é o primeiro da lista
                    this.head = temp.next; // define o próximo nó como primeiro da lista
                } else { // se o nó a ser removido não é o primeiro da lista
                    anterior.next = temp.next; // define o próximo nó do anterior como o próximo nó do nó a ser removido
                }
                Console.WriteLine("{0} foi removido da lista.", data); // exibe mensagem informando que o elemento foi removido
            } else { // se o valor a ser removido não foi encontrado na lista
                Console.WriteLine("{0} não foi encontrado na lista.", data); // exibe mensagem informando que o elemento não foi encontrado
            }
    }
    
    public void ImprimirLista() {
        Node temp = this.head;
        while (temp != null) {
            Console.Write("{0} -> ", temp.data);
            temp = temp.next;
        }
        Console.WriteLine("null");
    }
}

class Program {
    static void Main(string[] args) {       //  No método 'Main' é criada uma instância da lista encadeada e um menu é apresentado ao usuário
        ListaEncadeada minhaLista = new ListaEncadeada();
        int opcao = 0;
        while (opcao != 4) {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - Inserir elemento");
            Console.WriteLine("2 - Remover elemento");
            Console.WriteLine("3 - Imprimir lista");
            Console.WriteLine("4 - Sair");
            opcao = int.Parse(Console.ReadLine());
            switch (opcao) {
                case 1:
                    Console.WriteLine("Digite o valor a ser inserido:");
                    int valorInserir = int.Parse(Console.ReadLine());
                    minhaLista.AdicionarUltimo(valorInserir);
                    break;
                case 2:
                    Console.WriteLine("Digite o valor a ser removido:");
                    int valorRemover = int.Parse(Console.ReadLine());
                    minhaLista.Remover(valorRemover);
                    break;
                case 3:
                    Console.WriteLine("Conteúdo da lista:");
                    minhaLista.ImprimirLista();
                    break;
                case 4:
                    Console.WriteLine("Saindo...");
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }
}
