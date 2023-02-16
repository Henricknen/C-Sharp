using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncaoMetodos
{
    internal class Program { 

        public static void ExibirData() {        // modificador de acesso 'public' todos que tiverem acesso a ele pode usar 'static' diz que o pedaçinho de programa pertençe a classe tipo 'void' executa uma ação e não devolve nada

            string data = DateTime.Now.Date.ToString();        // convertendo para texto 'ToString' uma data "date' obtidida pelo comando 'Now' que devolve um objeto do tipo 'date'
        Console.WriteLine(data);        // escrevendo a data na tela

        }
        static void Main(string[] args) {


            Console.WriteLine("Trabalhando com função");     // o comando 'WriteLine' é uma função que recebe um parâmetro e executa a ação de mostrar algo na tela
            ExibirData();       // chamando a função 'ExibirData'
            Console.ReadKey();      // para visualizar o que vai aconteçer

        }
    }
}
