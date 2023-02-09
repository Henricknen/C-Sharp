using System;
using System.Collections.Generic;       // fazendo a inclusão de biblioteca e ultilizando 'Generic' para trabalha com as coleções genéricas

class Colecao_LinkedList {
    static void Main() {

        LinkedList<string> transp = new LinkedList<string>();      // criando 'LinkedList'

        transp.AddFirst("Carro");     // adiçionando elementos no iniçio da lista com método 'AddFirst'
        transp.AddFirst("Avião");
        transp.AddFirst("Moto");
        transp.AddFirst("Barco");

        transp.AddLast("Navio");        // 'AddLast' adiçiona no fim da lista

        LinkedListNode<string>no;       // criação do 'LinkedListNode' do tipo 'string' chamado 'no'
        no = transp.FindLast("Avião");       // ponto de referênçia 'no', 'FindLast' enconta o ultimo 'Avião'
        transp.AddAfter(no, "Biçicleta");       // método 'AddAfter' adiçionará biçicleta 'após' o 'no'

        no = transp.FindLast("Avião");
        transp.AddBefore(no, "Patinete");       // método 'Patinete' adiçionará Patinete 'antes' do 'no'

        // transp.Clear();     // método 'Clear' remove todos elementos

        if(transp.Find("Moto") == null) {        // método 'Find' verifica se o elemento está na lista
            Console.WriteLine("Não encontrado");
        } else {
            Console.WriteLine("Elemento encontrado");
        }

        // transp.Remove("Barco");      // 'Remove' remove um elemento
        transp.RemoveFirst();       // remove o primeiro elemento
        transp.RemoveLast();    // remove o último

        foreach(string t in transp) {// percorrendo a lista e imprimindo os elementos com 'foreach'
            Console.WriteLine("Transporte: {0}", t);
        }

    }
}