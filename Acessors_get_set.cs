using System;

class Carro {       // classe 'Carro'
    private int velMax;     // propriedade 'vwMax'

    public int vm {     //propriedade
        get {       // acessor 'get' é de leitura
            return velMax;      // obtendo o valor da variável 'velMax' c
        }
        set {       // acessor 'set' é de escrita
            if(value < 0) {
                velMax = 0;
            } else if (value > 300) {
                velMax = 300;
            } else {
                velMax = value;
            }
        }
    }

    public Carro() {        // construtor
        vm = 120;
    }

    // public void vm(int velMax) {        // método para atribuição de valor a 'velMax'
    //     this.velMax = velMax;
    // }
} 
class Acessors_get_set {
    static void Main() {
        Carro c1 = new Carro();     // instançiando carro

        c1.vm = 200;        // atribuindo novo valor a 'vm'
        Console.WriteLine("Veloçidade:{0}", c1.vm);     // verificando a veloçidade
    }
}