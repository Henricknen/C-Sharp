using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sobrecarga_de_metodos
{

    class Calc
    {
        public int soma(int n1, int n2)       // metodo soma 
        {
            return n1 + n2;
        }
        



        public int soma(int n1, int n2, int n3)       /* criação de metodo com outra parametro é uma sobrecarga  */
        {
            return n1 + n2 + n3;
        }

        public int soma(int n1, int n2, int n3, int n4)       /* será ultilizado quatro valores para a soma */
        {
            return n1 + n2 + n3 + n4;
        }

        public double soma(double n1, double n2)       /* pode se realizar soma com int o double como valores */
        {
            return n1 + n2;
        }

        

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //int res;    tipo da variavel
            //double res;   tipo da variavel

            Calc calc = new Calc();     /* instanciando o objeto Caculadora */

            var res = calc.soma(15.4, 17.6);        /* ultilizando var no inicio não necssita deinir o tipo da variavel */

            Console.WriteLine("A soma terá " + res + " como resultado final");

            Console.ReadLine();
        }
    }
}
