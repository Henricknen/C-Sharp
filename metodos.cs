using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodoss
{
    class Galinha
    {
        private string nomeGalinha;
        private int numOvo;     /* controle de ovos */
        public Galinha(string nomeGalinha)      /* a galinha ja será criada com um nome */
            {
                this.nomeGalinha = nomeGalinha;
            numOvo = 0;      /* a galinha não possui ovo */
            }

        public Ovo botar()       /* este metodo botar vai retorna a quantidades de ovos */ 
        {
            numOvo++;
            return new Ovo(numOvo, nomeGalinha);
        }
    }

class Ovo
{

        private int numOvo;
        private string minhaGalinha;
        public Ovo(int numOvo, string minhaGalinha)
        {
            this.numOvo = numOvo;       /* no construtor do ovo devo informa o numero do ovo */
            this.minhaGalinha = minhaGalinha;
            Console.WriteLine("{0} Ovo criado - {1}", this.numOvo, this.minhaGalinha);
        }
    }
    internal class metodos
    {
        static void Main()
        {
            Galinha g1 = new Galinha("karijo");
            Galinha g2 = new Galinha("galo");
            Galinha g3 = new Galinha("frango");

            g1.botar();
            g1.botar();
            g1.botar();

            g2.botar();
            g2.botar();


            g3.botar();

            Console.ReadLine();
        }
    }
}
