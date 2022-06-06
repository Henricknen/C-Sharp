using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fila
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> numero = new Queue<string>();
            numero.Enqueue("126980");
            numero.Enqueue("253786 ");
            numero.Enqueue("614805");
            numero.Enqueue(" 046418");
            numero.Enqueue(" 026397");
            numero.Enqueue(" 732456");


            string v = "614805";
            if(numero.Contains(v))
            {
                Console.WriteLine("Voçê ganhou com o numero " + v + "...");
            } else
            {
                Console.WriteLine("Tente outra vez");
            }

            Console.WriteLine("Quantidade de sorteios : " + numero.Count());        /*.Count mostra o tamanho da fila */

            /*
            foreach (string num in numero)          // retorna todos os elementos da fila e não remove nenhum 
            {
                Console.WriteLine("Numeros do sorteio foram:" + num);
            }
            */
            Console.WriteLine("Primero numero sorteio foi: " + numero.Dequeue());      /* Dequeue retorna o primeiro elemento e o remove da ila */

            Console.WriteLine("Segundo numero sorteio foi: " + numero.Dequeue());

            //Console.WriteLine("Quantidade de sorteios : " + numero.Count());

            while(numero.Count > 0)         /* mostra todos os numero e os remove */
            {
                Console.WriteLine(numero.Dequeue());
            }
            Console.WriteLine("Quantidade de sorteios : " + numero.Count());
            Console.ReadLine();

        }

    }
}
