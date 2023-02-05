using System;
struct Carro {      // estrutura 'Carro'
    public string marca;
    public string modelo;
    public string cor;
    public Carro(string marca, string modelo, string cor) {       // construtor que atribui valores aos elementos 'marca, modelo e cor'
        this.marca = marca;
        this.modelo = modelo;       // iniçializando os 'membros'
        this.cor = cor;
    }

    public void info() {        // classe que retornará os valores, informações dos 'membros'
        Console.WriteLine("Marca.: {0}", this.marca);
        Console.WriteLine("Modelo: {0}", this.modelo);
        Console.WriteLine("Cor...: {0}", this.cor);
    }
}
class Struct {
    static void Main() {

        Carro c1 = new Carro("Honda", "HRV", "Prata");       // chamando o contrutor de atribuição atraves do 'new'
        Carro c2 = new Carro("VM", "Golf", "Preto");

        // Carro c1;       // aqui já está sendo usada a 'struct' 'Carro'

        // c1.marca = "VW";
        // c1.modelo = "Golf";
        // c1.cor = "Preto";

        c1.info();      // chamando o método 'info' 
        c2.info();
    }
}