using System;

namespace typecast
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = 10;
            float n2 = n1;      /* conversão implicita */

            float n3 = 9.7f;
            int n4 = (int)n3;   /* type cast fanzendo a conversão */

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
