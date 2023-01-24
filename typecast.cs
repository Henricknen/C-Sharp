using System;

namespace typecast
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = 10;
            float n2 = n1;      // conversão 'implicita' é uma conversão segura

            float n3 = 9.7f;
            int n4 = (int)n3;   // fazendo uma operação de 'typecast' convertendo n3 que é float em int com '(int)n3'

            int vInt = 8;
            long vLong = vInt;

            int Int = 7;
            short vShort = (short)Int;    /* type cast convertendo 'int' em 'short' */

            Console.WriteLine(n2);
            //Console.ReadLine();

            Console.WriteLine(n4);
            //Console.ReadLine();

            Console.WriteLine(vLong);
            //Console.ReadKey();

            Console.WriteLine(vShort);




        }
    }
}
