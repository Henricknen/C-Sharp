using System;
using System.Collections.Generic;

class MinhaLista
{
    private List<int> lista;

    public MinhaLista()
    {
        lista = new List<int>();
    }

    public void Add(int value)
    {
        lista.Add(value);
    }

    public void Remove(int value)
    {
        lista.Remove(value);
    }

    public void Print()
    {
        foreach (int value in lista)
        {
            Console.WriteLine(value);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        MinhaLista minhaLista = new MinhaLista();

        minhaLista.Add(1);
        minhaLista.Add(2);
        minhaLista.Add(3);

        Console.WriteLine("Lista antes de remover: ");
        minhaLista.Print();

        minhaLista.Remove(2);

        Console.WriteLine("Lista depois de remover: ");
        minhaLista.Print();

        Console.ReadLine();
    }
}

/* A classe MyList tem três métodos públicos: Add, Remove e Print. O método Add adiciona um novo valor à lista, o método Remove remove um valor específico da lista, e o método Print imprime todos os valores na lista.

A classe Main cria uma instância de MyList, adiciona alguns valores, remove um valor específico e imprime a lista antes e depois da remoção.

Para executar esse código, você pode usar o dotnet run como eu mencionei anteriormente. */