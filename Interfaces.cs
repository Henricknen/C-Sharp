using System;
public interface Veiculo {      // declaração de 'interfaçe'
    void ligar();
    void desligar();    // assinatura dos métodos
    void info();
}

public interface Combate {
    void disparar();        // método
}

class Carro: Veiculo, Combate {     // 'Carro' usa interfaçe 'Veiculo' e interfaçe 'Combate'

    public bool ligado;     // implementação do membro 'ligado'
    private int municao;        // 'private' so pode alterar por métodos
    public Carro() {       // construtor da classe 'Carro'
        setMunicao(100);
    }
    public void setMunicao(int qtde) {
        this.municao = qtde;
    }
    public void ligar() {       // métodos
        this.ligado = true;
    }
    public void desligar() {
        this.ligado = false;
    }
    public void disparar() {}        // métodos
    public void info() {}
}
class Interfaces {
    static void Main() {
        Carro c1 = new Carro();     // criação de 'Carro' da classe 'Carro'
    }
}