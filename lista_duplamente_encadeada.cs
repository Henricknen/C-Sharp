using System;
using System.Collections.Generic;       // using vai trabalha com a biblioteca Generic
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_duplamente_encadeada
{
    internal class Program
    {
        static void Main(string[] args)
        {
           LinkedList<string> transporte = new LinkedList<string>();       // construtor da classe

           transporte.AddFirst("Carro");        // Addffirst vai adicionar Carro no inicio e assin sucessivamente
           transporte.AddFirst("Moto");
           transporte.AddFirst("Aviao");
           transporte.AddFirst("Navio");

            transporte.AddLast("Bicicleta");     

            LinkedListNode<string> no;
            no = transporte.FindLast("Bicicleta");                  // Asslast adiciona no fim da lista
            transporte.AddAfter(no, "Moto");                // AddAfter adicionara Moto a apos Bicicleta
            no = transporte.FindLast("Carro");
            transporte.AddBefore(no, "Aviao");           // AddBefore adicionara Aviao antes de Carro

            // transporte.Clear();         // metodo de remover, remove todos os elementos

            if(transporte.Find("Navio") == null)      // verifica switch existe o elemento na lista
            {
                Console.WriteLine("transporte não encontrado...");
            } else
            {
                Console.WriteLine("transporte encontrado...");
            }

            transporte.Remove("Bicicleta");   // Remove remove Bicicleta
            transporte.RemoveFirst();                // RemoveFirst remove o primeiro elemento
            transporte.RemoveLast();                         // RemoveLast remove o ultimo elemento

           foreach (string t in transporte)
           {
                Console.WriteLine("trasnporte: {0}", t);            
           }
            Console.ReadLine();

        }
    }
}
