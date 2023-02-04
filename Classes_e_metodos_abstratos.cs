using System;

abstract class Veiculo {     // classe base 'abstrata' só serve para ser herdada
    protected int velMaxima;
    protected int velAtual;
    protected bool ligado;
    public Veiculo() {      // construtor
        ligado = false;
        velAtual = 0;
    }
    public void setLigado(bool ligado) {        // método para ligar o Veiculo
        this.ligado = ligado;       // o método 'setLigado' não é abstrato intão é obrigatório implementar a sua funçionalidade
    }
    public int getVelAtual() {
        return velAtual;
    }
    abstract public void aceleracao(int mult);     // método abastrato
}
class Carro:Veiculo {        // classe 'Carro' herda classe 'Veiculo'
    public Carro() {        // construtor da classe 'Carro'
        velMaxima = 120;
    }
    override public void aceleracao(int mult){      // 'override' sobreescreve o método
        velAtual += 10 * mult;
    }
}
class Classes_e_metodos_abstratos {
    static void Main() {
        Carro carro1 = new Carro();

        carro1.aceleracao(1);       // aumentando a açeleração em 10
        carro1.aceleracao(1);
        carro1.aceleracao(-1);          // diminuindo a açeleração em 10

        Console.WriteLine(carro1.getVelAtual());
    }
}