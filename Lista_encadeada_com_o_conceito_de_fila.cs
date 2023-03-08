using System;

public class NoFila {       // classe que representa um nó da lista encadeada
    public int valor;   // valor armazenado no nó
    public NoFila proximo;      // referência para o próximo nó da lista

    public NoFila(int valor) {
        this.valor = valor;     // define o valor do nó
        this.proximo = null;        // define que o próximo nó é nulo
    }
}

public class Fila {     // classe que implementa a fila com lista encadeada
    private NoFila inicio;      // referência para o nó no início da fila
    private NoFila fim;     // referência para o nó no fim da fila


    public Fila() {
        this.inicio = null;     // inicializa as referências como nulas
        this.fim = null;
    }

    public void Enfileirar(int valor) {     // método que adiciona um valor ao fim da fila
        NoFila novoNo = new NoFila(valor);      // cria um novo nó com o valor informado

        if (this.fim != null) {
            this.fim.proximo = novoNo;      // se não estiver, define o próximo nó do nó no fim como o novo nó
        } else {
            this.inicio = novoNo;       // se estiver, define o novo nó como o nó no início
        }

        this.fim = novoNo;      // define o novo nó como o nó no fim da fila
    }

    public int Desenfileirar() {        // détodo que remove o valor no início da fila e o retorna
        if (this.inicio == null) {          // verifica se a fila está vazia
            throw new InvalidOperationException("A fila está vazia.");      // se estiver, lança uma exceção indicando que a fila está vazia
        }

        int valor = this.inicio.valor;      // armazena o valor do nó no início da fila
        this.inicio = this.inicio.proximo;      // define o próximo nó como o novo nó no início

        if (this.inicio == null) {      // verifica se o novo nó no início é nulo, indicando que a fila está vazia
            this.fim = null;
        }

        return valor;       // retorna o valor removido da fila
    }

    public void Imprimir() {
        NoFila noAtual = this.inicio;       // começa a percorrer a fila a partir do nó no início

        while (noAtual != null) {       // percorre a fila enquanto o nó atual não for nulo
            Console.Write(noAtual.valor + " ");     // imprime o valor do nó atual
            noAtual = noAtual.proximo;      // avança para o próximo nó da fila
        }

        Console.WriteLine();        // pula uma linha após imprimir todos os valores
    }
}

class Lista_encadeada_com_o_conceito_de_fila {
    static void Main(string[] args) {
        Fila fila = new Fila();     // cria uma nova fila

        fila.Enfileirar(10);        // adiciona valores na fila
        fila.Enfileirar(20);
        fila.Enfileirar(30);
        fila.Enfileirar(40);

        fila.Imprimir();        // iImprime os valores da fila

        int valorRemovido = fila.Desenfileirar();       // remove um valor da fila
        Console.WriteLine(valorRemovido);

        fila.Imprimir();        // imprime os valores da fila novamente
    }
}
