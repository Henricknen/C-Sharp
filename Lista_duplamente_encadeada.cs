using System;

class Node {        // definindo a estrutura do nó
    public int data;        // armazena o dado do nó
    public Node next;           // ponteiro para o próximo nó
    public Node prev;               // ponteiro para o nó anterior

    public Node(int data) {     // construtor do nó
        this.data = data;   // inicializa o dado do nó
        this.next = null;       // inicializa o ponteiro para o próximo nó como nulo
        this.prev = null;           // inicializa o ponteiro para o nó anterior como nulo
    }
}

class Lista_duplamente_encadeada {
    static void Main(string[] args) {
        Node head = null;       // criando uma lista vazia

        // Inserção
        Node newNode = new Node(1);     // criando um novo nó com dado 1
        if (head == null) {
            head = newNode;     // se a lista estiver vazia, o novo nó será a cabeça da lista
        } else {
            Node current = head;    // se a lista não estiver vazia, percorre a lista até o último nó e adiciona o novo nó ao final
            while (current.next != null) {
                current = current.next;
            }

            current.next = newNode;
            newNode.prev = current;
        }

        newNode = new Node(2);      // repetindo o processo de inserção para os nós com dados 2, 3 e 4
        if (head == null) {
            head = newNode;
        } else {
            Node current = head;
            while (current.next != null) {
                current = current.next;
            }

            current.next = newNode;
            newNode.prev = current;
        }

        newNode = new Node(3);
        if (head == null) {
            head = newNode;
        } else {
            Node current = head;
            while (current.next != null) {
                current = current.next;
            }

            current.next = newNode;
            newNode.prev = current;
        }

        newNode = new Node(4);
        if (head == null) {
            head = newNode;
        } else {
            Node current = head;
            while (current.next != null) {
                current = current.next;
            }

            current.next = newNode;
            newNode.prev = current;
        }

        Console.Write("Lista: ");
        Node temp = head;
        while (temp != null) {
            Console.Write(temp.data + " ");     // imprime o dado do nó atual
            temp = temp.next;       // move o ponteiro para o próximo nó
        }
        Console.WriteLine();            // imprime uma nova linha

        Node nodeToFind = head;
        while (nodeToFind != null && nodeToFind.data != 3) {    // percorre a lista até encontrar um nó com dado 3 ou chegar ao final da lista
            nodeToFind = nodeToFind.next;
        }

        if (nodeToFind != null) {
            Console.WriteLine("Nó com numero 3 encontrado na lista: ");
        } else {
            Console.WriteLine("Nó com numero 3 não encontrado na lista");
        }

        Node nodeToRemove = head;       // remoção
        while (nodeToRemove != null && nodeToRemove.data != 3) {    // // percorre a lista até encontrar um nó com dado 3 ou chegar ao final da lista
            nodeToRemove = nodeToRemove.next;
        }

        if (nodeToRemove != null) {
            if (nodeToRemove.prev != null) {        // se o nó a ser excluído não for o primeiro da lista
                nodeToRemove.prev.next = nodeToRemove.next;
            } else {
                head = nodeToRemove.next;       // se o nó a ser excluído for o primeiro da lista, atualiza a cabeça da lista
            }

            if (nodeToRemove.next != null) {        // se o nó a ser excluído não for o último da lista
                nodeToRemove.next.prev = nodeToRemove.prev;
            }

            Console.Write("Lista após remover o nó com numero 3: ");
            temp = head;
            while (temp != null) {
                Console.Write(temp.data + " ");     // imprime o dado do nó atual
                temp = temp.next;       // move o ponteiro para o próximo nó
            }
            Console.WriteLine();        // imprime uma nova linha
        } else {
            Console.WriteLine("Nó com numero 3 não encontrado na lista");
        }
    }
}
