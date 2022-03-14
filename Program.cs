using System;       /* biblioteca de entrada e saida padrao*/

namespace C_        /* organizaco, onde vai ser aramazenado todos objetos, classes, elementos do pprograma etc */
{
    class Program       /* classe Program */
    {
        static void Main(string[] args)     /* metodo principal, com argumentos de entrada */
        {
            Console.WriteLine("Linguagem orientada a objetos");
            Console.WriteLine("C#");
            if(args.GetLength(0) > 0) {
                Console.Write(args.GetValue(0));
            }
        }
    }
}
