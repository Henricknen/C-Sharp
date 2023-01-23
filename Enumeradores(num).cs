using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeradores_num_
{
    internal class Program
    {
                //indice:   0		  1		  2		 3		 4		5		6
        enum DiasSemana { Domigo, Segunda, Terça, Quarta, Quinta, Sexta, Sábado };        /* tipo do Enumerador */
        static void Main(string[] args)
        {
            DiasSemana ds = DiasSemana.Domigo;      /* dentro de 'ds' tem-se o valor relaçionado a Domigo */

            DiasSemana dsi = (DiasSemana)3;      /* ira imprimir o dia que se encontra no indice 3*/

            int dsc = (int)DiasSemana.Sexta;

            Console.WriteLine(ds);
            //Console.ReadKey();      

            Console.WriteLine(dsi);
            //Console.ReadLine();

            Console.WriteLine(dsc);
            Console.ReadKey();      /* se usa 'Console.ReadKey()' para dar uma pausa na execução do programa e usuario ver a impressão */


        }
    }
}
