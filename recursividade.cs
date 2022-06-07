using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Calc
    {
        public int soma(params int[]n)          /* sobrecarga de metodos params p */
        {
            int s = 0;
            for(int i = 0; i < n.Length; i++)
            {
                s += n[i];
            }
            return s;
        }

        public double soma(params double[]n)
        {
            double s = 0;
            for(int i = 0; i < n.Length; i++)
            {
                s += n[i];
            }
            return s;
        }
    
    
                                    /* fatorial */
        public int fat(int n)        /* função fatorial */
        {
            int res;
            if(n <= 1)
            {
                res = 1;        /* se n é menor ou igual a 1, o retorno será 1 */
            } else
            {
                res = n * fat(n - 1);       /* se for maior multiplica ele menos 1 sucessivamente */
            }
            return res;
        }

   
        static void Main(string[] args)
        {

            Calc calc = new Calc();

            var res = calc.fat(5);      /* mostrará o fatorial de 5 */

            Console.WriteLine(res);         /* fará o print na tela com o resultado */

            Console.ReadLine();
        }
    
    }
