using System;

namespace se
{
    internal class Program
    { 
        static void Main(string[] args)
        {
            int n1, n2, n3, n4, res;
            res = n1 = n2 = n3 = n4 = 0;      /* inicializando todas variaveis de uma vez */
            string resultado = "Reprovado";


            Console.Write("Digite a primeira nota: ");
            n1 = int.Parse(Console.ReadLine());        /* aramzenado a primeira nota 'n1'e fazendo a conversão pra 'int' */

            Console.Write("Digite a segunda nota: ");
            n2 = int.Parse(Console.ReadLine());

            Console.Write("Digite a terçeira nota: ");
            n3 = int.Parse(Console.ReadLine());

            Console.Write("Digite a quarta nota: ");
            n4 = int.Parse(Console.ReadLine());

            res = n1 + n2 + n3 + n4;

            if((res) >= 60)
            {
                resultado = "Aprovado";
            }

            Console.WriteLine("Nota: {0} - Resultado:{1}", res, resultado);
        }
    }

}
