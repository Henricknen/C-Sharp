using System;
class Metodos_para_array {
    static void Main() {
        int[] vetor1  = new int[5];     // vetor de tamanho 5
        int[] vetor2  = new int[5];         // vetor de tamanho 5
        int[] vetor3  = new int[5];             // vetor de tamanho 5
        int[,]  matriz= new int[2, 5]{{11, 22, 33, 44, 55}, {66, 77, 88, 99, 00}};      // matriz

        Random random = new Random();       // ultilizando claase e objeto 'random' para gerar números aleatorios
        for(int i = 0; i < vetor1.legth; i++) {
            vetor1[i] = random.Next(50);        // 'Next' com parametro '5' maxímo
        }

        Console.WriteLine("Elementos do vetor 1");
        foreach(int n in vetor1) {
            Console.WriteLine(n);
        }

        Console.WriteLine("BinarySerach");      // método 'BinarySerach' tem o retorno inteiro e retorna a posição do eemento 'procurado'
        int procurado = 33;
        int pos = Array.BinarySearch(vetor1, procurado);    // 'vetor1'´e o vetor onde será procurado e 'procurado' é o elemento que será procurado
        Console.WriteLine("O valor {0} está na posção {1}", procurado, pos);
        Console.WriteLine("-------------------------------------------");

        Console.WriteLine("Copy");      // ja o método 'Copy' faz uma copia dos elemenetos de um array para outro
        Array.Copy(vetor1, vetor2, vetor1.Length);      // 'vetor1' é o vetor de origem 'vetor2' ´o vetor de destino
        foreach(int n in vetor2) {      // 'foreach' ira imprimir os elementos copiados
            Console.WriteLine(n);
        }
        Console.WriteLine("-------------------------------------------");
        

        Console.WriteLine("CopyTo");     // método 'CopyTo' será chamdo apartir do vetor de origem
        vetor1.CopyTo(vetor3, 0);
        foreach(int n in vetor3) {
            Console.WriteLine(n);
        }
        Console.WriteLine("-------------------------------------------");

        Console.WriteLine("GetLongLength");
        long qtdeElementosVetor = vetor1.GetLongLength(0);
        Console.WriteLine("Quantidade de elementos {0}", qtdeElementosVetor);
        Console.WriteLine("-------------------------------------------");

        Console.WriteLine("GetLowerBound");     // 'GetLowerBound' retorna o menor indiçe
        int MenorIndiceVetor = vetor1.GetLowerBound(0);
        int MenorIndiceMatriz_D1 = matriz.GetLowerBound(1);
        Console.WriteLine("Menor indice do vetor1 {0}", MenorIndiceVetor);
        Console.WriteLine("-------------------------------------------");
        
        Console.WriteLine("GetUpperBound");     // 'GetLowerBound' retorna o maior indiçe
        int MaiorIndiceVetor = vetor1.GetUpperBound(0);
        int MaiorIndiceMatriz_D1 = matriz.GetUpperBound(1);
        Console.WriteLine("Maior indice do vetor1 {0}", MaiorIndiceVetor);
        Console.WriteLine("-------------------------------------------");

        Console.WriteLine("GetValue");      // 'GetValue' retorna um valor apartir de um indiçe
        int  valor0 = Convert.ToInt32(vetor1.GetValue(3));
        int  valor1 = Convert.ToInt32(vetor1.GetValue(1, 3));
        Console.WriteLine("O valor da posição 3 do vetor1: {0}", valor0);
        Console.WriteLine("-------------------------------------------");

        Console.WriteLine("IndexOf");      // 'IndexOf' retorna a posição do primeiro valor que está indicado no segundo parâmetro
        int  indice1 = Array.IndexOf(vetor1, 3);
        Console.WriteLine("O indiçedo primeiro valor 3: {0}", indice1);
        Console.WriteLine("-------------------------------------------");

        Console.WriteLine("LastIndexOf");    // 'LastIndexOf' retorna a posição do ultimo valor  
        int  indice2 = Array.LastIndexOf(vetor1, 3);
        Console.WriteLine("O indiçedo ultimo valor 3: {0}", indice2);
        Console.WriteLine("-------------------------------------------");

        Array.Reverse(vetor1);      // o método 'Reverse' inverte a ordem dos elementos
        foreach(int n in vetor1) {
            Console.WriteLine(n);
        }

        vetor2.SetValue(99, 0);     // 'SetValue' permite definir um valor em uma posição no vetor (setar) definido 99 na posição 0
        for(int i = 0; i < vetor2.Length; i++) {
            vetor2.SetValue(0, i);      // setando 0 para todas posiçõoes 'i' do 'vetor2'
        } 
        Console.WriteLine("vetor2");
        foreach(int n in vetor2) {
            Console.WriteLine(n);
        }

        Array.Sort(vetor1);     // método 'Sort' se usa sempre que querer ordenar em ordem crescente
        Array.Sort(vetor2);
        Array.Sort(vetor3);
        Console.WriteLine(vetor1);
        foreach(int n in vetor1) {
            Console.WriteLine(n);
        }
        Console.WriteLine(vetor2);
        foreach(int n in vetor2) {
            Console.WriteLine(n);
        }
        Console.WriteLine(vetor3);
        foreach(int n in vetor3) {
            Console.WriteLine(n);
        }
    }
}