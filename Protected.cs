using System;

class Veiculo {     // classe 'Base'
    public int velAtual;

    private int velMax;     // 'private' restringe o acesso ao menbro somente à classe, só pde acessar este membro com métodos da proppria classe 'base'

    protected bool ligado;      // 'protected' permite o acesso aos membros pelas classes derivadas

    public Veiculo(int velMax) {      // construtor recebe um parãmetro de entrada 'int velMax'
        velAtual = 0;
        this.velMax = velMax;
        ligado = false;
    }

    public bool getLigado() {        // método que retornará o 'ligado'
        return ligado;
    }

    public int getVeMax() {
        return velMax;
    }
}

class Carro: Veiculo {      // classe 'Carro' é 'Derivada' e herda classe 'Veiculo'
    public string nome;
    public Carro(string nome, int vm):base(vm) {        // 'vm' vai para entrar no construtor da classe base 'Veiculo'
        this.nome = nome;
        ligado =true;
    }
}

class Protected {
    static void Main() {
        Carro carro = new Carro("Veloz", 120);

        Console.WriteLine("Nome......:{0}", carro.nome);
        Console.WriteLine("Vel.Máxima:{0}", carro.getVeMax());
        Console.WriteLine("Ligado....:{0}", carro.getLigado());
    }
}