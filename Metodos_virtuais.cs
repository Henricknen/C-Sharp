using System;
class Base {        // classe 'Base'
    public Base() {     // construtor
        Console.WriteLine("Construtor da classe Base");
    }
    
    virtual public void info() {        // método só com a assinatura 'virtual'
        Console.WriteLine("Base");
    }
}

class Derivada1: Base {     // classe 'Derivada1' herda a classe "Base'
    public Derivada1() {        // construtor
        Console.WriteLine("Construtor da classe Derivada 1");
    }

    override public void info() {       // 'override' sobreescreve o método da classe 'base' na classe 'derivada'
        Console.WriteLine("Derivada1");
    }
}

class Derivada2: Derivada1 {        // classe 'Derivada2' herda a classe "Derivada1'
    public Derivada2() {        // construtor
        Console.WriteLine("Construtor da classe Derivada 2");
    }
    
    override public void info() {       // 'override' sobreescreve o  info da classe 'base'
        Console.WriteLine("Derivada2");
    }
}

class Ordem_de_execucao_dos_construtores {
    static void Main() {
        Base Ref;       // com 'Ref' se cria um elemento de refer^rncia que pode receber as classes derivadas da 'base'
        Derivada1 derivada1 = new Derivada1();      // criação de objeto do tipo 'derivada1'
        Derivada2 derivada2 = new Derivada2();
        // derivada1.info();       // chamando método que vem da classe 'base'
        // derivada2.info();
        
        Ref = derivada1;
        Ref.info();     // chama o método 'info' de derivada1
    }

}