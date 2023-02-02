using System;

class Veiculo {        // classe 'Base'
    public int rodas;
    public int veMax;       
    private bool ligado;     // membro ccom 'private' so é possivel acessar de dentro da classe
    public void ligar() {       // método 'ligar'
        ligado = true;
    }
    public void desligar() {       // método 'desligar'
        ligado = false;
    }

    public string getLigado() {
        if(ligado) {
            return "sim";
        } else {
            return "não";
        }
    }
}

    class Carro: Veiculo {       // 'Carro' é classe 'Derivada' e com ':' na frente herda a classe 'Base' 'Veiculo'
        public string nome;    // propriedade 'nome'
        public string cor;         // propriedade 'cor'
        public Carro(string nome, string cor) {        // contrutor
            desligar();     // método 'desligar'
            rodas = 4;
            veMax =120;
            this.nome = nome;
            this.cor = cor;
        }
    }

class Heranca {
    static void Main() {
        Carro c1 = new Carro("Rapid", "Azul");     // criando 'c1' da classe 'Carro'
        
        Console.WriteLine("Cor.......:{0}", c1.cor);
        Console.WriteLine("Nome......:{0}", c1.nome);
        Console.WriteLine("Rodas.....:{0}", c1.rodas);
        Console.WriteLine("Vel.Maxima:{0}", c1.veMax);
        Console.WriteLine("Ligado....:{0}", c1.getLigado());        // ultilizando método 'getLigado' pra fazer impresão
    }
}