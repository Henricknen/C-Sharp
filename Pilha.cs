using System;
using System.Collections.Generic;

class MyStack
{
    private Stack<int> stack;

    public MyStack()
    {
        stack = new Stack<int>();
    }

    public void Push(int value)
    {
        stack.Push(value);
    }

    public int Pop()
    {
        if (stack.Count == 0)
        {
            throw new InvalidOperationException("A pilha está vazia.");
        }

        return stack.Pop();
    }

    public void Print()
    {
        foreach (int value in stack)
        {
            Console.WriteLine(value);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        MyStack myStack = new MyStack();

        myStack.Push(1);
        myStack.Push(2);
        myStack.Push(3);
        myStack.Push(4);
        myStack.Push(5);
        myStack.Push(6);
        myStack.Push(7);

        Console.WriteLine("Pilha antes de remover: ");
        myStack.Print();

        int value = myStack.Pop();

        Console.WriteLine("Valor removido: " + value);

        Console.WriteLine("Pilha depois de remover: ");
        myStack.Print();

        Console.ReadLine();
    }
}

/* A classe MyStack tem três métodos públicos: Push, Pop e Print. O método Push adiciona um novo valor à pilha, o método Pop remove e retorna o valor do topo da pilha, e o método Print imprime todos os valores na pilha.

A classe Main cria uma instância de MyStack, adiciona alguns valores, remove o valor do topo da pilha e imprime a pilha antes e depois da remoção.

Para executar esse código, você pode usar o dotnet run como eu mencionei anteriormente. */