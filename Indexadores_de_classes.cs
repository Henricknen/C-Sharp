using System;

class Carro {       // classe 'Carro'
    private int[] velMax = new int[5]{80, 120, 160, 240, 300};     // array

    public int this[int i] {     // 'this[]' define como um indexador e '[int i]' faz referênçia ao indiçe do vetor
        get {       // acessor 'get' é de leitura
            return velMax[i];      // obtendo o valor da variável 'velMax' com '[i]' indiçe
        }
        set {       // acessor 'set' é de escrita
            if(value < 0) {
                velMax[i] = 0;
            } else if (value > 300) {
                velMax[i] = 300;
            } else {
                velMax[i] = value;
            }
        }
    }

} 

class Indexadores_de_classes {
    static void Main() {
        Carro c1 = new Carro();     // instançiando carro

        c1[4] = 260;        // atribuindo novo valor ao indiçe 4
        Console.WriteLine("Veloçidade:{0}", c1[4]);     // lendo o valor do indiçe 4
    }
}