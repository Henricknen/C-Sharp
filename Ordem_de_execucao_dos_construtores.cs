using System;
class Base {        // classe 'Base'
    public Base() {     // construtor
        Console.WriteLine("Construtor da classe Base");
    }
}

class Derivada1: Base {     // classe 'Derivada1' herda a classe "Base'
    public Derivada1() {        // construtor
        Console.WriteLine("Construtor da classe Derivada 1");
    }
}

class Derivada2: Derivada1 {        // classe 'Derivada2' herda a classe "Derivada1'
    public Derivada2() {        // construtor
        Console.WriteLine("Construtor da classe Derivada 2");
    }
}

class Ordem_de_execucao_dos_construtores {
    static void Main() {
        Derivada2 derivada2 = new Derivada2();      // criação do objeto 'derivada2'
    }
}