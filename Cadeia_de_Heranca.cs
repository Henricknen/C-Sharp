using System;

class Veiculo {        // classe 'Base'
    public int rodas;
    public int veMax;       
    private bool ligado;     // membro ccom 'private' so é possivel acessar de dentro da classe

    public Veiculo(int rodas) {      // construtor
        this.rodas = rodas;     // passando para rodas o valor do paraâmetro 'rodas'
    }
    public void ligar() {       
        ligado = true;
    }
    public void desligar() {       // método 'desligar'
        ligado = false;
    }

    public string getLigado() {
        return (ligado? "Sim" : "Não");     // ultilizando o operador 'ternário'
        // if(ligado) {
        //     return "sim";
        // } else {
        //     return "não";
        // }
    }

    public int getRodas() {
        return rodas;
    }

    public void setRodas(int rodas) {        // ultilizando 'setRodas' para fazer alteração no número de rodas
        if (rodas < 0) {
            this.rodas = 0;
        } else if (rodas > 40) {
            this.rodas = 40;
        } else {
            this.rodas = rodas;
        }
    }
}

    class Carro: Veiculo {       // 'Carro' é classe 'Derivada' e com ':' na frente herda a classe 'Base' 'Veiculo'
        public string nome;    // propriedade 'nome'
        public string cor;         // propriedade 'cor'

        public Carro(string nome, string cor): base(4) {        // contrutor e fazendo a iniçialização do construtor da classe base ultilizando ': base(4)'
            desligar();     // método 'desligar'
            veMax =120;
            this.nome = nome;
            this.cor = cor;
        }
    }

    class CarroCombate: Carro {     // a classe 'CarroCombate' é uma classe derivada da classe 'Carro' e herda todas as propriedades de 'Carro'
        public int municao;

        public CarroCombate(): base("Carro de combate", "Verde") {      // contrutor e fazendo a iniçialização do construtor ultilizndo dois parâmetros 'nome' e 'cor'
            municao = 100;      // definindo munição em 100
            setRodas(6);            // definindo 6 rodas para o carro de combate
        }
    }

class Heranca {
    static void Main() {
        Carro c1 = new Carro("Rapid", "Azul");     // criando 'c1' da classe 'Carro'
        CarroCombate cc1 = new CarroCombate();

        c1.ligar();     // ligando o carro
        
        Console.WriteLine("Cor.......:{0}", c1.cor);
        Console.WriteLine("Nome......:{0}", c1.nome);
        Console.WriteLine("Rodas.....:{0}", c1.getRodas());     // por ser privado para obter as rodas tem é necessario uasr o metodo 'getRodas())'
        Console.WriteLine("Vel.Maxima:{0}", c1.veMax);
        Console.WriteLine("Ligado....:{0}", c1.getLigado());        // ultilizando método 'getLigado' pra fazer impresão
        Console.WriteLine("--------------------------");

        Console.WriteLine("Cor.......:{0}", cc1.cor);
        Console.WriteLine("Nome......:{0}", cc1.nome);
        Console.WriteLine("Rodas.....:{0}", cc1.getRodas());     
        Console.WriteLine("Vel.Maxima:{0}", cc1.veMax);
        Console.WriteLine("Ligado....:{0}", cc1.getLigado());
        Console.WriteLine("Munição....:{0}", cc1.municao);
    }
}