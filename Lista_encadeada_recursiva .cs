using System;

class Node {
    public int value;
    public Node next;
    
    public Node(int value) {        // // construtor da classe 'Node' que recebe um valor inteiro e inicializa os campos 'value' e 'next'
        this.value = value;
        this.next = null;
    }
}

class Lista_encadeada_recursiva {
    static void Main(string[] args) {
        Console.WriteLine("Digite vários números separados por espaço:");       // pedido para o usuário para digitar vários números separados por espaço e armazenamos a entrada como uma string
        string input = Console.ReadLine();
        string[] numbers = input.Split(' ');        // método 'Split' para separar a string em um array de strings e usando o caractere espaço como separador
        
        Node head = null;       // ponteiro para o primeiro nó (head) e um contador de elementos (count)
        int count = 0;
        
        foreach (string number in numbers) {    // para cada número no array é 'convertida' a string para um valor inteiro
            int value = int.Parse(number);
            Node newNode = new Node(value);
            
            if (head == null) {     // se a lista está vazia é definido o novo nó como o primeiro (head)
                head = newNode;
            } else {        // caso contrário a lista será 'percorrida' até encontrar o último nó e o adicionamos como o próximo nó
                Node current = head;
                while (current.next != null) {
                    current = current.next;
                }
                current.next = newNode;
            }
            
            count++;        // incremento do contador de elementos
        }
        
        int min = head.value;
        int max = head.value;
        int sum = head.value;
        Node current2 = head.next;
                // Inicializamos as variáveis para encontrar o menor valor (min), o maior valor (max) e a soma dos valores (sum)
        // Começamos com o primeiro nó da lista (head)
        while (current2 != null) {
            if (current2.value < min) {         // Percorremos a lista até o último nó
                min = current2.value;       // Se encontrarmos um valor menor que o atual mínimo, atualizamos a variável min
            }
            if (current2.value > max) {
                max = current2.value;       // Se encontrarmos um valor maior que o atual máximo, atualizamos a variável max
            }
            sum += current2.value;  // Adicionamos o valor do nó atual à soma
            current2 = current2.next;   // Avançamos para o próximo nó
        }
        
        double average = (double)sum / count;       // Calculamos a média dividindo a soma pelo número de elementos
        
        Console.WriteLine("Menor número: " + min);
        Console.WriteLine("Maior número: " + max);
        Console.WriteLine("Média dos números: " + average);
    }
}
