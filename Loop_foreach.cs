using System;
class Loop_foreach {
    static void Main() {

        int[] num = new int[5]{11, 22, 33, 44, 55};       // coleção 'num'

        foreach(int n in num) {        // 'n' é uma variável recebe cada elemento da coleção 'num'
            Console.WriteLine(n);
        }
    }
}